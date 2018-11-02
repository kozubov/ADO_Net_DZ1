using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ADO_2
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter da = null;
        private DataSet set = null;
        SqlCommandBuilder command = null;
        private int counter = 0;
        private DataTable ds = null;

        public Form1()
        {
            InitializeComponent();
            listView_Data.MouseDoubleClick += ListView_Data_MouseDoubleClick;
            button_AddNewUser.Click += Button_AddNewUser_Click;
            Base_Load();
        }

        private void Button_AddNewUser_Click(object sender, EventArgs e)
        {
            // Add New User in Add Form
            User_Add A = new User_Add(this, ds, counter);
            if (A.ShowDialog() == DialogResult.OK)
            {
                Base_Load();
            }
        }

        private void ListView_Data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Open selected User in Edit Form
            if (e.Button == MouseButtons.Left)
            {
                User_View A = new User_View(this, ds, listView_Data.FocusedItem.Index);
                if (A.ShowDialog() == DialogResult.OK)
                {
                    Base_Load();
                }
            }
        }

        private void Base_Load()
        {
            counter = 0;
            listView_Data.Items.Clear();
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

            // DB querry to show ONLY Admin role users
            string querry = "SELECT * FROM Users WHERE AdminUser = 1";
            set = new DataSet();
            da = new SqlDataAdapter(querry, conn);
            command = new SqlCommandBuilder(da);
            da.Fill(set);
            counter = 0;
            ds = set.Tables[0];
            string[] row = new string[ds.Columns.Count];

            //Fill in Data from DB 
            ListViewItem itm;
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                for (int j = 0; j < ds.Columns.Count; j++)
                {
                    row[j] = ds.Rows[i][j].ToString();
                }
                itm = new ListViewItem(row);
                listView_Data.Items.Add(itm);
            }
        }

        public void Base_Update(DataTable table)
        {
            // Update DB
            set = table.DataSet;
            da.Update(set);
        }
    }
}
