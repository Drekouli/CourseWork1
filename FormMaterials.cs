using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{

    public partial class FormMaterials : Form
    {
        DataBase database = new DataBase();

        int selectedRow;

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
        }


        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
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

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"SELECT * FROM table_material_available";

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
            formAdmin.ShowDialog();
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_materials);
        }

        private void dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_count.Text = "";
            textBox_options.Text = "";
            groupBox_data.Enabled = true;
        }

        private void Add()
        {
            groupBox_data.Enabled = false;
            
            var addQuery = $"INSERT INTO table_material_available(material_name, material_count, material_options) VALUES" +
                $"('{textBox_name.Text}', '{textBox_count.Text}', '{textBox_options.Text}')";
            //try 
            {
                var command = new SqlCommand(addQuery, database.GetConnection());
                database.openConnection();
                command.ExecuteNonQuery();
            }
            //catch (Exception) 
            {
            //    MessageBox.Show("Вы пытаетесь добавить уже существующую запись.\nПожалуйста, измените запись.\nЕсли вы уверены, что добавляете новую запись - обратитесь к системному администратору за помощью", "Внимание!");
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
                Add();
                RefreshDgv(dgv_materials);
            } 
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchString = $"SELECT * FROM table_material_available where concat(material_name, material_count, material_options) like '%{textBox_search.Text}%'";

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

        private void Delete()
        {
            database.openConnection();
            int index = selectedRow;
            var name = dgv_materials.Rows[index].Cells[0].Value;

            var deleteQuery = $"DELETE FROM table_material_available where material_name = '{name}'";

            var command = new SqlCommand(deleteQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите безвозвратно удалить эту запись?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Delete();
                RefreshDgv(dgv_materials);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }   
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            Delete();
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
