using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        dbclass obj = new dbclass();

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool chk = obj.checkUser(txtUserId.Text, txtPassword.Text);

            if (chk == true)
            {
                MessageBox.Show("Valid ID or Password");

                obj.FindUser(txtUserId.Text, txtPassword.Text);

                option fm = new option();
                this.Hide();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password");
                ClearRecord();
            }
        }
        private void ClearRecord()
        {
            txtUserId.Text = "";
            txtPassword.Text = "";
            txtUserId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollegePics cp = new CollegePics();
            cp.Show();
        }
    }
}
