namespace Factory
{
    partial class FormFurniture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFurniture));
            this.groupBox_order = new System.Windows.Forms.GroupBox();
            this.dgv_furniture_order = new System.Windows.Forms.DataGridView();
            this.groupBox_menu_order = new System.Windows.Forms.GroupBox();
            this.checkBox_sent = new System.Windows.Forms.CheckBox();
            this.button_search_order = new System.Windows.Forms.Button();
            this.textBox_search_order = new System.Windows.Forms.TextBox();
            this.groupBox_available = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_options = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dgv_furniture = new System.Windows.Forms.DataGridView();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_admin = new System.Windows.Forms.Button();
            this.button_equipment = new System.Windows.Forms.Button();
            this.button_furniture_materials = new System.Windows.Forms.Button();
            this.groupBox_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture_order)).BeginInit();
            this.groupBox_menu_order.SuspendLayout();
            this.groupBox_available.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture)).BeginInit();
            this.groupBox_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_order
            // 
            this.groupBox_order.Controls.Add(this.dgv_furniture_order);
            this.groupBox_order.Controls.Add(this.groupBox_menu_order);
            this.groupBox_order.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_order.Location = new System.Drawing.Point(660, 21);
            this.groupBox_order.Name = "groupBox_order";
            this.groupBox_order.Size = new System.Drawing.Size(660, 668);
            this.groupBox_order.TabIndex = 20;
            this.groupBox_order.TabStop = false;
            this.groupBox_order.Text = "Заказы";
            // 
            // dgv_furniture_order
            // 
            this.dgv_furniture_order.AllowUserToAddRows = false;
            this.dgv_furniture_order.AllowUserToDeleteRows = false;
            this.dgv_furniture_order.AllowUserToResizeRows = false;
            this.dgv_furniture_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_furniture_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_furniture_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_furniture_order.Location = new System.Drawing.Point(6, 225);
            this.dgv_furniture_order.MultiSelect = false;
            this.dgv_furniture_order.Name = "dgv_furniture_order";
            this.dgv_furniture_order.ReadOnly = true;
            this.dgv_furniture_order.RowHeadersVisible = false;
            this.dgv_furniture_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_furniture_order.Size = new System.Drawing.Size(648, 437);
            this.dgv_furniture_order.TabIndex = 14;
            this.dgv_furniture_order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_furniture_order_CellClick);
            // 
            // groupBox_menu_order
            // 
            this.groupBox_menu_order.Controls.Add(this.checkBox_sent);
            this.groupBox_menu_order.Controls.Add(this.button_search_order);
            this.groupBox_menu_order.Controls.Add(this.textBox_search_order);
            this.groupBox_menu_order.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_menu_order.Location = new System.Drawing.Point(12, 39);
            this.groupBox_menu_order.Name = "groupBox_menu_order";
            this.groupBox_menu_order.Size = new System.Drawing.Size(642, 180);
            this.groupBox_menu_order.TabIndex = 15;
            this.groupBox_menu_order.TabStop = false;
            // 
            // checkBox_sent
            // 
            this.checkBox_sent.Enabled = false;
            this.checkBox_sent.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_sent.Location = new System.Drawing.Point(259, 113);
            this.checkBox_sent.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox_sent.Name = "checkBox_sent";
            this.checkBox_sent.Size = new System.Drawing.Size(117, 21);
            this.checkBox_sent.TabIndex = 32;
            this.checkBox_sent.UseVisualStyleBackColor = true;
            this.checkBox_sent.CheckedChanged += new System.EventHandler(this.checkBox_sent_CheckedChanged);
            // 
            // button_search_order
            // 
            this.button_search_order.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search_order.Location = new System.Drawing.Point(6, 41);
            this.button_search_order.Name = "button_search_order";
            this.button_search_order.Size = new System.Drawing.Size(198, 28);
            this.button_search_order.TabIndex = 16;
            this.button_search_order.Text = "Найти";
            this.button_search_order.UseVisualStyleBackColor = true;
            this.button_search_order.Click += new System.EventHandler(this.button_search_order_Click);
            // 
            // textBox_search_order
            // 
            this.textBox_search_order.Location = new System.Drawing.Point(6, 12);
            this.textBox_search_order.Name = "textBox_search_order";
            this.textBox_search_order.Size = new System.Drawing.Size(198, 23);
            this.textBox_search_order.TabIndex = 15;
            // 
            // groupBox_available
            // 
            this.groupBox_available.Controls.Add(this.groupBox_data);
            this.groupBox_available.Controls.Add(this.dgv_furniture);
            this.groupBox_available.Controls.Add(this.groupBox_menu);
            this.groupBox_available.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_available.Location = new System.Drawing.Point(0, 21);
            this.groupBox_available.Name = "groupBox_available";
            this.groupBox_available.Size = new System.Drawing.Size(660, 668);
            this.groupBox_available.TabIndex = 19;
            this.groupBox_available.TabStop = false;
            this.groupBox_available.Text = "В наличии";
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.textBox_options);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.label2);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Controls.Add(this.textBox_count);
            this.groupBox_data.Controls.Add(this.textBox_name);
            this.groupBox_data.Enabled = false;
            this.groupBox_data.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_data.Location = new System.Drawing.Point(227, 31);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(426, 188);
            this.groupBox_data.TabIndex = 17;
            this.groupBox_data.TabStop = false;
            // 
            // textBox_options
            // 
            this.textBox_options.Location = new System.Drawing.Point(113, 74);
            this.textBox_options.Name = "textBox_options";
            this.textBox_options.Size = new System.Drawing.Size(205, 23);
            this.textBox_options.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дополнительно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(113, 45);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(205, 23);
            this.textBox_count.TabIndex = 16;
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(113, 17);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(205, 23);
            this.textBox_name.TabIndex = 15;
            // 
            // dgv_furniture
            // 
            this.dgv_furniture.AllowUserToAddRows = false;
            this.dgv_furniture.AllowUserToDeleteRows = false;
            this.dgv_furniture.AllowUserToResizeRows = false;
            this.dgv_furniture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_furniture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_furniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_furniture.Location = new System.Drawing.Point(6, 225);
            this.dgv_furniture.MultiSelect = false;
            this.dgv_furniture.Name = "dgv_furniture";
            this.dgv_furniture.ReadOnly = true;
            this.dgv_furniture.RowHeadersVisible = false;
            this.dgv_furniture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_furniture.Size = new System.Drawing.Size(648, 437);
            this.dgv_furniture.TabIndex = 14;
            this.dgv_furniture.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_furniture_CellClick);
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.button_search);
            this.groupBox_menu.Controls.Add(this.textBox_search);
            this.groupBox_menu.Controls.Add(this.button_save);
            this.groupBox_menu.Controls.Add(this.button_delete);
            this.groupBox_menu.Controls.Add(this.button_edit);
            this.groupBox_menu.Controls.Add(this.button_add);
            this.groupBox_menu.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_menu.Location = new System.Drawing.Point(6, 31);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(215, 188);
            this.groupBox_menu.TabIndex = 15;
            this.groupBox_menu.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(6, 46);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(200, 28);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(6, 17);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 23);
            this.textBox_search.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(6, 148);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(200, 28);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(6, 114);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(200, 28);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.Location = new System.Drawing.Point(109, 80);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(97, 28);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(6, 80);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 28);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin.Location = new System.Drawing.Point(-1, -1);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(27, 20);
            this.button_admin.TabIndex = 18;
            this.button_admin.Text = "<-";
            this.button_admin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Visible = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // button_equipment
            // 
            this.button_equipment.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equipment.Location = new System.Drawing.Point(1194, 0);
            this.button_equipment.Name = "button_equipment";
            this.button_equipment.Size = new System.Drawing.Size(127, 30);
            this.button_equipment.TabIndex = 21;
            this.button_equipment.Text = "Оборудование";
            this.button_equipment.UseVisualStyleBackColor = true;
            this.button_equipment.Click += new System.EventHandler(this.button_equipment_Click);
            // 
            // button_furniture_materials
            // 
            this.button_furniture_materials.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_furniture_materials.Location = new System.Drawing.Point(991, 0);
            this.button_furniture_materials.Name = "button_furniture_materials";
            this.button_furniture_materials.Size = new System.Drawing.Size(197, 30);
            this.button_furniture_materials.TabIndex = 22;
            this.button_furniture_materials.Text = "Материалы для мебели";
            this.button_furniture_materials.UseVisualStyleBackColor = true;
            this.button_furniture_materials.Click += new System.EventHandler(this.button_furniture_materials_Click);
            // 
            // FormFurniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 688);
            this.Controls.Add(this.button_furniture_materials);
            this.Controls.Add(this.button_equipment);
            this.Controls.Add(this.groupBox_order);
            this.Controls.Add(this.groupBox_available);
            this.Controls.Add(this.button_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFurniture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мебель";
            this.Load += new System.EventHandler(this.FormFurniture_Load);
            this.groupBox_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture_order)).EndInit();
            this.groupBox_menu_order.ResumeLayout(false);
            this.groupBox_menu_order.PerformLayout();
            this.groupBox_available.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture)).EndInit();
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_order;
        private System.Windows.Forms.CheckBox checkBox_sent;
        private System.Windows.Forms.DataGridView dgv_furniture_order;
        private System.Windows.Forms.GroupBox groupBox_menu_order;
        private System.Windows.Forms.Button button_search_order;
        private System.Windows.Forms.TextBox textBox_search_order;
        private System.Windows.Forms.GroupBox groupBox_available;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.DataGridView dgv_furniture;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Button button_equipment;
        private System.Windows.Forms.Button button_furniture_materials;
    }
}