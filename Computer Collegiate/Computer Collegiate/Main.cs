using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Collegiate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(clsdatabase.user == "user")
            {
                btnadmin.Enabled = false;
            }
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Admin A = new Admin();
            this.Hide();
            A.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void btnstudent_Click_1(object sender, EventArgs e)
        {

        }

        private void btnfaculty_Click(object sender, EventArgs e)
        {

        }

        
    }
}
