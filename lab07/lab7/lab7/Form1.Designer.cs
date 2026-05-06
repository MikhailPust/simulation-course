using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 =
                new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 =
                new System.Windows.Forms.DataVisualization.Charting.Series();

            // ── Элементы управления ──────────────────────────────────
            Start = new Button();
            button1 = new Button();
            button2 = new Button();
            save_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);

            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            numericUpDown9 = new NumericUpDown();
            T = new NumericUpDown();

            log_Day = new Label();
            label1 = new Label();
            label_initState = new Label();
            label_title = new Label();
            label_matHdr = new Label();
            label_col1 = new Label();
            label_col2 = new Label();
            label_col3 = new Label();
            label_row1 = new Label();
            label_row2 = new Label();
            label_row3 = new Label();
            label_statsHdr = new Label();
            label_stateHdr = new Label();

            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // BeginInit
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)T).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            // ── label_title ───────────────────────────────────────────
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_title.ForeColor = Color.FromArgb(13, 71, 161);
            label_title.Location = new Point(550, 15);
            label_title.Name = "label_title";
            label_title.Text = "Марковская модель погоды";

            // ── label_matHdr ──────────────────────────────────────────
            label_matHdr.AutoSize = true;
            label_matHdr.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label_matHdr.ForeColor = Color.FromArgb(40, 40, 40);
            label_matHdr.Location = new Point(12, 15);
            label_matHdr.Name = "label_matHdr";
            label_matHdr.Text = "Матрица Q [интенсивности, дн⁻¹]:";

            // ── Заголовки столбцов (по состояниям назначения) ─────────
            label_col1.AutoSize = true;
            label_col1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_col1.ForeColor = Color.FromArgb(230, 119, 0);
            label_col1.Location = new Point(133, 45);
            label_col1.Name = "label_col1";
            label_col1.Text = "→ Ясно";

            label_col2.AutoSize = true;
            label_col2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_col2.ForeColor = Color.FromArgb(21, 101, 192);
            label_col2.Location = new Point(227, 45);
            label_col2.Name = "label_col2";
            label_col2.Text = "→ Облачно";

            label_col3.AutoSize = true;
            label_col3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_col3.ForeColor = Color.FromArgb(69, 90, 100);
            label_col3.Location = new Point(323, 45);
            label_col3.Name = "label_col3";
            label_col3.Text = "→ Пасм.";

            // ── Заголовки строк (состояния источника) ─────────────────
            label_row1.AutoSize = true;
            label_row1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_row1.ForeColor = Color.FromArgb(230, 119, 0);
            label_row1.Location = new Point(12, 85);
            label_row1.Name = "label_row1";
            label_row1.Text = "Ясно";

            label_row2.AutoSize = true;
            label_row2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_row2.ForeColor = Color.FromArgb(21, 101, 192);
            label_row2.Location = new Point(12, 135);
            label_row2.Name = "label_row2";
            label_row2.Text = "Облачно";

            label_row3.AutoSize = true;
            label_row3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_row3.ForeColor = Color.FromArgb(69, 90, 100);
            label_row3.Location = new Point(12, 185);
            label_row3.Name = "label_row3";
            label_row3.Text = "Пасмурно";

       
            numericUpDown1.BackColor = Color.FromArgb(210, 215, 220);
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Location = new Point(133, 80);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 31);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, -2147418112 });

            // q12
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(227, 80);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(73, 31);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 65536 });

            // q13
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(323, 80);
            numericUpDown3.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(73, 31);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 65536 });

            // q21
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(133, 130);
            numericUpDown4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(73, 31);
            numericUpDown4.TabIndex = 7;
            numericUpDown4.Value = new decimal(new int[] { 4, 0, 0, 65536 });

            // q22 (диагональ, disabled)
            numericUpDown5.BackColor = Color.FromArgb(210, 215, 220);
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown5.Location = new Point(227, 130);
            numericUpDown5.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(73, 31);
            numericUpDown5.TabIndex = 6;
            numericUpDown5.Value = new decimal(new int[] { 8, 0, 0, -2147418112 });

            // q23
            numericUpDown6.DecimalPlaces = 1;
            numericUpDown6.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown6.Location = new Point(323, 130);
            numericUpDown6.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(73, 31);
            numericUpDown6.TabIndex = 5;
            numericUpDown6.Value = new decimal(new int[] { 4, 0, 0, 65536 });

            // q31
            numericUpDown7.DecimalPlaces = 1;
            numericUpDown7.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown7.Location = new Point(133, 180);
            numericUpDown7.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(73, 31);
            numericUpDown7.TabIndex = 10;
            numericUpDown7.Value = new decimal(new int[] { 1, 0, 0, 65536 });

            // q32
            numericUpDown8.DecimalPlaces = 1;
            numericUpDown8.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown8.Location = new Point(227, 180);
            numericUpDown8.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(73, 31);
            numericUpDown8.TabIndex = 9;
            numericUpDown8.Value = new decimal(new int[] { 4, 0, 0, 65536 });

            // q33 (диагональ, disabled)
            numericUpDown9.BackColor = Color.FromArgb(210, 215, 220);
            numericUpDown9.DecimalPlaces = 1;
            numericUpDown9.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown9.Location = new Point(323, 180);
            numericUpDown9.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown9.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(73, 31);
            numericUpDown9.TabIndex = 8;
            numericUpDown9.Value = new decimal(new int[] { 5, 0, 0, -2147418112 });

            // ── T (период моделирования) ───────────────────────────────
            T.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            T.Location = new Point(670, 75);
            T.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            T.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            T.Name = "T";
            T.Size = new Size(90, 31);
            T.TabIndex = 13;
            T.Value = new decimal(new int[] { 300, 0, 0, 0 });
            T.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // ── label1 (подпись к T) ──────────────────────────────────
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(500, 80);
            label1.Name = "label1";
            label1.Text = "Период [дн.]:";

            // ── Разделительная линия ──────────────────────────────────
            pictureBox1.BackColor = Color.FromArgb(66, 133, 244);
            pictureBox1.Location = new Point(-1, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1500, 3);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;

            // ── label_stateHdr (над log_Day) ──────────────────────────
            label_stateHdr.AutoSize = false;
            label_stateHdr.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            label_stateHdr.ForeColor = Color.White;
            label_stateHdr.BackColor = Color.FromArgb(10, 55, 120);
            label_stateHdr.Location = new Point(1304, 220);
            label_stateHdr.Name = "label_stateHdr";
            label_stateHdr.Size = new Size(126, 30);
            label_stateHdr.Text = "  Текущее состояние";
            label_stateHdr.TextAlign = ContentAlignment.MiddleLeft;

            // ── log_Day (текущее состояние) ───────────────────────────
            log_Day.BackColor = Color.FromArgb(13, 71, 161);
            log_Day.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            log_Day.ForeColor = Color.White;
            log_Day.Location = new Point(1304, 255);
            log_Day.Name = "log_Day";
            log_Day.Size = new Size(126, 95);
            log_Day.TabIndex = 12;
            log_Day.Text = "—";
            log_Day.TextAlign = ContentAlignment.MiddleCenter;

            // ── label_initState (начальное состояние) ────────────────
            label_initState.BackColor = Color.FromArgb(21, 101, 192);
            label_initState.Font = new Font("Segoe UI", 9F);
            label_initState.ForeColor = Color.White;
            label_initState.Location = new Point(1304, 362);
            label_initState.Name = "label_initState";
            label_initState.Size = new Size(126, 90);
            label_initState.TabIndex = 20;
            label_initState.Text = "Нач. состояние:\n—";
            label_initState.TextAlign = ContentAlignment.MiddleCenter;

            // ── Кнопка Старт ──────────────────────────────────────────
            Start.BackColor = Color.FromArgb(46, 125, 50);
            Start.FlatStyle = FlatStyle.Flat;
            Start.FlatAppearance.BorderSize = 0;
            Start.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Start.ForeColor = Color.White;
            Start.Location = new Point(1304, 500);
            Start.Name = "Start";
            Start.Size = new Size(126, 48);
            Start.TabIndex = 0;
            Start.Text = "▶  Старт";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;

            // ── Кнопка Очистить ───────────────────────────────────────
            button1.BackColor = Color.FromArgb(230, 81, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1304, 560);
            button1.Name = "button1";
            button1.Size = new Size(126, 45);
            button1.TabIndex = 18;
            button1.Text = "↺  Очистить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // ── Кнопка Сохранить ──────────────────────────────────────
            save_button.BackColor = Color.FromArgb(0, 105, 92);
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.FlatAppearance.BorderSize = 0;
            save_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            save_button.ForeColor = Color.White;
            save_button.Location = new Point(1304, 620);
            save_button.Name = "save_button";
            save_button.Size = new Size(126, 45);
            save_button.TabIndex = 19;
            save_button.Text = "💾  Сохранить";
            save_button.UseVisualStyleBackColor = false;
            save_button.Click += save_button_Click;

            // ── Кнопка Выход (правый верхний угол) ────────────────────
            button2.BackColor = Color.FromArgb(198, 40, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1387, 12);
            button2.Name = "button2";
            button2.Size = new Size(43, 37);
            button2.TabIndex = 1;
            button2.Text = "✕";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // ── label_statsHdr (над ListBox) ──────────────────────────
            label_statsHdr.AutoSize = false;
            label_statsHdr.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label_statsHdr.ForeColor = Color.White;
            label_statsHdr.BackColor = Color.FromArgb(13, 71, 161);
            label_statsHdr.Location = new Point(14, 430);
            label_statsHdr.Name = "label_statsHdr";
            label_statsHdr.Size = new Size(469, 38);
            label_statsHdr.Text = "  Статистика и результаты";
            label_statsHdr.TextAlign = ContentAlignment.MiddleLeft;

            // ── ListBox (статистика) ───────────────────────────────────
            listBox1.BackColor = Color.FromArgb(240, 248, 255);
            listBox1.Font = new Font("Consolas", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(12, 471);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(469, 329);
            listBox1.TabIndex = 16;

            // ── Chart ──────────────────────────────────────────────────
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(497, 233);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(795, 567);
            chart1.TabIndex = 17;
            chart1.Text = "chart1";

            // ── Форма ─────────────────────────────────────────────────
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 240, 255);
            ClientSize = new Size(1439, 830);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Марковская модель погоды";

            Controls.Add(label_title);
            Controls.Add(label_matHdr);
            Controls.Add(label_col1);
            Controls.Add(label_col2);
            Controls.Add(label_col3);
            Controls.Add(label_row1);
            Controls.Add(label_row2);
            Controls.Add(label_row3);
            Controls.Add(numericUpDown1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown7);
            Controls.Add(numericUpDown8);
            Controls.Add(numericUpDown9);
            Controls.Add(T);
            Controls.Add(label1);
            Controls.Add(label_stateHdr);
            Controls.Add(log_Day);
            Controls.Add(label_initState);
            Controls.Add(pictureBox1);
            Controls.Add(label_statsHdr);
            Controls.Add(listBox1);
            Controls.Add(chart1);
            Controls.Add(Start);
            Controls.Add(button1);
            Controls.Add(save_button);
            Controls.Add(button2);

            // EndInit
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).EndInit();
            ((System.ComponentModel.ISupportInitialize)T).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ── Объявления полей ─────────────────────────────────────────
        private Button Start;
        private Button button1;
        private Button button2;
        private Button save_button;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown9;
        private NumericUpDown T;
        private Label log_Day;
        private Label label1;
        private Label label_initState;
        private Label label_title;
        private Label label_matHdr;
        private Label label_col1;
        private Label label_col2;
        private Label label_col3;
        private Label label_row1;
        private Label label_row2;
        private Label label_row3;
        private Label label_statsHdr;
        private Label label_stateHdr;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}