using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Factory
{

    public partial class FormStaff : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        bool update = false;

        public FormStaff(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            if (admin) 
            { 
                button_admin.Visible = true; 
            }
        }

        private void CreateColumns()
        {
            dgv_staff.Columns.Add("staff_id", "id");
            dgv_staff.Columns.Add("staff_lastname", "Фамилия");
            dgv_staff.Columns.Add("staff_firstname", "Имя");
            dgv_staff.Columns.Add("staff_middlename", "Отчество");
            dgv_staff.Columns.Add("staff_post", "Должность");
            dgv_staff.Columns.Add("staff_salary", "Зарплата");
            dgv_staff.Columns.Add("staff_emloyed", "Дата принятия");
            dgv_staff.Columns.Add("staff_dismissed", "Дата увольнения");
            dgv_staff.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            try
            {
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                record.GetString(4), record.GetInt32(5), record.GetDateTime(6), record.GetDateTime(7));
            }
            catch (Exception)
            {
                dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                record.GetString(4), record.GetInt32(5), record.GetDateTime(6), "");
            }           
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_staff";

            SqlCommand sqlCommand = new SqlCommand(queryString, database.GetConnection ());
            
            database.openConnection();

            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read()) 
            { 
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }
        private void button_admin_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Closed += (s, args) => this.Close();
            this.Hide();
            formAdmin.Show();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_staff);
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dgv_staff.Rows[selectedRow];

                textBox_fio.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[3].Value.ToString();
                textBox_post.Text = row.Cells[4].Value.ToString();
                textBox_salary.Text = row.Cells[5].Value.ToString();
                date_employ.Text = row.Cells[6].Value.ToString();
                if (row.Cells[7].Value.ToString() != "")
                {
                    checkBox_eye.Checked = true;
                    date_dismis.Text = row.Cells[7].Value.ToString();
                }
                else
                {
                    checkBox_eye.Checked= false;
                }
            }
        }

        private void checkBox_eye_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_eye.Checked) 
            {
                checkBox_eye.Image = Properties.Resources.eye_open;
                textBox1.Visible = false;    
            }
            else
            {
                checkBox_eye.Image = Properties.Resources.eye_close;
                textBox1.Visible = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_fio.Text = "";
            textBox_post.Text = 
            textBox_salary.Text = "";
            date_employ.Text = "";
            checkBox_eye.Checked = false;
            date_dismis.Text = "";
            groupBox_data.Enabled = true;
        }
        private void Update()
        {
            int id = Convert.ToInt32(dgv_staff.Rows[selectedRow].Cells[0].Value);
            string[] fio = textBox_fio.Text.Split(' ');
            string addQuery = "";
            if (checkBox_eye.Checked)
            {
                addQuery = $"UPDATE table_staff SET staff_lastname = '{fio[0]}', staff_firstname = '{fio[1]}', staff_middlename = '{fio[2]}', staff_post = '{textBox_post.Text}', " +
                $"staff_salary = '{textBox_salary.Text}', staff_employed = '{date_employ.Value.ToString("yyyy-MM-dd")}', staff_dismissed = '{date_dismis.Value.ToString("yyyy-MM-dd")}' WHERE staff_id = {id}";
            }
            else
            {
                addQuery = $"UPDATE table_staff SET staff_lastname = '{fio[0]}', staff_firstname = '{fio[1]}', staff_middlename = '{fio[2]}', staff_post = '{textBox_post.Text}', " +
                $"staff_salary = '{textBox_salary.Text}', staff_employed = '{date_employ.Value.ToString("yyyy-MM-dd")}' WHERE staff_id = {id}";
            }

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            database.closeConnection();
        }

        private void Add()
        {
            groupBox_data.Enabled = false;
            string[] fio = textBox_fio.Text.Split(' ');
            var post = textBox_post.Text;
            var salary = textBox_salary.Text;
            string employ = date_employ.Value.ToString("yyyy-MM-dd");
            string dismis = date_dismis.Value.ToString("yyyy-MM-dd");
            string addQuery = "";

            if (checkBox_eye.Checked)
            {
                addQuery = $"INSERT INTO table_staff(staff_lastname, staff_firstname, staff_middlename, staff_post, staff_salary, staff_employed, staff_dismissed) VALUES" +
                $"('{fio[0]}', '{fio[1]}', '{fio[2]}', '{textBox_post.Text}', '{textBox_salary.Text}', '{date_employ.Value.ToString("yyyy-MM-dd")}', '{date_dismis.Value.ToString("yyyy-MM-dd")}')";
            }
            else
            {
                addQuery = $"INSERT INTO table_staff(staff_lastname, staff_firstname, staff_middlename, staff_post, staff_salary, staff_employed) VALUES" +
                $"('{fio[0]}', '{fio[1]}', '{fio[2]}', '{textBox_post.Text}', '{textBox_salary.Text}', '{date_employ.Value.ToString("yyyy-MM-dd")}')";
            }
            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            /*
            try
            {
                var command = new SqlCommand(addQuery, database.GetConnection());
                database.openConnection();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы пытаетесь добавить уже существующую запись.\nПожалуйста, измените запись.\nЕсли вы уверены, что добавляете новую запись - обратитесь к системному администратору за помощью", "Внимание!");
            }
            */
            database.closeConnection();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (update)
            {
                Update();
            }
            else
            {
                Add();
            }
            RefreshDgv(dgv_staff);
            update = false;
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM table_staff where concat(staff_id, staff_lastname, staff_firstname, staff_middlename, staff_post, staff_salary, staff_employed, staff_dismissed) like '%{textBox_search.Text}%'";
            
            SqlCommand com = new SqlCommand(searchString, database.GetConnection());

            database.openConnection();

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read()) 
            { 
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

        }
        private void button_search_Click(object sender, EventArgs e)
        {
            Search(dgv_staff);
        }

        private void Delete()
        {
            database.openConnection();
            int index = selectedRow;
            var id = Convert.ToInt32(dgv_staff.Rows[index].Cells[0].Value);

            var deleteQuery = $"DELETE FROM table_staff where staff_id = {id}";

            var command = new SqlCommand(deleteQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete();
            RefreshDgv(dgv_staff);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            update = true;
        }

        private void textBox_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
