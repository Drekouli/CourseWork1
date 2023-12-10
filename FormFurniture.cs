using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class FormFurniture : Form
    {
        DataBase database = new DataBase();

        int selectedRow;
        public FormFurniture(bool admin)
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
            dgv_furniture.Columns.Add("furniture_name", "Название");
            dgv_furniture.Columns.Add("furniture_count", "Количество");
            dgv_furniture.Columns.Add("furniture_options", "Дополнительно");
            dgv_furniture.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv_furniture_order.Columns.Add("furniture_order_id", "id");
            dgv_furniture_order.Columns.Add("furniture_order_name", "Название");
            dgv_furniture_order.Columns.Add("furniturel_order_count", "Количество");
            dgv_furniture_order.Columns.Add("furniture_order_creation_date", "Дата создания");
            dgv_furniture_order.Columns.Add("furniture_order_send_date", "Дата отбытия");
            dgv_furniture_order.Columns.Add("furniture_order_options", "Дополнительно");
            dgv_furniture_order.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgv_furniture_order.Columns.Add("furniture_order_receive", "Получено");
        }


        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            if (dgv == dgv_furniture_order)
            {
                try
                {
                    dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetDateTime(3), record.GetDateTime(4), record.GetString(5), record.GetBoolean(6));
                }
                catch (Exception)
                {
                    dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetDateTime(3), record.GetDateTime(4), "", record.GetBoolean(6));
                }
            }
            else
            {
                try
                {
                    dgv.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2));
                }
                catch (Exception)
                {
                    dgv.Rows.Add(record.GetString(0), record.GetInt32(1), "");
                }
            }

        }

        private void RefreshDgv(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = "";

            if (dgv == dgv_furniture_order)
            {
                queryString = $"SELECT * FROM table_furniture_order";
            }
            else
            {
                queryString = $"SELECT * FROM table_furniture_available";
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

        private void FormFurniture_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_furniture);
            RefreshDgv(dgv_furniture_order);
        }

        private void dgv_furniture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgv_furniture.Rows[selectedRow];

                textBox_name.Text = row.Cells[0].Value.ToString();
                textBox_count.Text = row.Cells[1].Value.ToString();
                textBox_options.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgv_furniture_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgv_furniture_order.Rows[selectedRow];
                if (Convert.ToBoolean(row.Cells[6].Value) == false)
                {
                    checkBox_sent.Enabled = true;
                    checkBox_sent.Text = "Не отправлено";
                    button_order.Enabled = true;
                }
                else if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    checkBox_sent.Enabled = false;
                    checkBox_sent.Text = "Отправлено";
                }
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_count.Text = "";
            textBox_options.Text = "";
            groupBox_data.Enabled = true;
        }


        private void Save()
        {
            var addQuery = $"INSERT INTO table_furniture_available(furniture_name, furniture_count, furniture_options) VALUES" +
            $"('{textBox_name.Text}', '{textBox_count.Text}', '{textBox_options.Text}')";
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
            database.closeConnection();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
                Save();
                RefreshDgv(dgv_furniture);
            groupBox_data.Enabled = false;
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string searchString = "";
            if (dgv == dgv_furniture_order)
            {
                searchString = $"SELECT * FROM table_furniture_order where concat(furniture_order_name, furniture_order_count, furniture_order_creation_date, furniture_order_send_date, furniture_order_options) like '%{textBox_search_order.Text}%'";
            }
            else
            {
                searchString = $"SELECT * FROM table_furniture_available where concat(furniture_name, furniture_count, furniture_options) like '%{textBox_search.Text}%'";
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
            Search(dgv_furniture);
        }

        private void button_search_order_Click(object sender, EventArgs e)
        {
            Search(dgv_furniture_order);
        }

        private void Delete(DataGridView dgv)
        {
            database.openConnection();
            int index = selectedRow;

            var name = dgv.Rows[index].Cells[0].Value.ToString();

            var deleteQuery = $"DELETE FROM table_furniture_available where furniture_name = '{name}'";
            
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
            AskDelete(dgv_furniture);
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            groupBox_data.Enabled = true;
            Delete(dgv_furniture);
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FurnitureSending()
        {
            int available_furniture = -1;
            int order_furniture = 0;
            string name = "";
            for (int i = 0; dgv_furniture.Rows.Count > i; i++)
            {
                if (((name = dgv_furniture.Rows[i].Cells[0].Value.ToString()) == dgv_furniture_order.Rows[selectedRow].Cells[1].Value.ToString()) && ((available_furniture = Convert.ToInt32(dgv_furniture.Rows[i].Cells[1].Value)) >= (order_furniture = Convert.ToInt32(dgv_furniture_order.Rows[selectedRow].Cells[2].Value.ToString()))))
                {
                    available_furniture = available_furniture - order_furniture;
                    int id = Convert.ToInt32(dgv_furniture_order.Rows[selectedRow].Cells[0].Value);
                    var updateQuery = $"UPDATE table_furniture_available SET furniture_count = {available_furniture} WHERE furniture_name = '{name}'\n" +
                        $"UPDATE table_furniture_order SET furniture_order_sent = 1 WHERE furniture_order_id = {id}";
                    var command = new SqlCommand(updateQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                    database.closeConnection();
                    RefreshDgv(dgv_furniture);
                    RefreshDgv(dgv_furniture_order);
                    checkBox_sent.Enabled = false;
                    checkBox_sent.Text = "Отправлено";
                    break ;
                }
            } 
            if (available_furniture == -1)
            {
                MessageBox.Show("В наличии отсутствует данная мебель. Добавльте её в наличие и сможете отправить");
            }
        }

        private void checkBox_sent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sent.Checked) 
            {
                FurnitureSending();  
            }
            else 
            {
                checkBox_sent.Text = "Не отправлено";
            }
        }

        private void button_equipment_Click(object sender, EventArgs e)
        {
            FormEquipment formEquipment = new FormEquipment(false);
            formEquipment.Closed += (s, args) => this.Close();
            this.Hide();
            formEquipment.Show();
        }

        private void button_furniture_materials_Click(object sender, EventArgs e)
        {
            FormFurnitureMaterials formFurnitureMaterials = new FormFurnitureMaterials(false);
            formFurnitureMaterials.Closed += (s, args) => this.Close();
            this.Hide();
            formFurnitureMaterials.Show();
        }

        private void Order()
        {
            int index = selectedRow;
            var name = dgv_furniture_order.Rows[index].Cells[1].Value.ToString();
            database.openConnection();
            string Query = $"SELECT materials_names FROM table_furniture_materials WHERE furniture_name = '{name}'";
            var command = new SqlCommand(Query, database.GetConnection());
            string[] materials_names = command.ExecuteScalar().ToString().Split(' ');

            Query = $"SELECT materials_count FROM table_furniture_materials WHERE furniture_name = '{name}'";
            command = new SqlCommand(Query, database.GetConnection());
            string[] materials_count = command.ExecuteScalar().ToString().Split(' ');

            foreach (var material in materials_names) 
            {
                
            }
            foreach (var count in materials_count)
            {
                
            }


            database.closeConnection();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            Order();
            button_order.Enabled = false;
        }
    }
}
