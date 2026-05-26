using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            double lambda = (double)lambda_form.Value;
            double mu = (double)mu_form.Value;
            int totalRequests = (int)N_form.Value;
            int serversCount = (int)servers_form.Value;
            int maxQueue = (int)queue_form.Value;

            // Создаем экземпляр нашей модели 
            var model = new QueueingSystem(lambda, mu, serversCount, maxQueue, totalRequests);
            model.RunSimulation();
            listBox1.Items.Clear();
            listBox1.Items.Add("=== Статистика M/M/N/K ===");
            listBox1.Items.Add($"Всего заявок: {model.TotalRequests}");
            listBox1.Items.Add($"Обслужено: {model.SuccessfulRequests}");
            listBox1.Items.Add($"Отказано: {model.RejectedRequests}");
            listBox1.Items.Add($"Вероятность отказа: {model.RejectProbability:P2}");
            listBox1.Items.Add($"Пропускная способность: {model.Throughput:P2}");
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Сначала запустите моделирование!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string path = "results.txt";
            var lines = listBox1.Items.Cast<string>().ToList();
            File.WriteAllLines(path, lines);
            MessageBox.Show($"Результаты успешно сохранены в файл:\n{Path.GetFullPath(path)}", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Server
    {
        public double NextCompletionTime { get; set; } = double.MaxValue;
        public bool IsBusy => NextCompletionTime != double.MaxValue;
    }

    public class QueueingSystem
    {
        private Random rnd = new Random();
        public double Lambda { get; }
        public double Mu { get; }
        public int ServersCount { get; }
        public int MaxQueue { get; }
        public int TotalRequests { get; }

        public int SuccessfulRequests { get; private set; }
        public int RejectedRequests { get; private set; }

        public double RejectProbability => (double)RejectedRequests / TotalRequests;
        public double Throughput => 1.0 - RejectProbability;

        public QueueingSystem(double lambda, double mu, int serversCount, int maxQueue, int totalRequests)
        {
            Lambda = lambda;
            Mu = mu;
            ServersCount = serversCount;
            MaxQueue = maxQueue;
            TotalRequests = totalRequests;
        }

        public void RunSimulation()
        {
            List<Server> servers = new List<Server>();
            for (int i = 0; i < ServersCount; i++)
                servers.Add(new Server());

            int generatedRequests = 0;
            int handledRequests = 0; // Заявки, которые окончательно покинули систему (обслужены или отказаны)
            int currentQueue = 0;
            double currentTime = 0;
            double nextArrival = ExpTime(Lambda);

            while (handledRequests < TotalRequests)
            {
                double minCompletion = double.MaxValue;
                Server nextServer = null;

                // Ищем прибор, который освободится раньше всех
                foreach (var s in servers)
                {
                    if (s.NextCompletionTime < minCompletion)
                    {
                        minCompletion = s.NextCompletionTime;
                        nextServer = s;
                    }
                }

                if (generatedRequests == TotalRequests) nextArrival = double.MaxValue;

                if (nextArrival < minCompletion)
                {
                    currentTime = nextArrival;
                    generatedRequests++;

                    var freeServer = servers.FirstOrDefault(s => !s.IsBusy);
                    if (freeServer != null)
                    {
                        freeServer.NextCompletionTime = currentTime + ExpTime(Mu);
                    }
                    else if (currentQueue < MaxQueue)
                    {
                        currentQueue++;
                    }
                    else
                    {
                        RejectedRequests++;
                        handledRequests++;
                    }

                    if (generatedRequests < TotalRequests)
                        nextArrival = currentTime + ExpTime(Lambda);
                }
                else
                {
                    currentTime = minCompletion;
                    SuccessfulRequests++;
                    handledRequests++;

                    if (currentQueue > 0)
                    {
                        currentQueue--;
                        nextServer.NextCompletionTime = currentTime + ExpTime(Mu);
                    }
                    else
                    {
                        nextServer.NextCompletionTime = double.MaxValue;
                    }
                }
            }
        }

        private double ExpTime(double rate)
        {
            return -Math.Log(1.0 - rnd.NextDouble()) / rate;
        }
    }
}