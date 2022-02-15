namespace Deneme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.task1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.task2 = new System.Windows.Forms.Label();
            this.task3 = new System.Windows.Forms.Label();
            this.task5 = new System.Windows.Forms.Label();
            this.task4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.AutoSize = true;
            this.task1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.task1.Location = new System.Drawing.Point(237, 9);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(0, 13);
            this.task1.TabIndex = 0;
            this.task1.Click += new System.EventHandler(this.test_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 114);
            this.button1.TabIndex = 2;
            this.button1.Text = "text dosyanı seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // task2
            // 
            this.task2.AutoSize = true;
            this.task2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.task2.Location = new System.Drawing.Point(237, 36);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(0, 13);
            this.task2.TabIndex = 3;
            // 
            // task3
            // 
            this.task3.AutoSize = true;
            this.task3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.task3.Location = new System.Drawing.Point(237, 66);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(0, 13);
            this.task3.TabIndex = 4;
            // 
            // task5
            // 
            this.task5.AutoSize = true;
            this.task5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.task5.Location = new System.Drawing.Point(237, 116);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(0, 13);
            this.task5.TabIndex = 6;
            // 
            // task4
            // 
            this.task4.AutoSize = true;
            this.task4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.task4.Location = new System.Drawing.Point(237, 89);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(0, 13);
            this.task4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALT - Numpad 1";
            this.label1.Click += new System.EventHandler(this.test_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(146, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALT - Numpad 2";
            this.label2.Click += new System.EventHandler(this.test_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(146, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALT - Numpad 3";
            this.label3.Click += new System.EventHandler(this.test_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(146, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ALT - Numpad 4";
            this.label4.Click += new System.EventHandler(this.test_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(146, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ALT - Numpad 5";
            this.label5.Click += new System.EventHandler(this.test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 135);
            this.Controls.Add(this.task5);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotsamo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label task1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label task2;
        private System.Windows.Forms.Label task3;
        private System.Windows.Forms.Label task5;
        private System.Windows.Forms.Label task4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}

