﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class ConRF : Form
    {
        public ConRF()
        {
            InitializeComponent();
        }

        private void ConRF_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("http://www.constitution.ru/");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
        }
    }
}
