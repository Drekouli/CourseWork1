namespace Factory
{
    partial class FormFurnitureMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFurnitureMaterials));
            this.button_furniture = new System.Windows.Forms.Button();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_materials_names = new System.Windows.Forms.TextBox();
            this.textBox_materials_count = new System.Windows.Forms.TextBox();
            this.textBox_options = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_furniture_name = new System.Windows.Forms.TextBox();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dgv_furniture_materials = new System.Windows.Forms.DataGridView();
            this.button_admin = new System.Windows.Forms.Button();
            this.groupBox_data.SuspendLayout();
            this.groupBox_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // button_furniture
            // 
            this.button_furniture.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_furniture.Location = new System.Drawing.Point(-1, -1);
            this.button_furniture.Name = "button_furniture";
            this.button_furniture.Size = new System.Drawing.Size(27, 20);
            this.button_furniture.TabIndex = 33;
            this.button_furniture.Text = "<-";
            this.button_furniture.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_furniture.UseVisualStyleBackColor = true;
            this.button_furniture.Visible = false;
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.textBox_materials_names);
            this.groupBox_data.Controls.Add(this.textBox_materials_count);
            this.groupBox_data.Controls.Add(this.textBox_options);
            this.groupBox_data.Controls.Add(this.label4);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.label2);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Controls.Add(this.textBox_furniture_name);
            this.groupBox_data.Enabled = false;
            this.groupBox_data.Location = new System.Drawing.Point(217, 21);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(430, 175);
            this.groupBox_data.TabIndex = 31;
            this.groupBox_data.TabStop = false;
            // 
            // textBox_materials_names
            // 
            this.textBox_materials_names.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_materials_names.Location = new System.Drawing.Point(164, 41);
            this.textBox_materials_names.Name = "textBox_materials_names";
            this.textBox_materials_names.Size = new System.Drawing.Size(255, 23);
            this.textBox_materials_names.TabIndex = 30;
            // 
            // textBox_materials_count
            // 
            this.textBox_materials_count.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_materials_count.Location = new System.Drawing.Point(164, 70);
            this.textBox_materials_count.Name = "textBox_materials_count";
            this.textBox_materials_count.Size = new System.Drawing.Size(255, 23);
            this.textBox_materials_count.TabIndex = 29;
            this.textBox_materials_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_materials_count_KeyPress);
            // 
            // textBox_options
            // 
            this.textBox_options.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_options.Location = new System.Drawing.Point(164, 99);
            this.textBox_options.Name = "textBox_options";
            this.textBox_options.Size = new System.Drawing.Size(255, 23);
            this.textBox_options.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Описание мебели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Количество материалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имена материалов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // textBox_furniture_name
            // 
            this.textBox_furniture_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_furniture_name.Location = new System.Drawing.Point(164, 12);
            this.textBox_furniture_name.Name = "textBox_furniture_name";
            this.textBox_furniture_name.Size = new System.Drawing.Size(255, 23);
            this.textBox_furniture_name.TabIndex = 15;
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.button_search);
            this.groupBox_menu.Controls.Add(this.textBox_search);
            this.groupBox_menu.Controls.Add(this.button_save);
            this.groupBox_menu.Controls.Add(this.button_delete);
            this.groupBox_menu.Controls.Add(this.button_edit);
            this.groupBox_menu.Controls.Add(this.button_add);
            this.groupBox_menu.Location = new System.Drawing.Point(0, 21);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(212, 175);
            this.groupBox_menu.TabIndex = 30;
            this.groupBox_menu.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(6, 41);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(200, 28);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(6, 12);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 23);
            this.textBox_search.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(6, 143);
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
            this.button_delete.Location = new System.Drawing.Point(6, 109);
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
            this.button_edit.Location = new System.Drawing.Point(109, 75);
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
            this.button_add.Location = new System.Drawing.Point(6, 75);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 28);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dgv_furniture_materials
            // 
            this.dgv_furniture_materials.AllowUserToAddRows = false;
            this.dgv_furniture_materials.AllowUserToDeleteRows = false;
            this.dgv_furniture_materials.AllowUserToResizeRows = false;
            this.dgv_furniture_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_furniture_materials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_furniture_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_furniture_materials.Location = new System.Drawing.Point(0, 198);
            this.dgv_furniture_materials.Name = "dgv_furniture_materials";
            this.dgv_furniture_materials.ReadOnly = true;
            this.dgv_furniture_materials.RowHeadersVisible = false;
            this.dgv_furniture_materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_furniture_materials.Size = new System.Drawing.Size(648, 457);
            this.dgv_furniture_materials.TabIndex = 29;
            this.dgv_furniture_materials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_equipment_CellClick);
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin.Location = new System.Drawing.Point(-1, -1);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(27, 20);
            this.button_admin.TabIndex = 28;
            this.button_admin.Text = "<-";
            this.button_admin.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Visible = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // FormFurnitureMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 654);
            this.Controls.Add(this.button_furniture);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.dgv_furniture_materials);
            this.Controls.Add(this.button_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFurnitureMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы на единицу мебели";
            this.Load += new System.EventHandler(this.FormFurnitureMaterials_Load);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_furniture_materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_furniture;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_materials_count;
        private System.Windows.Forms.TextBox textBox_options;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_furniture_name;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dgv_furniture_materials;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.TextBox textBox_materials_names;
    }
}