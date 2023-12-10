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

    public partial class FormEquipment : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        bool update = false;

        public FormEquipment(bool admin)
        {
            InitializeComponent();
            if (admin)
            {
                button_admin.Visible = true;
            }
            else
            {
                button_furniture.Visible = true;
            }
        }


        private void button_staff_Click(object sender, EventArgs e)
        {
            FormStaff formStaff = new FormStaff(2);
            formStaff.Closed += (s, args) => this.Close();
            this.Hide();
            formStaff.Show();
        }


        private void CreateColumns()
        {
            dgv_equipment.Columns.Add("equipment_name", "Код");
            dgv_equipment.Columns.Add("equipment_gained_date", "Дата получения");
            dgv_equipment.Columns.Add("equipment_staff_assign_id", "id владельца");
            dgv_equipment.Columns.Add("equipment_options", "Описание");
            dgv_equipment.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            try
            {
                dgv.Rows.Add(record.GetString(0), record.GetDateTime(1), record.GetInt32(2), record.GetString(3));
            }
            catch (Exception)
            {
                dgv.Rows.Add(record.GetString(0), record.GetDateTime(1), record.GetInt32(2), "");
            }
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_equipment";

            SqlCommand sqlCommand = new SqlCommand(queryString, database.GetConnection());

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
            this.Hide();
            formAdmin.Show();
        }

        private void FormEquipment_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_equipment);
        }

        private void dgv_equipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_equipment.Rows[selectedRow];

                textBox_name.Text = row.Cells[0].Value.ToString();
                date_receive.Text = row.Cells[1].Value.ToString();
                textBox_staff_id.Text = row.Cells[2].Value.ToString();
                textBox_options.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            date_receive.Text = "";
            textBox_staff_id.Text = "";
            textBox_options.Text = "";
            groupBox_data.Enabled = true;
        }

        private void Update()
        {
            groupBox_data.Enabled = false;
            string name = dgv_equipment.Rows[selectedRow].Cells[0].Value.ToString();
            string addQuery = $"UPDATE table_equipment SET equipment_gained_date = '{date_receive.Text}', equipment_staff_assign_id = '{textBox_staff_id.Text}', equipment_options = '{textBox_options.Text}' WHERE equipment_name = '{name}'";

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            database.closeConnection();
        }

        private void Add()
        {
            groupBox_data.Enabled = false;
            string addQuery = $"INSERT INTO table_equipment(equipment_name, equipment_gained_date, equipment_staff_assign_id, equipment_options) VALUES" +
            $"('{textBox_name.Text}', '{date_receive.Text}', '{textBox_staff_id.Text}', '{textBox_options.Text}')";

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                MessageBox.Show("Введён id несуществующего сотрудника");
            }   
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
            RefreshDgv(dgv_equipment);
            update = false;
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM table_equipment where concat(equipment_name, equipment_gained_date, equipment_staff_assign_id, equipment_options) like '%{textBox_search.Text}%'";

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
            Search(dgv_equipment);
        }

        private void Delete()
        {
            database.openConnection();
            string name = dgv_equipment.Rows[selectedRow].Cells[0].Value.ToString();

            var deleteQuery = $"DELETE FROM table_equipment where equipment_name = '{name}'";

            var command = new SqlCommand(deleteQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete();
            RefreshDgv(dgv_equipment);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            update = true;
        }

        private void textBox_staff_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_furniture_Click(object sender, EventArgs e)
        {
            FormFurniture formFurniture = new FormFurniture(false);
            this.Hide();
            formFurniture.Show();
        }
    }
}
