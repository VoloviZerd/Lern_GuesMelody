﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuesMelody
{
    public partial class fMain : Form
    {
        fSettings fs = new fSettings();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fSettings fs = new fSettings();
            fs.ShowDialog();
        }
    }
}
