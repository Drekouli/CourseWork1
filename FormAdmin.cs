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
            this.Hide();
            formStaff.ShowDialog();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void button_accounts_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            this.Hide();
            formRegistration.ShowDialog();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(true);
            this.Hide();
            formMaterials.ShowDialog();
        }
    }
}
