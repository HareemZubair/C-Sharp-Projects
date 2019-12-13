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
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {

        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            lblOrder.Text = "";
            if (chkChicken.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkChicken.Text;
            }
            if (chkZinger.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkZinger.Text;
            }
            if(chkBeef.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkBeef.Text;
            }
            if(chkPrawn.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + "" + chkPrawn.Text;
            }
            if(chkEgg.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkEgg.Text;
            }
            if(chkSimple.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkSimple.Text;
            }
            if(chkPepsi.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkPepsi.Text;
            }
            if(chkFanta.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkFanta.Text;
            }
            if(chkCoca.Checked ==  true)
            {
                lblOrder.Text = lblOrder.Text + " " + chkCoca.Text;
            }
            if(chk7up.Checked == true)
            {
                lblOrder.Text = lblOrder.Text + " " + chk7up.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you really want to Exit?", "Exit", MessageBoxButtons.YesNoCancel);
            if(DR == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
