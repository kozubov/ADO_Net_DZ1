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
    public partial class User_View : Form
    {
        private DataTable dataTable = null;
        private Form1 Form = null;
        private int rows_count = 0;
        public User_View(Form1 form, DataTable table, int number)
        {
            InitializeComponent();
            Form = form;
            dataTable = table;
            rows_count = number;

            // Buttons click events
            button_Save.Click += Button_Save_Click;
            button_Delete.Click += Button_Delete_Click;

            //Fill in selected User Data into Edit Form 
            textBox_Login.Text = table.Rows[number][1].ToString();
            textBox_Password.Text = table.Rows[number][2].ToString();
            textBox_Address.Text = table.Rows[number][3].ToString();
            textBox_Phone.Text = table.Rows[number][4].ToString();
            if (table.Rows[number][5].ToString() == "True")
            {
                comboBox_Role.SelectedIndex = 0;
            }
            else
            {
                comboBox_Role.SelectedIndex = 1;
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            //Delete selected from DB
            dataTable.Rows[rows_count].Delete();
            Form.Base_Update(dataTable);
            this.DialogResult = DialogResult.OK;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            //Check for empty data
            if (textBox_Login.Text == "" || textBox_Password.Text == "" || textBox_Address.Text == "" || textBox_Phone.Text == "")
            {
                MessageBox.Show("Fill ALL Data!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check for same LOGIN
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][1].ToString().Equals(textBox_Login.Text))
                {
                    MessageBox.Show("Sorry! That LOGIN present in Database", "Attention", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            //Edited data write to DB
            dataTable.Rows[rows_count][1] = textBox_Login.Text.ToString();
            dataTable.Rows[rows_count][2] = textBox_Password.Text.ToString();
            dataTable.Rows[rows_count][3] = textBox_Address.Text.ToString();
            dataTable.Rows[rows_count][4] = textBox_Phone.Text.ToString();
            dataTable.Rows[rows_count][5] = comboBox_Role.SelectedIndex == 0 ? "True" : "False";
            Form.Base_Update(dataTable);
            DialogResult = DialogResult.OK;
        }
    }
}
