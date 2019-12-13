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
    public partial class main : Form
    {
        public static string status;

        public main()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            this.Hide();
            s.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (clsdatabase.user == "user")
            {
                btnadmin.Enabled = false;
            }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void btnfaculty_Click(object sender, EventArgs e)
        {
            Faculty f = new Faculty();
            this.Hide();
            f.Show();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Checkout co = new Checkout();
            co.Show();
        }
    }
}
