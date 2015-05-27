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
    public partial class Form_List : Form
    {
        public Form_List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Search form = new Form_Search();
            //form.Location = new Point(200, 300);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Change form = new Form_Change();
            //form.Location = new Point(200, 300);
            form.Show();
        }
    }
}
