namespace WindowsFormsApplication1
{
    partial class MailSettings
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
            this.smtpSrv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSmtp = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.saveSett = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smtpSrv
            // 
            this.smtpSrv.AutoSize = true;
            this.smtpSrv.Location = new System.Drawing.Point(75, 46);
            this.smtpSrv.Name = "smtpSrv";
            this.smtpSrv.Size = new System.Drawing.Size(76, 13);
            this.smtpSrv.TabIndex = 0;
            this.smtpSrv.Text = "SMTP сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Порт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш e-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // textSmtp
            // 
            this.textSmtp.Location = new System.Drawing.Point(158, 46);
            this.textSmtp.Name = "textSmtp";
            this.textSmtp.Size = new System.Drawing.Size(167, 20);
            this.textSmtp.TabIndex = 4;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(158, 78);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(167, 20);
            this.textPort.TabIndex = 5;
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(158, 109);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(167, 20);
            this.textFrom.TabIndex = 6;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(158, 138);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(167, 20);
            this.textPass.TabIndex = 7;
            // 
            // saveSett
            // 
            this.saveSett.Location = new System.Drawing.Point(158, 182);
            this.saveSett.Name = "saveSett";
            this.saveSett.Size = new System.Drawing.Size(75, 23);
            this.saveSett.TabIndex = 8;
            this.saveSett.Text = "Сохранить";
            this.saveSett.UseVisualStyleBackColor = true;
            this.saveSett.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Адрес сервера и порт смотрите в настройках вашего e-mail провайдера";
            // 
            // MailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveSett);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textSmtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.smtpSrv);
            this.Name = "MailSettings";
            this.Text = "Настройки почтового ящика";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smtpSrv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSmtp;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button saveSett;
        private System.Windows.Forms.Label label1;
    }
}