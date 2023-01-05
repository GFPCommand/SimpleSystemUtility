namespace Helpful
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userInfoButton = new System.Windows.Forms.Button();
            this.gpuInfoButton = new System.Windows.Forms.Button();
            this.motherboardInfoButton = new System.Windows.Forms.Button();
            this.storageInfoButton = new System.Windows.Forms.Button();
            this.ramInfoButton = new System.Windows.Forms.Button();
            this.cpuInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.userInfoButton);
            this.panel1.Controls.Add(this.gpuInfoButton);
            this.panel1.Controls.Add(this.motherboardInfoButton);
            this.panel1.Controls.Add(this.storageInfoButton);
            this.panel1.Controls.Add(this.ramInfoButton);
            this.panel1.Controls.Add(this.cpuInfoButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 370);
            this.panel1.TabIndex = 0;
            // 
            // userInfoButton
            // 
            this.userInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userInfoButton.Location = new System.Drawing.Point(0, 310);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(79, 56);
            this.userInfoButton.TabIndex = 5;
            this.userInfoButton.Text = "User";
            this.userInfoButton.UseVisualStyleBackColor = true;
            this.userInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // gpuInfoButton
            // 
            this.gpuInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpuInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gpuInfoButton.Location = new System.Drawing.Point(0, 248);
            this.gpuInfoButton.Name = "gpuInfoButton";
            this.gpuInfoButton.Size = new System.Drawing.Size(79, 56);
            this.gpuInfoButton.TabIndex = 4;
            this.gpuInfoButton.Text = "GPU";
            this.gpuInfoButton.UseVisualStyleBackColor = true;
            this.gpuInfoButton.Click += new System.EventHandler(this.gpuInfoButton_Click);
            // 
            // motherboardInfoButton
            // 
            this.motherboardInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motherboardInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motherboardInfoButton.Location = new System.Drawing.Point(0, 186);
            this.motherboardInfoButton.Name = "motherboardInfoButton";
            this.motherboardInfoButton.Size = new System.Drawing.Size(79, 56);
            this.motherboardInfoButton.TabIndex = 3;
            this.motherboardInfoButton.Text = "MB";
            this.motherboardInfoButton.UseVisualStyleBackColor = true;
            this.motherboardInfoButton.Click += new System.EventHandler(this.motherboardInfoButton_Click);
            // 
            // storageInfoButton
            // 
            this.storageInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storageInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.storageInfoButton.Location = new System.Drawing.Point(0, 124);
            this.storageInfoButton.Name = "storageInfoButton";
            this.storageInfoButton.Size = new System.Drawing.Size(79, 56);
            this.storageInfoButton.TabIndex = 2;
            this.storageInfoButton.Text = "Storage";
            this.storageInfoButton.UseVisualStyleBackColor = true;
            this.storageInfoButton.Click += new System.EventHandler(this.storageInfoButton_Click);
            // 
            // ramInfoButton
            // 
            this.ramInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ramInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramInfoButton.Location = new System.Drawing.Point(0, 62);
            this.ramInfoButton.Name = "ramInfoButton";
            this.ramInfoButton.Size = new System.Drawing.Size(79, 56);
            this.ramInfoButton.TabIndex = 1;
            this.ramInfoButton.Text = "RAM";
            this.ramInfoButton.UseVisualStyleBackColor = true;
            this.ramInfoButton.Click += new System.EventHandler(this.ramInfoButton_Click);
            // 
            // cpuInfoButton
            // 
            this.cpuInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpuInfoButton.Location = new System.Drawing.Point(0, 0);
            this.cpuInfoButton.Name = "cpuInfoButton";
            this.cpuInfoButton.Size = new System.Drawing.Size(79, 56);
            this.cpuInfoButton.TabIndex = 0;
            this.cpuInfoButton.Text = "CPU";
            this.cpuInfoButton.UseVisualStyleBackColor = true;
            this.cpuInfoButton.Click += new System.EventHandler(this.cpuInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(86, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cores: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(86, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Threads: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(86, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identifier: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(86, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Frequency: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(86, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Max frequency: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 371);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(630, 410);
            this.Name = "Form1";
            this.Text = "System Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button storageInfoButton;
        private System.Windows.Forms.Button ramInfoButton;
        private System.Windows.Forms.Button cpuInfoButton;
        private System.Windows.Forms.Button gpuInfoButton;
        private System.Windows.Forms.Button motherboardInfoButton;
        private System.Windows.Forms.Button userInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

