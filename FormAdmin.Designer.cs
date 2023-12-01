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
            this.button_accounts = new System.Windows.Forms.Button();
            this.button_staff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_accounts
            // 
            this.button_accounts.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_accounts.Location = new System.Drawing.Point(12, 12);
            this.button_accounts.Name = "button_accounts";
            this.button_accounts.Size = new System.Drawing.Size(131, 35);
            this.button_accounts.TabIndex = 5;
            this.button_accounts.Text = "Аккаунты";
            this.button_accounts.UseVisualStyleBackColor = true;
            this.button_accounts.Click += new System.EventHandler(this.button_accounts_Click);
            // 
            // button_staff
            // 
            this.button_staff.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_staff.Location = new System.Drawing.Point(12, 53);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(202, 35);
            this.button_staff.TabIndex = 6;
            this.button_staff.Text = "Работа с кадрами";
            this.button_staff.UseVisualStyleBackColor = true;
            this.button_staff.Click += new System.EventHandler(this.button_staff_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Мастер";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Кладовщик";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 376);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_staff);
            this.Controls.Add(this.button_accounts);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_accounts;
        private System.Windows.Forms.Button button_staff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}