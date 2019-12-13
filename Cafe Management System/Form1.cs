using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFood F = new frmFood();
            F.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtname.Focus();
            txtpassword.Text = "";
            txtpassword.Focus();
        }

    }
}
