namespace lab7
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
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.startThread1 = new System.Windows.Forms.Button();
            this.stopThread1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stopThread2 = new System.Windows.Forms.Button();
            this.startThread2 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальное значение:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.amount.Location = new System.Drawing.Point(352, 20);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(39, 38);
            this.amount.TabIndex = 1;
            this.amount.Text = "0";
            // 
            // startThread1
            // 
            this.startThread1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startThread1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startThread1.Location = new System.Drawing.Point(107, 296);
            this.startThread1.Name = "startThread1";
            this.startThread1.Size = new System.Drawing.Size(143, 54);
            this.startThread1.TabIndex = 2;
            this.startThread1.Text = "Запустить";
            this.startThread1.UseVisualStyleBackColor = false;
            this.startThread1.Click += new System.EventHandler(this.startThread1_Click);
            // 
            // stopThread1
            // 
            this.stopThread1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopThread1.Location = new System.Drawing.Point(107, 384);
            this.stopThread1.Name = "stopThread1";
            this.stopThread1.Size = new System.Drawing.Size(143, 54);
            this.stopThread1.TabIndex = 3;
            this.stopThread1.Text = "Остановить";
            this.stopThread1.UseVisualStyleBackColor = false;
            this.stopThread1.Click += new System.EventHandler(this.stopThread1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Поток 1: \r\nувеличение значения счета";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Поток 2: \r\nвывод значения в произвольный момент\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopThread2
            // 
            this.stopThread2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopThread2.Location = new System.Drawing.Point(517, 384);
            this.stopThread2.Name = "stopThread2";
            this.stopThread2.Size = new System.Drawing.Size(143, 54);
            this.stopThread2.TabIndex = 6;
            this.stopThread2.Text = "Остановить";
            this.stopThread2.UseVisualStyleBackColor = false;
            this.stopThread2.Click += new System.EventHandler(this.stopThread2_Click);
            // 
            // startThread2
            // 
            this.startThread2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startThread2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startThread2.Location = new System.Drawing.Point(517, 296);
            this.startThread2.Name = "startThread2";
            this.startThread2.Size = new System.Drawing.Size(143, 54);
            this.startThread2.TabIndex = 5;
            this.startThread2.Text = "Запустить";
            this.startThread2.UseVisualStyleBackColor = false;
            this.startThread2.Click += new System.EventHandler(this.startThread2_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Georgia", 40F, System.Drawing.FontStyle.Italic);
            this.time.Location = new System.Drawing.Point(343, 92);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(88, 91);
            this.time.TabIndex = 8;
            this.time.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopThread2);
            this.Controls.Add(this.startThread2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopThread1);
            this.Controls.Add(this.startThread1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button startThread1;
        private System.Windows.Forms.Button stopThread1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button stopThread2;
        private System.Windows.Forms.Button startThread2;
        private System.Windows.Forms.Label time;
    }
}

