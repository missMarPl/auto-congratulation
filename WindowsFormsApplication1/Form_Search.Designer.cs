namespace WindowsFormsApplication1
{
    partial class Form_Search
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
            this.search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_FIO_textBox = new System.Windows.Forms.TextBox();
            this.search_age_textBox = new System.Windows.Forms.TextBox();
            this.search_job_textBox = new System.Windows.Forms.TextBox();
            this.search_sex_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(91, 163);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(193, 52);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "Искать";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отдел";
            // 
            // search_FIO_textBox
            // 
            this.search_FIO_textBox.Location = new System.Drawing.Point(91, 30);
            this.search_FIO_textBox.Name = "search_FIO_textBox";
            this.search_FIO_textBox.Size = new System.Drawing.Size(193, 20);
            this.search_FIO_textBox.TabIndex = 4;
            // 
            // search_age_textBox
            // 
            this.search_age_textBox.Location = new System.Drawing.Point(91, 61);
            this.search_age_textBox.Name = "search_age_textBox";
            this.search_age_textBox.Size = new System.Drawing.Size(193, 20);
            this.search_age_textBox.TabIndex = 5;
            // 
            // search_job_textBox
            // 
            this.search_job_textBox.Location = new System.Drawing.Point(91, 91);
            this.search_job_textBox.Name = "search_job_textBox";
            this.search_job_textBox.Size = new System.Drawing.Size(193, 20);
            this.search_job_textBox.TabIndex = 6;
            // 
            // search_sex_textBox
            // 
            this.search_sex_textBox.Location = new System.Drawing.Point(91, 122);
            this.search_sex_textBox.Name = "search_sex_textBox";
            this.search_sex_textBox.Size = new System.Drawing.Size(193, 20);
            this.search_sex_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пол";
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 227);
            this.Controls.Add(this.search_sex_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search_job_textBox);
            this.Controls.Add(this.search_age_textBox);
            this.Controls.Add(this.search_FIO_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_button);
            this.Name = "Form_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_FIO_textBox;
        private System.Windows.Forms.TextBox search_age_textBox;
        private System.Windows.Forms.TextBox search_job_textBox;
        private System.Windows.Forms.TextBox search_sex_textBox;
        private System.Windows.Forms.Label label4;
    }
}