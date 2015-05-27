using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form_Search : Form
    {

        public int f = 0;
        public string inf1, inf2, inf3, inf4;


        public Form_Search()
        {
            InitializeComponent();           
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Form_Main main = this.Owner as Form_Main;

            main.minf1 = search_FIO_textBox.Text;
            main.minf2 = search_age_textBox.Text;
            main.minf3 = search_job_textBox.Text;
            main.minf4 = search_sex_textBox.Text;

            Close();
       }
    }
}
