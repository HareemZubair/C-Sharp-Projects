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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form F in Application.OpenForms)
            {
                if(F is frmCourses)
                {
                    F.Activate();
                    return;
                }
            }
                     
            frmCourses fc = new frmCourses();
            fc.MdiParent = this;
            fc.Show();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is frmTime)
                {
                    F.Activate();
                    return;
                }
            }

            frmTime fc = new frmTime();
            fc.MdiParent = this;
            fc.Show();
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is frmUsers)
                {
                    F.Activate();
                    return;
                }
            }

            frmUsers fc = new frmUsers();
            fc.MdiParent = this;
            fc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Form1 fa = new Form1();
                fa.Show();
            }
        }

        private void pesonalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is FrmFaculty)
                {
                    F.Activate();
                    return;
                }
            }

            FrmFaculty fc = new FrmFaculty();
            fc.MdiParent = this;
            fc.Show();

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            if (clsDatabase.user == "user")
            {
                adminToolStripMenuItem.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
            }
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             foreach (Form F in Application.OpenForms)
            {
                if (F is FrmStud)
                {
                    F.Activate();
                    return;
                }
            }

            FrmStud fc = new FrmStud();
            fc.MdiParent = this;
            fc.Show();
        }

        private void feesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is Frmfeeinfo)
                {
                    F.Activate();
                    return;
                }
            }

            Frmfeeinfo fc = new Frmfeeinfo();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
