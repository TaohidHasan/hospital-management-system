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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.Patient();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;
            eProduct.Address = txtadd.Text;
            eProduct.Phone = txtphn.Text;


            OProduct oProduct = new OProduct();
            int number = oProduct.insertPatient(eProduct);

            if (number >= 0)
            {
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;

            OProduct oProduct = new OProduct();
            int id = oProduct.deletePatient(eProduct);
            if (id != 0)
            {
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please Enter Id");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.Id = txtId.Text;
            eProduct.Name = txtName.Text;
            eProduct.Address = txtadd.Text;
            eProduct.Phone = txtphn.Text;

            OProduct oProduct = new OProduct();
            int id = oProduct.updatePatient(eProduct);
            if (id != 0)
            {
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Please Enter Id");
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.SearchPatient(txtSearch.Text);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }
}
