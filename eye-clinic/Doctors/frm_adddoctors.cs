using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eye_clinic.Doctors
{
    public partial class frm_adddoctors : Form
    {
        public frm_adddoctors()
        {
            InitializeComponent();
        }

        private void btn_docsubmit_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor();
            doctor.Name = textBox_name.Text;
            doctor.Age = Convert.ToInt32(textBox_age.Text);
            doctor.Specialization = textBox_specialization.Text;
            doctor.Message = richTextBox_msg.Text;
            doctor.Address = richTextBox_address.Text;
            doctor.Phone = textBox_phone.Text;
            if (ValidateData(doctor))
            {
                frm_doctors.Doctors.Add(doctor);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please provide valid data");
            }            
        }

        private bool ValidateData(Doctor doctor)
        {
            if (string.IsNullOrEmpty(doctor.Name))
            {
                return false;
            }

            if (string.IsNullOrEmpty(doctor.Phone))
            {
                return false;
            }

            return true;
        }

        private void frm_adddoctors_Load(object sender, EventArgs e)
        {

        }
    }
}
