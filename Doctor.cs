using ClassLibrary1.Operation;
using ClassLibrary1.User;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;
            eProduct.Address = txtadd.Text;
            eProduct.Phone = txtphn.Text;


            OProduct oProduct = new OProduct();
            int number = oProduct.insert(eProduct);

            if (number >= 0)
            {
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
        }

        //Delete
        private void button1_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            
            OProduct oProduct = new OProduct();
            int id = oProduct.delete(eProduct);
            if (id != 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please Enter Id");
            }
        }
        //Update
        private void button3_Click(object sender, EventArgs e)
        {

            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;
            eProduct.Address = txtadd.Text;
            eProduct.Phone = txtphn.Text;

            OProduct oProduct = new OProduct();
            int id = oProduct.update(eProduct);
            if (id != 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Please Enter Id");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();

        }
        //Search
        private void Search_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.Search(txtSearch.Text);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


        }
        //Show
        private void button4_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }
    }
}
