using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
           // checkedListBox1.SetItemChecked(1, true);
           // checkedListBox1.GetItemChecked(1);
        }


        private void dropData_button_Click(object sender, EventArgs e) //сбросить
        {
            main_checkAll_button.Visible = true;
            main_dropData_button.Visible = false;
            for (int i = 0; i < main_checkedListBox.Items.Count; i++)
                main_checkedListBox.SetItemChecked(i, false);
        }

        private void checkAll_button_Click(object sender, EventArgs e) //выбрать всех
        {
            main_dropData_button.Visible = true;
            for (int i = 0; i < main_checkedListBox.Items.Count; i++)
                main_checkedListBox.SetItemChecked(i, true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Search form = new Form_Search();
            form.Location = new Point(200, 300);
            form.Show();

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add form= new Form_Add();
           // form.Location = new Point(200, 300);
            form.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_List form = new Form_List();
            form.Location = new Point(200, 300);
            form.Show();
        }

        private void рекомендованныеПодравленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PopUp form = new Form_PopUp();
            //form.Location = new Point(200, 300);
            form.Show();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form_PopUp frm = new Form_PopUp();
            //frm.clozeApp();
            Application.Exit();

        }

        private void main_exit_menuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    

        
    }
}
