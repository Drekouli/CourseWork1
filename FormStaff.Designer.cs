using System.Runtime.CompilerServices;

namespace Factory
{
    partial class FormStaff
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
            this.button_admin = new System.Windows.Forms.Button();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox_menu = new System.Windows.Forms.GroupBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.date_dismis = new System.Windows.Forms.DateTimePicker();
            this.checkBox_eye = new System.Windows.Forms.CheckBox();
            this.textBox_salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date_employ = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_post = new System.Windows.Forms.TextBox();
            this.textBox_fio = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.groupBox_menu.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin.Location = new System.Drawing.Point(0, 0);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(40, 40);
            this.button_admin.TabIndex = 6;
            this.button_admin.Text = "<-";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Visible = false;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.AllowUserToResizeRows = false;
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(0, 249);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.ReadOnly = true;
            this.dgv_staff.RowHeadersVisible = false;
            this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staff.Size = new System.Drawing.Size(976, 451);
            this.dgv_staff.TabIndex = 7;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
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
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.groupBox_data);
            this.groupBox_menu.Controls.Add(this.button_search);
            this.groupBox_menu.Controls.Add(this.textBox_search);
            this.groupBox_menu.Controls.Add(this.button_save);
            this.groupBox_menu.Controls.Add(this.button_delete);
            this.groupBox_menu.Controls.Add(this.button_edit);
            this.groupBox_menu.Controls.Add(this.button_add);
            this.groupBox_menu.Location = new System.Drawing.Point(465, 12);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(404, 231);
            this.groupBox_menu.TabIndex = 12;
            this.groupBox_menu.TabStop = false;
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.textBox1);
            this.groupBox_data.Controls.Add(this.date_dismis);
            this.groupBox_data.Controls.Add(this.checkBox_eye);
            this.groupBox_data.Controls.Add(this.textBox_salary);
            this.groupBox_data.Controls.Add(this.label5);
            this.groupBox_data.Controls.Add(this.label4);
            this.groupBox_data.Controls.Add(this.date_employ);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.label2);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Controls.Add(this.textBox_post);
            this.groupBox_data.Controls.Add(this.textBox_fio);
            this.groupBox_data.Enabled = false;
            this.groupBox_data.Location = new System.Drawing.Point(9, 87);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(345, 141);
            this.groupBox_data.TabIndex = 17;
            this.groupBox_data.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 28;
            // 
            // date_dismis
            // 
            this.date_dismis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_dismis.Location = new System.Drawing.Point(107, 113);
            this.date_dismis.Name = "date_dismis";
            this.date_dismis.Size = new System.Drawing.Size(205, 20);
            this.date_dismis.TabIndex = 27;
            this.date_dismis.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // checkBox_eye
            // 
            this.checkBox_eye.AutoSize = true;
            this.checkBox_eye.Image = global::Factory.Properties.Resources.eye_close;
            this.checkBox_eye.Location = new System.Drawing.Point(297, 107);
            this.checkBox_eye.Name = "checkBox_eye";
            this.checkBox_eye.Size = new System.Drawing.Size(47, 32);
            this.checkBox_eye.TabIndex = 25;
            this.checkBox_eye.UseVisualStyleBackColor = true;
            this.checkBox_eye.CheckedChanged += new System.EventHandler(this.checkBox_eye_CheckedChanged);
            // 
            // textBox_salary
            // 
            this.textBox_salary.Location = new System.Drawing.Point(107, 61);
            this.textBox_salary.Name = "textBox_salary";
            this.textBox_salary.Size = new System.Drawing.Size(205, 20);
            this.textBox_salary.TabIndex = 24;
            this.textBox_salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salary_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Дата увольнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Дата принятия";
            // 
            // date_employ
            // 
            this.date_employ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_employ.Location = new System.Drawing.Point(107, 87);
            this.date_employ.Name = "date_employ";
            this.date_employ.Size = new System.Drawing.Size(205, 20);
            this.date_employ.TabIndex = 20;
            this.date_employ.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Зарплата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ФИО";
            // 
            // textBox_post
            // 
            this.textBox_post.Location = new System.Drawing.Point(107, 35);
            this.textBox_post.Name = "textBox_post";
            this.textBox_post.Size = new System.Drawing.Size(205, 20);
            this.textBox_post.TabIndex = 16;
            // 
            // textBox_fio
            // 
            this.textBox_fio.Location = new System.Drawing.Point(107, 9);
            this.textBox_fio.Name = "textBox_fio";
            this.textBox_fio.Size = new System.Drawing.Size(205, 20);
            this.textBox_fio.TabIndex = 15;
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
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 701);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.dgv_staff);
            this.Controls.Add(this.button_admin);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_menu.PerformLayout();
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.CheckBox checkBox_eye;
        private System.Windows.Forms.TextBox textBox_salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_employ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_post;
        private System.Windows.Forms.TextBox textBox_fio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker date_dismis;
    }
}