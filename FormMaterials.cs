using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Factory
{

    public partial class FormMaterials : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        bool update = false;
        public FormMaterials(bool admin)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            if (admin == true)
            {
                button_admin.Visible = true;
            }
            
        }
        private void CreateColumns()
        {
            dgv_materials.Columns.Add("material_name", "Название");
            dgv_materials.Columns.Add("material_count", "Количество");
            dgv_materials.Columns.Add("material_options", "Дополнительно");
            dgv_materials.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv_materials_order.Columns.Add("material_order_id", "id");
            dgv_materials_order.Columns.Add("material_order_name", "Название");
            dgv_materials_order.Columns.Add("material_order_count", "Количество");
            dgv_materials_order.Columns.Add("material_order_creation_date", "Дата создания");
            dgv_materials_order.Columns.Add("material_order_receive_date", "Дата прибытия");
            dgv_materials_order.Columns.Add("material_order_options", "Дополнительно");
            dgv_materials_order.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_materials_order.Columns.Add("material_order_receive", "Получено");
        }


        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            if (dgv == dgv_materials_order)
            {
                try
                {
                    dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetFloat(2), record.GetDateTime(3), record.GetDateTime(4), record.GetString(5), record.GetBoolean(6));
                }
                catch (Exception)
                {
                    dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetFloat(2), record.GetDateTime(3), record.GetDateTime(4), "", record.GetBoolean(6));
                }
            }
            else
            {
                try
                {
                    dgv.Rows.Add(record.GetString(0), record.GetFloat(1), record.GetString(2));
                }
                catch (Exception)
                {
                    dgv.Rows.Add(record.GetString(0), record.GetFloat(1), "");
                }
            }
            
        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = "";

            if (dgv == dgv_materials_order)
            {
                queryString = $"SELECT * FROM table_material_order";
            }
            else
            {
                queryString = $"SELECT * FROM table_material_available";
            }

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
            formAdmin.Closed += (s, args) => this.Close();
            this.Hide();
            formAdmin.Show();
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_materials);
            RefreshDgv(dgv_materials_order);
            
        }

        private void dgv_materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_materials.Rows[selectedRow];

                textBox_name.Text = row.Cells[0].Value.ToString();
                textBox_count.Text = row.Cells[1].Value.ToString();
                textBox_options.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgv_materials_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_materials_order.Rows[selectedRow];
                textBox_name_order.Text = row.Cells[1].Value.ToString();
                textBox_count_order.Text = row.Cells[2].Value.ToString();
                dateTimePicker_creation.Text = row.Cells[3].Value.ToString();
                dateTimePicker_receive.Text = row.Cells[4].Value.ToString();
                textBox_options_order.Text = row.Cells[5].Value.ToString();
                checkBox_receive.Checked = Convert.ToBoolean(row.Cells[6].Value);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_count.Text = "";
            textBox_options.Text = "";
            groupBox_data.Enabled = true;
        }

        private void button_add_order_Click(object sender, EventArgs e)
        {
            textBox_name_order.Text = "";
            textBox_count_order.Text = "";
            dateTimePicker_creation.Text = "";
            dateTimePicker_receive.Text = "";
            textBox_options_order.Text = "";
            checkBox_receive.Text = "";
            groupBox_data_order.Enabled = true;
        }

        private void Save(DataGridView dgv)
        {
            var addQuery = "";
            if (dgv == dgv_materials)
            {
                addQuery = $"INSERT INTO table_material_available(material_name, material_count, material_options) VALUES" +
                $"('{textBox_name.Text}', '{textBox_count.Text}', '{textBox_options.Text}')";  
            }
            else
            {
                if (update)
                {
                    int id = Convert.ToInt32(dgv.Rows[selectedRow].Cells[0].Value);
                    addQuery = $"UPDATE table_material_order SET material_order_name = '{textBox_name_order.Text}', material_order_count = '{textBox_count_order.Text}', material_order_creation_date = '{dateTimePicker_creation.Value.ToString("yyyy-MM-dd")}', " +
                        $"material_order_receive_date = '{dateTimePicker_receive.Value.ToString("yyyy-MM-dd")}', material_order_options = '{textBox_options_order.Text}', material_order_receive = '{checkBox_receive.Checked}' WHERE material_order_id = {id}";
                }
                else
                {
                    addQuery = $"INSERT INTO table_material_order(material_order_name, material_order_count, material_order_creation_date, material_order_receive_date, material_order_options, material_order_receive) VALUES" +
                $"('{textBox_name_order.Text}', '{textBox_count_order.Text}', '{dateTimePicker_creation.Value.ToString("yyyy-MM-dd")}', '{dateTimePicker_receive.Value.ToString("yyyy-MM-dd")}', '{textBox_options_order.Text}', '{checkBox_receive.Checked}')";
                }
            }
            var command = new SqlCommand(addQuery, database.GetConnection());
            database.openConnection();
            command.ExecuteNonQuery();

            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Вы пытаетесь добавить уже существующую запись.\nПожалуйста, измените запись.\nЕсли вы уверены, что добавляете новую запись - обратитесь к системному администратору за помощью", "Внимание!");
            }
            database.closeConnection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var comma = textBox_count.Text.IndexOf(",");
            if (comma >= 0)
            {
                MessageBox.Show("Пожалуйста, поставьте точку вместо запятой в поле \"Количество\"");
            }
            else
            {
                Save(dgv_materials);
                RefreshDgv(dgv_materials);
            }
            groupBox_data.Enabled = false;
        }

        private void button_save_order_Click(object sender, EventArgs e)
        {
            var comma = textBox_count_order.Text.IndexOf(",");
            if (comma >= 0)
            {
                MessageBox.Show("Пожалуйста, поставьте точку вместо запятой в поле \"Количество\"");
            }
            else
            {
                Save(dgv_materials_order);
                RefreshDgv(dgv_materials_order);
                groupBox_data_order.Enabled = false;
                update = false;
            }
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = "";
            if (dgv == dgv_materials) 
            {
                searchString = $"SELECT * FROM table_material_order where concat(material_order_name, material_order_count, material_order_creation_date, material_order_receive_date, material_order_options) like '%{textBox_search_order.Text}%'";
            }
            else
            {
                searchString = $"SELECT * FROM table_material_available where concat(material_name, material_count, material_options) like '%{textBox_search.Text}%'";
            }

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
            Search(dgv_materials);
        }

        private void button_search_order_Click(object sender, EventArgs e)
        {
            Search(dgv_materials_order);
        }

        private void Delete(DataGridView dgv)
        {
            database.openConnection();
            int index = selectedRow;
            var name = "";
            int id = 0;
            if (dgv == dgv_materials_order)
            {
                id = Convert.ToInt32(dgv.Rows[index].Cells[0].Value);
            }
            else
            {
                name = dgv.Rows[index].Cells[0].Value.ToString();
            }

            var deleteQuery = $"DELETE FROM table_material_available where material_name = '{name}'";
            if (dgv == dgv_materials_order)
            {
                deleteQuery = $"DELETE FROM table_material_order where material_order_id = '{id}'";
            }
            var command = new SqlCommand(deleteQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();

        }

        private void AskDelete(DataGridView dgv)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите безвозвратно удалить эту запись?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Delete(dgv);
                RefreshDgv(dgv);
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            AskDelete(dgv_materials);     
        }

        private void button_delete_order_Click(object sender, EventArgs e)
        {
            AskDelete(dgv_materials_order);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            Delete(dgv_materials);
        }

        private void button_edit_order_Click(object sender, EventArgs e)
        {
            groupBox_data_order.Enabled = true;
            update = true;
            Save(dgv_materials_order);
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_count_order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_materials_need_Click(object sender, EventArgs e)
        {
            FormMaterialsNeed formMaterialsNeed = new FormMaterialsNeed();
            formMaterialsNeed.Show();
        }
    }
}
