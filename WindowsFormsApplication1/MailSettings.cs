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
    public partial class MailSettings : Form
    {
        public MailSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] lines = { textSmtp.Text, textPort.Text, textFrom.Text, textPass.Text };
            System.IO.File.WriteAllLines(@"mailset.txt", lines);
            Close();
        }

    }
}
