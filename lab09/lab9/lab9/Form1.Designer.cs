namespace lab9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lambda_form = new System.Windows.Forms.NumericUpDown();
            this.mu_form = new System.Windows.Forms.NumericUpDown();
            this.N_form = new System.Windows.Forms.NumericUpDown();
            this.start_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lambda_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu_form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_form)).BeginInit();
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
            this.mu_form.Location = new System.Drawing.Point(140, 55);
            this.mu_form.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.mu_form.Name = "mu_form";
            this.mu_form.Size = new System.Drawing.Size(120, 23);
            this.mu_form.TabIndex = 1;
            this.mu_form.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // N_form
            // 
            this.N_form.Location = new System.Drawing.Point(140, 90);
            this.N_form.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.N_form.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.N_form.Name = "N_form";
            this.N_form.Size = new System.Drawing.Size(120, 23);
            this.N_form.TabIndex = 2;
            this.N_form.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(20, 130);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(110, 30);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Старт";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 4;
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
            this.listBox1.Size = new System.Drawing.Size(280, 139);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Интенс. λ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Интенс. μ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Всего заявок (N):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.N_form);
            this.Controls.Add(this.mu_form);
            this.Controls.Add(this.lambda_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Имитационное моделирование СМО (M/M/1/0)";
            ((System.ComponentModel.ISupportInitialize)(this.lambda_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu_form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lambda_form;
        private System.Windows.Forms.NumericUpDown mu_form;
        private System.Windows.Forms.NumericUpDown N_form;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}