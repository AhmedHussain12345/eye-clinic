﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eye_clinic.Reports
{
    public partial class frm_reports : Form
    {
        public frm_reports()
        {
            InitializeComponent();
        }

        private void btn_addreports_Click(object sender, EventArgs e)
        {
            Reports.frm_addreports form = new Reports.frm_addreports();
            form.Show();
        }
    }
}
