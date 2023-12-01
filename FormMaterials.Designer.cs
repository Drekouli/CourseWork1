namespace Factory
{
    partial class FormMaterials
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
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox_options = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dgv_materials = new System.Windows.Forms.DataGridView();
            this.button_admin = new System.Windows.Forms.Button();
            this.groupBox_menu.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.groupBox_data);
            this.groupBox_menu.Controls.Add(this.button_search);
            this.groupBox_menu.Controls.Add(this.textBox_search);
            this.groupBox_menu.Controls.Add(this.button_save);
            this.groupBox_menu.Controls.Add(this.button_delete);
            this.groupBox_menu.Controls.Add(this.button_edit);
            this.groupBox_menu.Controls.Add(this.button_add);
            this.groupBox_menu.Location = new System.Drawing.Point(45, 12);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(364, 188);
            this.groupBox_menu.TabIndex = 15;
            this.groupBox_menu.TabStop = false;
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
            this.groupBox_data.Location = new System.Drawing.Point(9, 87);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(345, 94);
            this.groupBox_data.TabIndex = 17;
            this.groupBox_data.TabStop = false;
            // 
            // textBox_options
            // 
            this.textBox_options.Location = new System.Drawing.Point(107, 61);
            this.textBox_options.Name = "textBox_options";
            this.textBox_options.Size = new System.Drawing.Size(205, 20);
            this.textBox_options.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дополнительно";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(107, 35);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(205, 20);
            this.textBox_count.TabIndex = 16;
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(107, 9);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(205, 20);
            this.textBox_name.TabIndex = 15;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(113, 53);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(97, 28);
            this.button_search.TabIndex = 16;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(113, 20);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(215, 53);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(97, 28);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(215, 19);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(97, 28);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit.Location = new System.Drawing.Point(9, 53);
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
            this.button_add.Location = new System.Drawing.Point(9, 19);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 28);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dgv_materials
            // 
            this.dgv_materials.AllowUserToAddRows = false;
            this.dgv_materials.AllowUserToDeleteRows = false;
            this.dgv_materials.AllowUserToResizeRows = false;
            this.dgv_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_materials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materials.Location = new System.Drawing.Point(-1, 249);
            this.dgv_materials.Name = "dgv_materials";
            this.dgv_materials.ReadOnly = true;
            this.dgv_materials.RowHeadersVisible = false;
            this.dgv_materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materials.Size = new System.Drawing.Size(522, 451);
            this.dgv_materials.TabIndex = 14;
            this.dgv_materials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin.Location = new System.Drawing.Point(-1, 0);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(40, 40);
            this.button_admin.TabIndex = 13;
            this.button_admin.Text = "<-";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Visible = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // FormMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 700);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.dgv_materials);
            this.Controls.Add(this.button_admin);
            this.Name = "FormMaterials";
            this.Text = "FormMaterials";
            this.Load += new System.EventHandler(this.FormMaterials_Load);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dgv_materials;
        private System.Windows.Forms.Button button_admin;
    }
}