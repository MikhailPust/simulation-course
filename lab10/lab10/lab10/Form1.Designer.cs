namespace lab10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lambda_form = new System.Windows.Forms.NumericUpDown();
            this.mu_form = new System.Windows.Forms.NumericUpDown();
            this.N_form = new System.Windows.Forms.NumericUpDown();
            this.servers_form = new System.Windows.Forms.NumericUpDown();
            this.queue_form = new System.Windows.Forms.NumericUpDown();
            this.start_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lambda_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servers_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_form)).BeginInit();
            this.SuspendLayout();
            // 
            // lambda_form
            // 
            this.lambda_form.DecimalPlaces = 2;
            this.lambda_form.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.lambda_form.Location = new System.Drawing.Point(140, 20);
            this.lambda_form.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.lambda_form.Name = "lambda_form";
            this.lambda_form.Size = new System.Drawing.Size(120, 23);
            this.lambda_form.TabIndex = 0;
            this.lambda_form.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // mu_form
            // 
            this.mu_form.DecimalPlaces = 2;
            this.mu_form.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.mu_form.Location = new System.Drawing.Point(140, 50);
            this.mu_form.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.mu_form.Name = "mu_form";
            this.mu_form.Size = new System.Drawing.Size(120, 23);
            this.mu_form.TabIndex = 1;
            this.mu_form.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // servers_form
            // 
            this.servers_form.Location = new System.Drawing.Point(140, 80);
            this.servers_form.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.servers_form.Name = "servers_form";
            this.servers_form.Size = new System.Drawing.Size(120, 23);
            this.servers_form.TabIndex = 2;
            this.servers_form.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // queue_form
            // 
            this.queue_form.Location = new System.Drawing.Point(140, 110);
            this.queue_form.Name = "queue_form";
            this.queue_form.Size = new System.Drawing.Size(120, 23);
            this.queue_form.TabIndex = 3;
            this.queue_form.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // N_form
            // 
            this.N_form.Location = new System.Drawing.Point(140, 140);
            this.N_form.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.N_form.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.N_form.Name = "N_form";
            this.N_form.Size = new System.Drawing.Size(120, 23);
            this.N_form.TabIndex = 4;
            this.N_form.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(20, 180);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 30);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(105, 180);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(85, 30);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "В файл";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(280, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 184);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Интенс. λ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Интенс. μ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Приборов (N):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Длина очереди (K):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Всего заявок:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 231);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.N_form);
            this.Controls.Add(this.queue_form);
            this.Controls.Add(this.servers_form);
            this.Controls.Add(this.mu_form);
            this.Controls.Add(this.lambda_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "СМО (M/M/N/K) - ООП Симуляция";
            ((System.ComponentModel.ISupportInitialize)(this.lambda_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servers_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queue_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown lambda_form;
        private System.Windows.Forms.NumericUpDown mu_form;
        private System.Windows.Forms.NumericUpDown N_form;
        private System.Windows.Forms.NumericUpDown servers_form;
        private System.Windows.Forms.NumericUpDown queue_form;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}