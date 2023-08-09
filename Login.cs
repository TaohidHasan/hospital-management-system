using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ASUSVIVOBOOK25;Initial Catalog=DBProduct;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select username, password from TUser where username = '" + txtusername.Text.Trim() + "' and Password = '" + txtpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                new Doctor().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Create_Account().Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }
    }
    }
