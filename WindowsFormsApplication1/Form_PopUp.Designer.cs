namespace WindowsFormsApplication1
{
    partial class Form_PopUp
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
            this.date_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.popUp_todaysholiday_label = new System.Windows.Forms.Label();
            this.born_today = new System.Windows.Forms.Label();
            this.popUp_borntoday_list = new System.Windows.Forms.ListBox();
            this.popUp_sendToEveryone_button = new System.Windows.Forms.Button();
            this.popUp_openMain_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(12, 9);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(35, 13);
            this.date_label.TabIndex = 0;
            this.date_label.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сегодня";
            // 
            // popUp_todaysholiday_label
            // 
            this.popUp_todaysholiday_label.AutoSize = true;
            this.popUp_todaysholiday_label.Location = new System.Drawing.Point(75, 31);
            this.popUp_todaysholiday_label.Name = "popUp_todaysholiday_label";
            this.popUp_todaysholiday_label.Size = new System.Drawing.Size(0, 13);
            this.popUp_todaysholiday_label.TabIndex = 2;
            // 
            // born_today
            // 
            this.born_today.AutoSize = true;
            this.born_today.Location = new System.Drawing.Point(12, 55);
            this.born_today.Name = "born_today";
            this.born_today.Size = new System.Drawing.Size(72, 13);
            this.born_today.TabIndex = 3;
            this.born_today.Text = "именинники:";
            // 
            // popUp_borntoday_list
            // 
            this.popUp_borntoday_list.FormattingEnabled = true;
            this.popUp_borntoday_list.Location = new System.Drawing.Point(15, 76);
            this.popUp_borntoday_list.Name = "popUp_borntoday_list";
            this.popUp_borntoday_list.ScrollAlwaysVisible = true;
            this.popUp_borntoday_list.Size = new System.Drawing.Size(276, 95);
            this.popUp_borntoday_list.TabIndex = 4;
            // 
            // popUp_sendToEveryone_button
            // 
            this.popUp_sendToEveryone_button.Location = new System.Drawing.Point(15, 177);
            this.popUp_sendToEveryone_button.Name = "popUp_sendToEveryone_button";
            this.popUp_sendToEveryone_button.Size = new System.Drawing.Size(117, 27);
            this.popUp_sendToEveryone_button.TabIndex = 5;
            this.popUp_sendToEveryone_button.Text = "Поздравить всех";
            this.popUp_sendToEveryone_button.UseVisualStyleBackColor = true;
            this.popUp_sendToEveryone_button.Click += new System.EventHandler(this.popUp_sendToEveryone_button_Click);
            // 
            // popUp_openMain_button
            // 
            this.popUp_openMain_button.Location = new System.Drawing.Point(138, 177);
            this.popUp_openMain_button.Name = "popUp_openMain_button";
            this.popUp_openMain_button.Size = new System.Drawing.Size(153, 27);
            this.popUp_openMain_button.TabIndex = 6;
            this.popUp_openMain_button.Text = "Настроить поздравления";
            this.popUp_openMain_button.UseVisualStyleBackColor = true;
            this.popUp_openMain_button.Click += new System.EventHandler(this.openMain_button_Click);
            // 
            // Form_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(308, 235);
            this.Controls.Add(this.popUp_openMain_button);
            this.Controls.Add(this.popUp_sendToEveryone_button);
            this.Controls.Add(this.popUp_borntoday_list);
            this.Controls.Add(this.born_today);
            this.Controls.Add(this.popUp_todaysholiday_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(965, 720);
            this.Name = "Form_PopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Поздравлятор";
            this.Load += new System.EventHandler(this.Form_PopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label popUp_todaysholiday_label;
        private System.Windows.Forms.Label born_today;
        private System.Windows.Forms.ListBox popUp_borntoday_list;
        private System.Windows.Forms.Button popUp_sendToEveryone_button;
        private System.Windows.Forms.Button popUp_openMain_button;
    }
}