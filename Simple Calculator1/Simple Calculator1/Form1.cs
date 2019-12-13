using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void disalbe()
        {
            txtShow.Enabled = false;
            btnC.Show();
            btnCE.Hide();
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnthree.Enabled = false;
            btnfour.Enabled = false;
            btnfive.Enabled = false;
            btnsix.Enabled = false;
            btnseven.Enabled = false;
            btneight.Enabled = false;
            btnnine.Enabled = false;
            btnadd.Enabled = false;
            btnminus.Enabled = false;
            btnmul.Enabled = false;
            btndiv.Enabled = false;
            btnequal.Enabled = false;
            btnzero.Enabled = false;
        }
        public void able()
        {
            txtShow.Enabled = true;
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "9";
        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you really want to exit?", "Exit", MessageBoxButtons.YesNoCancel);
            if (DR == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            disalbe();
        }

        private void btnon_Click(object sender, EventArgs e)
        {

        }
    }
}
