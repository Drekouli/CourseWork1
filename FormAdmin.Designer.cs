namespace Factory
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.button_accounts = new System.Windows.Forms.Button();
            this.button_staff = new System.Windows.Forms.Button();
            this.button_furniture = new System.Windows.Forms.Button();
            this.button_materials = new System.Windows.Forms.Button();
            this.button_equipment = new System.Windows.Forms.Button();
            this.button_furniture_materials = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_accounts
            // 
            this.button_accounts.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_accounts.Location = new System.Drawing.Point(12, 12);
            this.button_accounts.Name = "button_accounts";
            this.button_accounts.Size = new System.Drawing.Size(381, 60);
            this.button_accounts.TabIndex = 5;
            this.button_accounts.Text = "Аккаунты";
            this.button_accounts.UseVisualStyleBackColor = true;
            this.button_accounts.Click += new System.EventHandler(this.button_accounts_Click);
            // 
            // button_staff
            // 
            this.button_staff.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_staff.Location = new System.Drawing.Point(12, 78);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(381, 60);
            this.button_staff.TabIndex = 6;
            this.button_staff.Text = "Сотрудники";
            this.button_staff.UseVisualStyleBackColor = true;
            this.button_staff.Click += new System.EventHandler(this.button_staff_Click);
            // 
            // button_furniture
            // 
            this.button_furniture.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_furniture.Location = new System.Drawing.Point(12, 144);
            this.button_furniture.Name = "button_furniture";
            this.button_furniture.Size = new System.Drawing.Size(381, 60);
            this.button_furniture.TabIndex = 7;
            this.button_furniture.Text = "Мастер";
            this.button_furniture.UseVisualStyleBackColor = true;
            this.button_furniture.Click += new System.EventHandler(this.button_furniture_Click);
            // 
            // button_materials
            // 
            this.button_materials.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_materials.Location = new System.Drawing.Point(12, 210);
            this.button_materials.Name = "button_materials";
            this.button_materials.Size = new System.Drawing.Size(381, 60);
            this.button_materials.TabIndex = 8;
            this.button_materials.Text = "Кладовщик";
            this.button_materials.UseVisualStyleBackColor = true;
            this.button_materials.Click += new System.EventHandler(this.button_materials_Click);
            // 
            // button_equipment
            // 
            this.button_equipment.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equipment.Location = new System.Drawing.Point(13, 276);
            this.button_equipment.Name = "button_equipment";
            this.button_equipment.Size = new System.Drawing.Size(381, 60);
            this.button_equipment.TabIndex = 9;
            this.button_equipment.Text = "Оборудование";
            this.button_equipment.UseVisualStyleBackColor = true;
            this.button_equipment.Click += new System.EventHandler(this.button_equipment_Click);
            // 
            // button_furniture_materials
            // 
            this.button_furniture_materials.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_furniture_materials.Location = new System.Drawing.Point(13, 342);
            this.button_furniture_materials.Name = "button_furniture_materials";
            this.button_furniture_materials.Size = new System.Drawing.Size(381, 60);
            this.button_furniture_materials.TabIndex = 10;
            this.button_furniture_materials.Text = "Материалы для мебели";
            this.button_furniture_materials.UseVisualStyleBackColor = true;
            this.button_furniture_materials.Click += new System.EventHandler(this.button_furniture_materials_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 432);
            this.Controls.Add(this.button_furniture_materials);
            this.Controls.Add(this.button_equipment);
            this.Controls.Add(this.button_materials);
            this.Controls.Add(this.button_furniture);
            this.Controls.Add(this.button_staff);
            this.Controls.Add(this.button_accounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_accounts;
        private System.Windows.Forms.Button button_staff;
        private System.Windows.Forms.Button button_furniture;
        private System.Windows.Forms.Button button_materials;
        private System.Windows.Forms.Button button_equipment;
        private System.Windows.Forms.Button button_furniture_materials;
    }
}