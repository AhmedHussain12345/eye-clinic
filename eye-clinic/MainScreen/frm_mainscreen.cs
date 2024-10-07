using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eye_clinic.MainScreen
{
    public partial class frm_mainscreen : Form
    {
        public frm_mainscreen()
        {
            InitializeComponent();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Doctors.frm_doctors form = new Doctors.frm_doctors();
            form.Show();
        }

        private void btn_opd_Click(object sender, EventArgs e)
        {
            Opd.frm_opd form = new Opd.frm_opd();
            form.Show();
        }

        private void btn_surgery_Click(object sender, EventArgs e)
        {
            Surgery.frm_surgery form = new Surgery.frm_surgery();
            form.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reports.frm_reports form = new Reports.frm_reports();
            form.Show();
        }
    }
}
