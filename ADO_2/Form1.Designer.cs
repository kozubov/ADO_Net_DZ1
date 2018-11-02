namespace ADO_2
{
    partial class Form1
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
            this.button_AddNewUser = new System.Windows.Forms.Button();
            this.listView_Data = new System.Windows.Forms.ListView();
            this.ID_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Admin_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_AddNewUser
            // 
            this.button_AddNewUser.Location = new System.Drawing.Point(13, 405);
            this.button_AddNewUser.Name = "button_AddNewUser";
            this.button_AddNewUser.Size = new System.Drawing.Size(120, 35);
            this.button_AddNewUser.TabIndex = 11;
            this.button_AddNewUser.Text = "Add New User";
            this.button_AddNewUser.UseVisualStyleBackColor = true;
            // 
            // listView_Data
            // 
            this.listView_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_column,
            this.Login_column,
            this.Password_column,
            this.Address_column,
            this.Phone_column,
            this.Admin_column});
            this.listView_Data.FullRowSelect = true;
            this.listView_Data.GridLines = true;
            this.listView_Data.Location = new System.Drawing.Point(13, 27);
            this.listView_Data.MultiSelect = false;
            this.listView_Data.Name = "listView_Data";
            this.listView_Data.Size = new System.Drawing.Size(586, 370);
            this.listView_Data.TabIndex = 12;
            this.listView_Data.UseCompatibleStateImageBehavior = false;
            this.listView_Data.View = System.Windows.Forms.View.Details;
            // 
            // ID_column
            // 
            this.ID_column.Text = "ID";
            this.ID_column.Width = 50;
            // 
            // Login_column
            // 
            this.Login_column.Text = "Login";
            this.Login_column.Width = 100;
            // 
            // Password_column
            // 
            this.Password_column.Text = "Password";
            this.Password_column.Width = 100;
            // 
            // Address_column
            // 
            this.Address_column.Text = "Address";
            this.Address_column.Width = 150;
            // 
            // Phone_column
            // 
            this.Phone_column.DisplayIndex = 5;
            this.Phone_column.Text = "Phone";
            this.Phone_column.Width = 100;
            // 
            // Admin_column
            // 
            this.Admin_column.DisplayIndex = 4;
            this.Admin_column.Text = "Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.listView_Data);
            this.Controls.Add(this.button_AddNewUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddNewUser;
        private System.Windows.Forms.ListView listView_Data;
        private System.Windows.Forms.ColumnHeader ID_column;
        private System.Windows.Forms.ColumnHeader Login_column;
        private System.Windows.Forms.ColumnHeader Password_column;
        private System.Windows.Forms.ColumnHeader Address_column;
        private System.Windows.Forms.ColumnHeader Admin_column;
        private System.Windows.Forms.ColumnHeader Phone_column;
    }
}

