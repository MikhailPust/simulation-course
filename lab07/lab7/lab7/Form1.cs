using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        double[,] Q = new double[3, 3];
        int currentState;   
        int initialState;   
        double currentTime;
        double totalTime;

        List<(double time, int state)> history = new List<(double time, int state)>();
        double[] stateTime = new double[3];
        double[] pi = new double[3];   
        double[] empirical = new double[3];   

        private static readonly string SavePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            "weather_results.csv");

        private static readonly string[] StateNames = { "Ясно", "Облачно", "Пасмурно" };
        private static readonly string[] StateIcons = { "☀", "⛅", "☁" };

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Enabled = false;
            numericUpDown5.Enabled = false;
            numericUpDown9.Enabled = false;
            chart1.Series.Clear();
            chart1.Series.Add("Ясно");
            chart1.Series.Add("Облачно");
            chart1.Series.Add("Пасмурно");

            chart1.Series[0].Color = Color.FromArgb(255, 179, 0);    
            chart1.Series[1].Color = Color.FromArgb(21, 101, 192);   
            chart1.Series[2].Color = Color.FromArgb(69, 90, 100);    
            foreach (var s in chart1.Series)
            {
                s.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                s.BorderWidth = 3;
            }

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "F0";
            chart1.ChartAreas[0].AxisX.Title = "Время (дни)";
            chart1.ChartAreas[0].AxisY.Title = "Частота";

            numericUpDown2.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown3.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown4.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown6.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown7.ValueChanged += (s, e) => UpdateDiagonal();
            numericUpDown8.ValueChanged += (s, e) => UpdateDiagonal();

            timer1.Interval = 200;
            timer1.Tick += Timer_Tick;

            log_Day.Text = "—";
            label_initState.Text = "Нач. состояние:\n—";
            UpdateDiagonal();
        }

        private void UpdateDiagonal()
        {
            numericUpDown1.Value = -(numericUpDown2.Value + numericUpDown3.Value);
            numericUpDown5.Value = -(numericUpDown4.Value + numericUpDown6.Value);
            numericUpDown9.Value = -(numericUpDown7.Value + numericUpDown8.Value);
        }

        private void BuildQMatrix()
        {
            double q12 = (double)numericUpDown2.Value;
            double q13 = (double)numericUpDown3.Value;
            double q21 = (double)numericUpDown4.Value;
            double q23 = (double)numericUpDown6.Value;
            double q31 = (double)numericUpDown7.Value;
            double q32 = (double)numericUpDown8.Value;

            Q[0, 1] = q12; Q[0, 2] = q13; Q[0, 0] = -(q12 + q13);
            Q[1, 0] = q21; Q[1, 2] = q23; Q[1, 1] = -(q21 + q23);
            Q[2, 0] = q31; Q[2, 1] = q32; Q[2, 2] = -(q31 + q32);
        }

        private int ChooseInitialState()
        {
            int best = 0;
            double maxIntensity = -Q[0, 0];
            for (int i = 1; i < 3; i++)
            {
                double intensity = -Q[i, i];
                if (intensity > maxIntensity)
                {
                    maxIntensity = intensity;
                    best = i;
                }
            }
            return best;
        }

        private (int nextState, double dt) NextState(int state)
        {
            double qii = Q[state, state];               
            double dt = Math.Log(random.NextDouble()) / qii; 

            double r = random.NextDouble();
            double sum = 0;
            for (int j = 0; j < 3; j++)
            {
                if (j == state) continue;
                sum += Q[state, j] / (-qii);
                if (r < sum) return (j, dt);
            }
            return (state, dt);   
        }

        private void Start_Click(object sender, EventArgs e)
        {
            BuildQMatrix();
            totalTime = (double)T.Value;

            currentTime = 0;
            currentState = ChooseInitialState();
            initialState = currentState;

            history.Clear();
            Array.Clear(stateTime, 0, stateTime.Length);

            foreach (var s in chart1.Series) s.Points.Clear();
            listBox1.Items.Clear();

            label_initState.Text =
                $"Нач. состояние:\n{StateIcons[initialState]} {StateNames[initialState]}\n" +
                $"λ = {-Q[initialState, initialState]:F2} дн⁻¹";

            timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentTime >= totalTime)
            {
                timer1.Stop();
                CalculateStatistics();
                return;
            }

            var (nextState, dt) = NextState(currentState);

            if (currentTime + dt > totalTime)
                dt = totalTime - currentTime;

            stateTime[currentState] += dt;
            currentTime += dt;
            history.Add((currentTime, currentState));

            int day = (int)Math.Floor(currentTime) + 1;
            log_Day.Text =
                $"{StateIcons[currentState]} {StateNames[currentState]}\n" +
                $"День: {day}\n" +
                $"t = {currentTime:F1} дн.";

            for (int i = 0; i < 3; i++)
                chart1.Series[i].Points.AddXY(currentTime, stateTime[i] / currentTime);

            currentState = nextState;
        }

        private void CalculateStatistics()
        {
            for (int i = 0; i < 3; i++)
                empirical[i] = stateTime[i] / currentTime;

            double[,] matrix = {
                { Q[0, 0], Q[1, 0], Q[2, 0] },
                { Q[0, 1], Q[1, 1], Q[2, 1] },
                { 1,       1,       1       }
            };
            double[] constants = { 0, 0, 1 };

            double det = Determinant3x3(matrix);
            if (Math.Abs(det) > 1e-9)
                for (int i = 0; i < 3; i++)
                    pi[i] = Determinant3x3(ReplaceColumn(matrix, constants, i)) / det;

            listBox1.Items.Clear();
            listBox1.Items.Add("═══ РЕЗУЛЬТАТЫ МОДЕЛИРОВАНИЯ ═══");
            listBox1.Items.Add($"  Период: {totalTime:F0} дн.  |  Переходов: {history.Count}");
            listBox1.Items.Add("────────────────────────────────────");
            listBox1.Items.Add("  Состояние  │ Эмп.   │ Теор.  │   Δ");
            listBox1.Items.Add("────────────────────────────────────");
            for (int i = 0; i < 3; i++)
            {
                double diff = Math.Abs(empirical[i] - pi[i]);
                listBox1.Items.Add(
                    $"  {StateNames[i],-10} │ {empirical[i]:F4} │ {pi[i]:F4} │ {diff:F4}");
            }
            listBox1.Items.Add("────────────────────────────────────");
            listBox1.Items.Add($"  Файл: {SavePath}");

            SaveResults();
            MessageBox.Show(
                $"Моделирование завершено!\n\nРезультаты автоматически сохранены:\n{SavePath}",
                "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveResults()
        {
            try
            {
                using (var sw = new StreamWriter(SavePath, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine("# Марковская модель погоды — результаты моделирования");
                    sw.WriteLine($"# Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                    sw.WriteLine($"# Период моделирования: {totalTime} дней");
                    sw.WriteLine($"# Начальное состояние: {StateNames[initialState]} " +
                                 $"(выбрано по максимальной интенсивности выхода λ={-Q[initialState, initialState]:F3})");
                    sw.WriteLine("#");
                    sw.WriteLine("# Матрица интенсивностей Q (генератор цепи):");
                    sw.WriteLine($"# [ {Q[0, 0]:F3}  {Q[0, 1]:F3}  {Q[0, 2]:F3} ]");
                    sw.WriteLine($"# [ {Q[1, 0]:F3}  {Q[1, 1]:F3}  {Q[1, 2]:F3} ]");
                    sw.WriteLine($"# [ {Q[2, 0]:F3}  {Q[2, 1]:F3}  {Q[2, 2]:F3} ]");
                    sw.WriteLine("#");
                    sw.WriteLine("# === ИСТОРИЯ ПЕРЕХОДОВ ===");
                    sw.WriteLine("Время;Номер состояния;Название состояния");
                    foreach (var entry in history)
                        sw.WriteLine($"{entry.time:F4};{entry.state + 1};{StateNames[entry.state]}");

                    sw.WriteLine();
                    sw.WriteLine("# === СТАТИСТИКА ПО СОСТОЯНИЯМ ===");
                    sw.WriteLine("Состояние;Время пребывания (дн);Эмпирическая частота;Теоретическая частота;Отклонение");
                    for (int i = 0; i < 3; i++)
                    {
                        double diff = Math.Abs(empirical[i] - pi[i]);
                        sw.WriteLine($"{StateNames[i]};{stateTime[i]:F4};{empirical[i]:F6};{pi[i]:F6};{diff:F6}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Determinant3x3(double[,] m) =>
            m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
          - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
          + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);

        private double[,] ReplaceColumn(double[,] m, double[] col, int colIndex)
        {
            double[,] res = (double[,])m.Clone();
            for (int i = 0; i < 3; i++) res[i, colIndex] = col[i];
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            history.Clear();
            Array.Clear(stateTime, 0, stateTime.Length);
            foreach (var s in chart1.Series) s.Points.Clear();
            listBox1.Items.Clear();
            log_Day.Text = "—";
            label_initState.Text = "Нач. состояние:\n—";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                MessageBox.Show("Нет данных. Запустите моделирование.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveResults();
            MessageBox.Show($"Данные сохранены:\n{SavePath}",
                "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e) => Close();
    }
}