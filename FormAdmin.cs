using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты куда нажал?");
        }

        private void groupBox_registration_Enter(object sender, EventArgs e)
        {

        }

        private void button_staff_Click(object sender, EventArgs e)
        {
            FormStaff formStaff = new FormStaff(true);
            formStaff.Closed += (s, args) => this.Close();
            this.Hide();
            formStaff.Show();
        }

        private void button_accounts_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Closed += (s, args) => this.Close();
            this.Hide();
            formRegistration.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(true);
            formMaterials.Closed += (s, args) => this.Close();
            this.Hide();
            formMaterials.Show();
        }
    }
}
