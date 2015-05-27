namespace WindowsFormsApplication1
{
    partial class Form_List
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
            this.list_search_button = new System.Windows.Forms.Button();
            this.list_listBox = new System.Windows.Forms.ListBox();
            this.list_change_button = new System.Windows.Forms.Button();
            this.list_delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_search_button
            // 
            this.list_search_button.Location = new System.Drawing.Point(29, 349);
            this.list_search_button.Name = "list_search_button";
            this.list_search_button.Size = new System.Drawing.Size(233, 32);
            this.list_search_button.TabIndex = 0;
            this.list_search_button.Text = "Поиск";
            this.list_search_button.UseVisualStyleBackColor = true;
            this.list_search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_listBox
            // 
            this.list_listBox.FormattingEnabled = true;
            this.list_listBox.Location = new System.Drawing.Point(29, 31);
            this.list_listBox.Name = "list_listBox";
            this.list_listBox.ScrollAlwaysVisible = true;
            this.list_listBox.Size = new System.Drawing.Size(233, 290);
            this.list_listBox.TabIndex = 1;
            // 
            // list_change_button
            // 
            this.list_change_button.Location = new System.Drawing.Point(29, 387);
            this.list_change_button.Name = "list_change_button";
            this.list_change_button.Size = new System.Drawing.Size(233, 32);
            this.list_change_button.TabIndex = 2;
            this.list_change_button.Text = "Изменить";
            this.list_change_button.UseVisualStyleBackColor = true;
            this.list_change_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_delete_button
            // 
            this.list_delete_button.Location = new System.Drawing.Point(29, 425);
            this.list_delete_button.Name = "list_delete_button";
            this.list_delete_button.Size = new System.Drawing.Size(233, 32);
            this.list_delete_button.TabIndex = 3;
            this.list_delete_button.Text = "Удалить";
            this.list_delete_button.UseVisualStyleBackColor = true;
            this.list_delete_button.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 481);
            this.Controls.Add(this.list_delete_button);
            this.Controls.Add(this.list_change_button);
            this.Controls.Add(this.list_listBox);
            this.Controls.Add(this.list_search_button);
            this.Name = "Form_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список контактов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button list_search_button;
        private System.Windows.Forms.ListBox list_listBox;
        private System.Windows.Forms.Button list_change_button;
        private System.Windows.Forms.Button list_delete_button;
    }
}