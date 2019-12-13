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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            if (dbclass.user == "user")
            {
                adminToolStripMenuItem.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if( F is User)
                {
                    F.Activate();
                    return;
                }
            }
            User us = new User();
            us.MdiParent = this;
            us.Show();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if ( F is Time)
                {
                    F.Activate();
                    return;
                }
            }
            Time t = new Time();
            t.MdiParent = this;
            t.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if(F is Courses)
                {
                    F.Activate();
                    return;
                }
            }
            Courses Co = new Courses();
            Co.MdiParent = this;
            Co.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if(F is Salary)
                {
                    F.Activate();
                    return;
                }
            }
            Salary sa = new Salary();
            sa.MdiParent = this;
            sa.Show();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form F in Application.OpenForms)
            {
                if(F is Session)
                {
                    F.Activate();
                    return;
                }
            }
            Session ss = new Session();
            ss.MdiParent = this;
            ss.Show();
        }

        private void personalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form  F in Application.OpenForms)
            {
                if(F is Form1)
                {
                    F.Activate();
                    return;
                }
            }
            Form1 stud = new Form1();
            stud.MdiParent = this;
            stud.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach ( Form F in Application.OpenForms)
            {
                if ( F is Form2)
                {
                    F.Activate();
                    return;
                }
            }
            Form2 fee = new Form2();
            fee.MdiParent = this;
            fee.Show();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach ( Form F in Application.OpenForms)
            {
                if(F is Form3)
                {
                    F.Activate();
                    return;
                }
            }
            Form3 fac = new Form3();
            fac.MdiParent = this;
            fac.Show();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach ( Form F in Application.OpenForms)
            {
                if(F is Salary)
                {
                    F.Activate();
                    return;
                }
            }
            Salary sal = new Salary();
            sal.MdiParent = this;
            sal.Show();
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach ( Form F in Application.OpenForms)
            {
                if(F is Main)
                {
                    F.Activate();
                    return;
                }
            }
            Main m = new Main();
            m.MdiParent = this;
            m.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                Main fa = new Main();
                fa.Show();
            }
        }
    }
}
