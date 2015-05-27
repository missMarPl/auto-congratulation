﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Err_Dial : Form
    {
        public Err_Dial(Exception e)
        {
            InitializeComponent();
            label_err.Text = e.Message;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
