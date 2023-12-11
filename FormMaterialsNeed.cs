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
using System.Xml.Linq;

namespace Factory
{
    public partial class FormMaterialsNeed : Form
    {
        DataBase database = new DataBase();

        public FormMaterialsNeed()
        {
            InitializeComponent();
        }


        private void CreateColumns()
        {
            dgv_order.Columns.Add("materials_names", "Имя");
            dgv_order.Columns.Add("materials_count", "Количество");          
        }


        private void RefreshDgv(DataGridView dgv)
        {
            
            dgv.Rows.Clear();
            database.openConnection();
            string Query = $"SELECT furniture_order_count FROM table_furniture_order WHERE furniture_order_materials = 0";
            var command = new SqlCommand(Query, database.GetConnection());
            int furniture_count = Convert.ToInt32(command.ExecuteScalar());

            if (furniture_count > 0)
            {
                Query = $"SELECT materials_names FROM table_furniture_materials INNER JOIN table_furniture_order " +
                    $"ON (table_furniture_materials.furniture_name = table_furniture_order.furniture_order_name) " +
                    $"WHERE table_furniture_order.furniture_order_materials = 0";
                command = new SqlCommand(Query, database.GetConnection());
                string[] materials_names = command.ExecuteScalar().ToString().Split(' ');

                Query = $"SELECT materials_count FROM table_furniture_materials INNER JOIN table_furniture_order " +
                    $"ON (table_furniture_materials.furniture_name = table_furniture_order.furniture_order_name) " +
                    $"WHERE table_furniture_order.furniture_order_materials = 0";
                command = new SqlCommand(Query, database.GetConnection());

                string[] materials_count_str = command.ExecuteScalar().ToString().Split(' ');
                int[] materials_count_int = Array.ConvertAll(materials_count_str, s => int.Parse(s));

                for (byte i = 0; i < materials_names.Length; i++)
                {
                    materials_count_int[i] *= furniture_count;
                    dgv_order.Rows.Add(materials_names[i], materials_count_int[i]);
                }
            }
            else
            {
                this.Close();
            }
            database.closeConnection();
            
            
            
        }
        private void Completed()
        {
            database.openConnection();
            string completeQuery = $"UPDATE TOP (1) table_furniture_order SET furniture_order_materials = 1 WHERE furniture_order_materials = 0";
            var command = new SqlCommand(completeQuery, database.GetConnection());
            command.ExecuteNonQuery();
            database.closeConnection();
        }

        private void button_completed_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены что выполнили заказ?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Completed();
                RefreshDgv(dgv_order);
            }

        }

        private void FormMaterialsNeed_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_order);
        }
    }
}
