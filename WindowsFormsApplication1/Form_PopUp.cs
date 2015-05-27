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
    public partial class Form_PopUp : Form
    {
        public Form_PopUp()
        {
            InitializeComponent();
            date_label.Text = DateTime.Now.ToString("dd MMMM yyyy");;
        }

        private void Form_PopUp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height);
        }

        private void openMain_button_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Main form = new Form_Main();
            //form.Location = new Point(200, 300);
            form.Show();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }


        public void clozeApp()
        {
            Close();
        }
    }
}
