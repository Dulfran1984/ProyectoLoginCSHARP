﻿using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void btn_Cerarr_Click(object sender, EventArgs e)
        {
            Visible = false;
            frm_Login obj_Login = new frm_Login();
            obj_Login.Visible = true;
        }
    }
}