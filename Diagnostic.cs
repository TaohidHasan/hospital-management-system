using ClassLibrary1.Operation;
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
    public partial class Diagnostic : Form
    {
        public Diagnostic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OProduct oProduct = new OProduct();
            SqlDataAdapter sqlDataAdapter = oProduct.Test();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
