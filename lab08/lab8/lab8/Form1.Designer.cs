namespace lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.intensity = new System.Windows.Forms.NumericUpDown();
            this.T_mod = new System.Windows.Forms.NumericUpDown();
            this.N_start = new System.Windows.Forms.NumericUpDown();
            this.start_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_start)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(340, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(532, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.750001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 212);
            this.listBox1.TabIndex = 1;
            // 
            // intensity
            // 
            this.intensity.DecimalPlaces = 2;
            this.intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.intensity.Location = new System.Drawing.Point(170, 20);
            this.intensity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.intensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.intensity.Name = "intensity";
            this.intensity.Size = new System.Drawing.Size(120, 20);
            this.intensity.TabIndex = 2;
            this.intensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // T_mod
            // 
            this.T_mod.Location = new System.Drawing.Point(170, 60);
            this.T_mod.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.T_mod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.T_mod.Name = "T_mod";
            this.T_mod.Size = new System.Drawing.Size(120, 20);
            this.T_mod.TabIndex = 3;
            this.T_mod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // N_start
            // 
            this.N_start.Location = new System.Drawing.Point(170, 100);
            this.N_start.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.N_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.N_start.Name = "N_start";
            this.N_start.Size = new System.Drawing.Size(120, 20);
            this.N_start.TabIndex = 4;
            this.N_start.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 145);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(140, 30);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Интенсивность (lambda):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Интервал времени T:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число экспериментов N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.N_start);
            this.Controls.Add(this.T_mod);
            this.Controls.Add(this.intensity);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №8 - Моделирование пуассоновского потока";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown intensity;
        private System.Windows.Forms.NumericUpDown T_mod;
        private System.Windows.Forms.NumericUpDown N_start;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}