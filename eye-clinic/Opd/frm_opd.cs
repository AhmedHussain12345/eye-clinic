﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eye_clinic.Opd
{
    public partial class frm_opd : Form
    {
        public frm_opd()
        {
            InitializeComponent();
        }

        private void btn_addopd_Click(object sender, EventArgs e)
        {
            Opd.frm_addopd form = new Opd.frm_addopd();
            form.Show();
        }
    }
}
