namespace Factory
{
    partial class FormRegistration
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
            this.textBox_access = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dgv_auth = new System.Windows.Forms.DataGridView();
            this.button_admin = new System.Windows.Forms.Button();
            this.groupBox_menu.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_menu
            // 
            this.groupBox_menu.Controls.Add(this.groupBox_data);
            this.groupBox_menu.Controls.Add(this.button_save);
            this.groupBox_menu.Controls.Add(this.button_delete);
            this.groupBox_menu.Controls.Add(this.button_edit);
            this.groupBox_menu.Controls.Add(this.button_add);
            this.groupBox_menu.Location = new System.Drawing.Point(46, 0);
            this.groupBox_menu.Name = "groupBox_menu";
            this.groupBox_menu.Size = new System.Drawing.Size(337, 180);
            this.groupBox_menu.TabIndex = 15;
            this.groupBox_menu.TabStop = false;
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.textBox_access);
            this.groupBox_data.Controls.Add(this.label3);
            this.groupBox_data.Controls.Add(this.label2);
            this.groupBox_data.Controls.Add(this.label1);
            this.groupBox_data.Controls.Add(this.textBox_password);
            this.groupBox_data.Controls.Add(this.textBox_login);
            this.groupBox_data.Enabled = false;
            this.groupBox_data.Location = new System.Drawing.Point(6, 80);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(320, 91);
            this.groupBox_data.TabIndex = 17;
            this.groupBox_data.TabStop = false;
            // 
            // textBox_access
            // 
            this.textBox_access.Location = new System.Drawing.Point(107, 61);
            this.textBox_access.Name = "textBox_access";
            this.textBox_access.Size = new System.Drawing.Size(205, 20);
            this.textBox_access.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Права доступа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(107, 35);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(205, 20);
            this.textBox_password.TabIndex = 16;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(107, 9);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(205, 20);
            this.textBox_login.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(212, 12);
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
            this.button_delete.Location = new System.Drawing.Point(109, 46);
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
            this.button_edit.Location = new System.Drawing.Point(109, 12);
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
            this.button_add.Location = new System.Drawing.Point(6, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(97, 28);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dgv_auth
            // 
            this.dgv_auth.AllowUserToAddRows = false;
            this.dgv_auth.AllowUserToDeleteRows = false;
            this.dgv_auth.AllowUserToResizeRows = false;
            this.dgv_auth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_auth.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_auth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_auth.Location = new System.Drawing.Point(0, 186);
            this.dgv_auth.Name = "dgv_auth";
            this.dgv_auth.ReadOnly = true;
            this.dgv_auth.RowHeadersVisible = false;
            this.dgv_auth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_auth.Size = new System.Drawing.Size(523, 451);
            this.dgv_auth.TabIndex = 14;
            this.dgv_auth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_auth_CellClick);
            this.dgv_auth.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_auth_CellContentClick);
            // 
            // button_admin
            // 
            this.button_admin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin.Location = new System.Drawing.Point(0, 0);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(40, 40);
            this.button_admin.TabIndex = 13;
            this.button_admin.Text = "<-";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 644);
            this.Controls.Add(this.groupBox_menu);
            this.Controls.Add(this.dgv_auth);
            this.Controls.Add(this.button_admin);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.groupBox_menu.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_auth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_menu;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_access;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dgv_auth;
        private System.Windows.Forms.Button button_admin;
    }
}