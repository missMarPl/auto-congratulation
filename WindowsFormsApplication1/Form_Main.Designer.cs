namespace WindowsFormsApplication1
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.main_contacts_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_congratulate_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекомендованныеПодравленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиПочтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_exit_menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.main_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.main_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.main_checkAll_button = new System.Windows.Forms.Button();
            this.main_dropData_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.main_send_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main_contacts_menuItem,
            this.main_congratulate_menuItem,
            this.main_exit_menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // main_contacts_menuItem
            // 
            this.main_contacts_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.main_contacts_menuItem.Name = "main_contacts_menuItem";
            this.main_contacts_menuItem.Size = new System.Drawing.Size(70, 20);
            this.main_contacts_menuItem.Text = "контакты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.изменитьToolStripMenuItem.Text = "изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // main_congratulate_menuItem
            // 
            this.main_congratulate_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рекомендованныеПодравленияToolStripMenuItem,
            this.настройкиПочтыToolStripMenuItem});
            this.main_congratulate_menuItem.Name = "main_congratulate_menuItem";
            this.main_congratulate_menuItem.Size = new System.Drawing.Size(54, 20);
            this.main_congratulate_menuItem.Text = "опции";
            // 
            // рекомендованныеПодравленияToolStripMenuItem
            // 
            this.рекомендованныеПодравленияToolStripMenuItem.Name = "рекомендованныеПодравленияToolStripMenuItem";
            this.рекомендованныеПодравленияToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.рекомендованныеПодравленияToolStripMenuItem.Text = "рекомендованные подравления";
            this.рекомендованныеПодравленияToolStripMenuItem.Click += new System.EventHandler(this.рекомендованныеПодравленияToolStripMenuItem_Click);
            // 
            // настройкиПочтыToolStripMenuItem
            // 
            this.настройкиПочтыToolStripMenuItem.Name = "настройкиПочтыToolStripMenuItem";
            this.настройкиПочтыToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.настройкиПочтыToolStripMenuItem.Text = "настройки почты";
            this.настройкиПочтыToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // main_exit_menuItem
            // 
            this.main_exit_menuItem.Name = "main_exit_menuItem";
            this.main_exit_menuItem.Size = new System.Drawing.Size(52, 20);
            this.main_exit_menuItem.Text = "выход";
            this.main_exit_menuItem.Click += new System.EventHandler(this.main_exit_menuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "праздник";
            // 
            // main_comboBox
            // 
            this.main_comboBox.Location = new System.Drawing.Point(34, 86);
            this.main_comboBox.Name = "main_comboBox";
            this.main_comboBox.Size = new System.Drawing.Size(324, 21);
            this.main_comboBox.TabIndex = 3;
            this.main_comboBox.SelectedIndexChanged += new System.EventHandler(this.main_comboBox_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "получатели";
            // 
            // main_checkedListBox
            // 
            this.main_checkedListBox.FormattingEnabled = true;
            this.main_checkedListBox.Location = new System.Drawing.Point(34, 184);
            this.main_checkedListBox.Name = "main_checkedListBox";
            this.main_checkedListBox.ScrollAlwaysVisible = true;
            this.main_checkedListBox.Size = new System.Drawing.Size(503, 244);
            this.main_checkedListBox.TabIndex = 5;
            // 
            // main_checkAll_button
            // 
            this.main_checkAll_button.Location = new System.Drawing.Point(581, 259);
            this.main_checkAll_button.Name = "main_checkAll_button";
            this.main_checkAll_button.Size = new System.Drawing.Size(129, 32);
            this.main_checkAll_button.TabIndex = 6;
            this.main_checkAll_button.Text = "выбрать всех";
            this.main_checkAll_button.UseVisualStyleBackColor = true;
            this.main_checkAll_button.Click += new System.EventHandler(this.checkAll_button_Click);
            // 
            // main_dropData_button
            // 
            this.main_dropData_button.Location = new System.Drawing.Point(581, 259);
            this.main_dropData_button.Name = "main_dropData_button";
            this.main_dropData_button.Size = new System.Drawing.Size(129, 32);
            this.main_dropData_button.TabIndex = 7;
            this.main_dropData_button.Text = "сбросить";
            this.main_dropData_button.UseVisualStyleBackColor = true;
            this.main_dropData_button.Visible = false;
            this.main_dropData_button.Click += new System.EventHandler(this.dropData_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(581, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // main_send_button
            // 
            this.main_send_button.Location = new System.Drawing.Point(194, 457);
            this.main_send_button.Name = "main_send_button";
            this.main_send_button.Size = new System.Drawing.Size(191, 71);
            this.main_send_button.TabIndex = 9;
            this.main_send_button.Text = "ОТПРАВИТЬ";
            this.main_send_button.UseVisualStyleBackColor = true;
            this.main_send_button.Click += new System.EventHandler(this.main_send_button_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 550);
            this.Controls.Add(this.main_dropData_button);
            this.Controls.Add(this.main_send_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.main_checkAll_button);
            this.Controls.Add(this.main_checkedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.main_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настроить поздравления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem main_contacts_menuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem main_congratulate_menuItem;
        private System.Windows.Forms.ToolStripMenuItem рекомендованныеПодравленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиПочтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem main_exit_menuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox main_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox main_checkedListBox;
        private System.Windows.Forms.Button main_checkAll_button;
        private System.Windows.Forms.Button main_dropData_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button main_send_button;
    }
}

