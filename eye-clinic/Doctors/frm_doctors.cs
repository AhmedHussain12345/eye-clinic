using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace eye_clinic.Doctors
{
    public partial class frm_doctors : Form
    {
        public static List<Doctor> Doctors = new List<Doctor>();
        public frm_doctors()
        {
            InitializeComponent();
           
        }

        private void tbl_doctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_doctors_Load(object sender, EventArgs e)
        {

        }

        private void frm_doctors_SizeChanged(object sender, EventArgs e)
        {
            
            //tbl_doctors.Size = new Size { Height =this.Size.Height - 40,Width = this.Size.Width - 80};
            //tbl_doctors.Refresh();
        }

        private void btn_adddoctor_Click(object sender, EventArgs e)
        {
            Doctors.frm_adddoctors form = new Doctors.frm_adddoctors();
            form.ShowDialog();
            tbl_surgery.DataSource = null;
            tbl_surgery.DataSource = Doctors;
        }
    }
}
