using ClassLibrary1.Operation;
using ClassLibrary1.User;
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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Username=txtuser.Text;
            eProduct.Password=txtpass.Text;


            OProduct oProduct = new OProduct();
            int number = oProduct.insertuser(eProduct);

            if (number != 0||number !=' ')
            {
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Username = txtuser.Text;

            OProduct oProduct = new OProduct();
            int id = oProduct.deleteuser(eProduct);
            if (id != 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please Enter username");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.Test();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
