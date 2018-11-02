using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_2
{
    public partial class User_Add : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int rows_count = 0;
        public User_Add(Form1 form, DataTable table, int number)
        {
            dataTable = table;
            Form = form;
            rows_count = number;
            InitializeComponent();
            button_AddUser.Click += Button_AddUser_Click;
        }

        private void Button_AddUser_Click(object sender, EventArgs e)
        {
            //Check for empty data
            if (textBox_AddLogin.Text == "" || textBox_AddPassword.Text == "" || textBox_AddAddress.Text == "" || textBox_AddPhone.Text == "")
            {
                MessageBox.Show("Fill ALL Data!", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            //Check for same LOGIN
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString().Equals(textBox_AddLogin.Text))
                {
                    MessageBox.Show("Sorry! That LOGIN present in Database!", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // Add new User into DB
            DataRow row = dataTable.NewRow();
            row["Id"] = rows_count;
            row["LoginUser"] = textBox_AddLogin.Text;
            row["PasswordUser"] = textBox_AddPassword.Text;
            row["AddressUser"] = textBox_AddAddress.Text;
            row["PhoneUser"] = textBox_AddPhone.Text;
            if (comboBox_AddRole.SelectedIndex == 0)
            {
                row["AdminUser"] = "True";
            }
            else
            {
                row["AdminUser"] = "False";
            }

            dataTable.Rows.Add(row);
            Form.Base_Update(dataTable);
            DialogResult = DialogResult.OK;
        }
    }
}
