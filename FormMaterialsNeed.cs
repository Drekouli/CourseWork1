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
            /*
            dgv.Rows.Clear();
            string queryString = $"SELECT materials_names, materials_count FROM table_furniture_materials " +
                $"WHERE table_furniture_materials.furniture_name = table_furniture_order.furniture_order_name and table_furniture_order.furniture_order_materials = 0";
            $"SELECT table_furniture_materials.materials_names AS 'name', table_furniture_materials.materials_count AS 'count' FROM posts INNER JOIN users ON (posts.`autor_id`=users.`id`)\r\nWHERE posts.`id`=?";
            

            SqlCommand sqlCommand = new SqlCommand(Query, database.GetConnection());
            database.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            */
            database.openConnection();
            string Query = $"SELECT materials_names FROM table_furniture_materials INNER JOIN table_furniture_order " +
                $"ON (table_furniture_materials.furniture_name = table_furniture_order.furniture_order_name) " +
                $"WHERE table_furniture_order.furniture_order_materials = 0";
            var command = new SqlCommand(Query, database.GetConnection());
            string[] materials_names = command.ExecuteScalar().ToString().Split(' ');

            Query = $"SELECT materials_count FROM table_furniture_materials INNER JOIN table_furniture_order " +
                $"ON (table_furniture_materials.furniture_name = table_furniture_order.furniture_order_name) " +
                $"WHERE table_furniture_order.furniture_order_materials = 0";
            command = new SqlCommand(Query, database.GetConnection());
            string[] materials_count = command.ExecuteScalar().ToString().Split(' ');

            database.closeConnection();
            //foreach ( var material in materials_names ) { MessageBox.Show(material); }
            
            for ( byte i = 0; i < materials_names.Length; i++) 
            {
                dgv_order.Rows.Add(materials_names[i], materials_count[i]);
            }
        }
        private void button_completed_Click(object sender, EventArgs e)
        {
            int selectedRow = dgv_order.CurrentCell.RowIndex;

        }

        private void FormMaterialsNeed_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDgv(dgv_order);
        }
    }
}
