using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Form1 : Form
    {
        clsdatabase obj = new clsdatabase();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool chk = obj.checkUser(txtid.Text, txtpass.Text);

            if (chk == true)
            {
                MessageBox.Show("Valid ID or Password");

                obj.FindUser(txtid.Text,txtpass.Text);

                main m = new main();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password");
                ClearRecord();
            }

        }
        private void ClearRecord()
        {
            txtid.Text = "";
            txtpass.Text = "";
            txtid.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearRecord();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
