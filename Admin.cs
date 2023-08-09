using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Doctor().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Patient().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Diagnostic().Show();
        }
    }
}
