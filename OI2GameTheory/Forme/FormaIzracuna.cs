﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OI2GameTheory
{
    public partial class FormaIzracuna : Form
    {
        public FormaIzracuna(string postupak)
        {
            InitializeComponent();
            txtIzracun.Text = postupak;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaIzracuna_Load(object sender, EventArgs e)
        {

        }
    }
}
