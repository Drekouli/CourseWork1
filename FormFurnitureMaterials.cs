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
    public partial class FormFurnitureMaterials : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        bool update = false;

        public FormFurnitureMaterials(bool admin)
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

        private void button_furniture_Click(object sender, EventArgs e)
        {
            FormFurniture formFurniture = new FormFurniture(false);
            formFurniture.Closed += (s, args) => this.Close();
            this.Hide();
            formFurniture.Show();
        }


        private void CreateColumns()
        {
            dgv_furniture_materials.Columns.Add("furniture_name", "Название");
            dgv_furniture_materials.Columns.Add("materials_names", "Имена материалов");
            dgv_furniture_materials.Columns.Add("materials_count", "Количество материалов");
            dgv_furniture_materials.Columns.Add("furniture_description", "Описание");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
                dgv.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_furniture_materials";

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

        private void FormFurnitureMaterials_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_furniture_materials);
        }

        private void dgv_equipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_furniture_materials.Rows[selectedRow];

                textBox_furniture_name.Text = row.Cells[0].Value.ToString();
                textBox_materials_names.Text = row.Cells[1].Value.ToString();
                textBox_materials_count.Text = row.Cells[2].Value.ToString();
                textBox_options.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_furniture_name.Text = "";
            textBox_materials_names.Text = "";
            textBox_materials_count.Text = "";
            textBox_options.Text = "";
            groupBox_data.Enabled = true;
        }

        private void Update()
        {
            groupBox_data.Enabled = false;
            textBox_furniture_name.Enabled = true;
            string name = dgv_furniture_materials.Rows[selectedRow].Cells[0].Value.ToString();
            string addQuery = $"UPDATE table_furniture_materials SET materials_names = '{textBox_materials_names.Text}', materials_count = '{textBox_materials_count.Text}', furniture_description = '{textBox_options.Text}' WHERE furniture_name = '{name}'";

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();
            database.closeConnection();
        }

        private void Add()
        {
            groupBox_data.Enabled = false;
            string addQuery = $"INSERT INTO table_furniture_materials(furniture_name, materials_names, materials_count, furniture_description) VALUES" +
            $"('{textBox_furniture_name.Text}', '{textBox_materials_names.Text}', '{textBox_materials_count.Text}', '{textBox_options.Text}')";

            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            
            command.ExecuteNonQuery();
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
            RefreshDgv(dgv_furniture_materials);
            update = false;
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM table_furniture_materials where concat(furniture_name, materials_names, materials_count, furniture_description) like '%{textBox_search.Text}%'";

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
            Search(dgv_furniture_materials);
        }

        private void Delete()
        {
            database.openConnection();
            string name = dgv_furniture_materials.Rows[selectedRow].Cells[0].Value.ToString();

            var deleteQuery = $"DELETE FROM table_furniture_materials where furniture_name = '{name}'";

            var command = new SqlCommand(deleteQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete();
            RefreshDgv(dgv_furniture_materials);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            textBox_furniture_name.Enabled = false;
            groupBox_data.Enabled = true;
            update = true;
        }

        private void textBox_materials_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
