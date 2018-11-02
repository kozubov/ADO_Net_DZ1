namespace ADO_2
{
    partial class User_Add
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
            this.textBox_AddLogin = new System.Windows.Forms.TextBox();
            this.textBox_AddPassword = new System.Windows.Forms.TextBox();
            this.textBox_AddAddress = new System.Windows.Forms.TextBox();
            this.textBox_AddPhone = new System.Windows.Forms.TextBox();
            this.comboBox_AddRole = new System.Windows.Forms.ComboBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_AddLogin
            // 
            this.textBox_AddLogin.Location = new System.Drawing.Point(114, 29);
            this.textBox_AddLogin.Name = "textBox_AddLogin";
            this.textBox_AddLogin.Size = new System.Drawing.Size(137, 20);
            this.textBox_AddLogin.TabIndex = 0;
            // 
            // textBox_AddPassword
            // 
            this.textBox_AddPassword.Location = new System.Drawing.Point(114, 69);
            this.textBox_AddPassword.Name = "textBox_AddPassword";
            this.textBox_AddPassword.Size = new System.Drawing.Size(137, 20);
            this.textBox_AddPassword.TabIndex = 1;
            // 
            // textBox_AddAddress
            // 
            this.textBox_AddAddress.Location = new System.Drawing.Point(114, 108);
            this.textBox_AddAddress.Name = "textBox_AddAddress";
            this.textBox_AddAddress.Size = new System.Drawing.Size(137, 20);
            this.textBox_AddAddress.TabIndex = 2;
            // 
            // textBox_AddPhone
            // 
            this.textBox_AddPhone.Location = new System.Drawing.Point(114, 151);
            this.textBox_AddPhone.Name = "textBox_AddPhone";
            this.textBox_AddPhone.Size = new System.Drawing.Size(137, 20);
            this.textBox_AddPhone.TabIndex = 3;
            // 
            // comboBox_AddRole
            // 
            this.comboBox_AddRole.FormattingEnabled = true;
            this.comboBox_AddRole.Items.AddRange(new object[] {
            "Administrator",
            "User"});
            this.comboBox_AddRole.Location = new System.Drawing.Point(114, 196);
            this.comboBox_AddRole.Name = "comboBox_AddRole";
            this.comboBox_AddRole.Size = new System.Drawing.Size(137, 21);
            this.comboBox_AddRole.TabIndex = 4;
            // 
            // button_AddUser
            // 
            this.button_AddUser.BackColor = System.Drawing.Color.Green;
            this.button_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddUser.ForeColor = System.Drawing.Color.White;
            this.button_AddUser.Location = new System.Drawing.Point(114, 259);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(137, 40);
            this.button_AddUser.TabIndex = 5;
            this.button_AddUser.Text = "Add User";
            this.button_AddUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(42, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // User_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 325);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.comboBox_AddRole);
            this.Controls.Add(this.textBox_AddPhone);
            this.Controls.Add(this.textBox_AddAddress);
            this.Controls.Add(this.textBox_AddPassword);
            this.Controls.Add(this.textBox_AddLogin);
            this.Name = "User_Add";
            this.Text = "User_Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AddLogin;
        private System.Windows.Forms.TextBox textBox_AddPassword;
        private System.Windows.Forms.TextBox textBox_AddAddress;
        private System.Windows.Forms.TextBox textBox_AddPhone;
        private System.Windows.Forms.ComboBox comboBox_AddRole;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}