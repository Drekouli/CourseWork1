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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Factory
{
    public partial class FormRegistration : Form
    {

        DataBase database = new DataBase();

        int selectedRow;

        public FormRegistration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dgv_auth.Columns.Add("authorization_login", "Логин");
            dgv_auth.Columns.Add("authorization_password", "Пароль");
            dgv_auth.Columns.Add("authorization_access", "Права доступа");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
                dgv.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2));
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_authorization";

            SqlCommand sqlCommand = new SqlCommand(queryString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
            database.closeConnection();
        }

        private void button_admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            this.Hide();
            formAdmin.ShowDialog();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_auth);
        }

        private void dgv_auth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_auth.Rows[selectedRow];

                textBox_login.Text = row.Cells[0].Value.ToString();
                textBox_password.Text = row.Cells[1].Value.ToString();
                textBox_access.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text =
            textBox_access.Text = "";
            groupBox_data.Enabled = true;
        }

        private void Add()
        {
            groupBox_data.Enabled = false;

            var addQuery = $"INSERT INTO table_authorization(authorization_login, authorization_password, authorization_access) VALUES" +
                $"('{textBox_login.Text}', '{textBox_password.Text}', '{textBox_access.Text}')"; ;

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();

            database.closeConnection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Add();
            RefreshDgv(dgv_auth);
        }

        private void Delete()
        {
            try
            {
                database.openConnection();
                string login = dgv_auth.Rows[selectedRow].Cells[0].Value.ToString();

                var deleteQuery = $"DELETE FROM table_authorization where authorization_login = '{login}'";

                var command = new SqlCommand(deleteQuery, database.GetConnection());
                command.ExecuteNonQuery();
                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete();
            RefreshDgv(dgv_auth);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            Delete();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void dgv_auth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
