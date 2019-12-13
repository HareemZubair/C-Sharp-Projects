using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPro
{
    public partial class frmMain : Form
    {
        public static string status;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("User status=" + clsDatabase.user);

            if (clsDatabase.user == "user")
            {
                button3.Enabled = false;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdmin adm = new frmAdmin();
            this.Hide();
            adm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin adm = new frmAdmin();
            this.Hide();
            adm.Show();
        }

    
    }
}
