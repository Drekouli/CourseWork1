using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class FormLogin : Form
    {
        DataBase database = new DataBase();

        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_Login.Text;
            var PasswordUser = textBox_Password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"Select authorization_access, authorization_login, authorization_password " +
                $"from table_authorization where authorization_login = '{loginUser}' and authorization_password = '{PasswordUser}'";

            SqlCommand com = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = com;
            adapter.Fill(table);
            
            try
            {
                if ((table.Rows[0]["authorization_access"].ToString() == "Программист")
                    | (table.Rows[0]["authorization_access"].ToString() == "Директор")
                    | (table.Rows[0]["authorization_access"].ToString() == "Системный администратор"))
                {
                    textBox_Login.Text = "";
                    textBox_Password.Text = "";
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Closed += (s, args) => this.Close();
                    this.Hide();
                    formAdmin.Show();
                }

                else if (table.Rows[0]["authorization_access"].ToString() == "Бухгалтер")
                {
                    textBox_Login.Text = "";
                    textBox_Password.Text = "";
                    FormStaff formStaff = new FormStaff(0);
                    formStaff.Closed += (s, args) => this.Close();
                    this.Hide();
                    formStaff.Show();
                }

                else if (table.Rows[0]["authorization_access"].ToString() == "Кладовщик")
                {
                    textBox_Login.Text = "";
                    textBox_Password.Text = "";
                    FormMaterials formMaterials = new FormMaterials(false);
                    formMaterials.Closed += (s, args) => this.Close();
                    this.Hide();
                    formMaterials.Show();
                
                }

                else if (table.Rows[0]["authorization_access"].ToString() == "Мастер")
                {
                    textBox_Login.Text = "";
                    textBox_Password.Text = "";
                    FormFurniture formFurniture = new FormFurniture(false);
                    formFurniture.Closed += (s, args) => this.Close();
                    this.Hide();
                    formFurniture.Show();
                }
            }
            catch
            {
                MessageBox.Show("Такого аккаунта не существует");
            }
            database.closeConnection();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = '*';
            textBox_Login.MaxLength = 20;
            textBox_Password.MaxLength = 20;
        }
    }
}
