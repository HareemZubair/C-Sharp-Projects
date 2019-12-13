using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Corner
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
                //SqlConnection sq = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Techno City\Documents\ubitfood.mdf;Integrated Security=True;Connect Timeout=30");
                //SqlDataAdapter sd = new SqlDataAdapter("Select Count(*) From Login where UserName='" + txtname.Text + "'and Password='" + txtpass.Text + "'", sq);

                //DataTable dt = new DataTable();
                //sd.Fill(dt);
                //if (dt.Rows[0][0].ToString() == "1")
                //{
                //    this.Hide();
                //    order ss = new order();
                //    ss.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Enter correct username or Password");
                //}
                this.Hide();
                order ss = new order();
                ss.Show();
               
            }
        

        private void lblubit_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtname.Focus();
            txtpass.Text = "";
            txtpass.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
