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
    public partial class option : Form
    {
        public static string status;
        public option()
        {
            InitializeComponent();
        }

        private void option_Load(object sender, EventArgs e)
        {

            if (dbclass.user == "user")
            {
                button3.Enabled = false;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fac = new Form3();
            this.Hide();
            fac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 stud = new Form1();
            this.Hide();
            stud.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
