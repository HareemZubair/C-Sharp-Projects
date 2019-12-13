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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is user)
                {
                    F.Activate();
                    return;
                }
            }
            user us = new user();
            us.MdiParent = this;
            us.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if ( F is Faculty)
                {
                    F.Activate();
                    return;
                }
            }
            Faculty ff = new Faculty();
            ff.MdiParent = this;
            ff.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is student)
                {
                    F.Activate();
                    return;
                }
            }
            student ss = new student();
            ss.MdiParent = this;
            ss.Show();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is shift)
                {
                    F.Activate();
                    return;
                }
            }
            shift SS = new shift();
            SS.MdiParent = this;
            SS.Show();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is session)
                {
                    F.Activate();
                    return;
                }
            }
            session sss = new session();
            sss.MdiParent = this;
            sss.Show();
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is shift)
                {
                    F.Activate();
                    return;
                }
            }
            shift SS = new shift();
            SS.MdiParent = this;
            SS.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if(F is courses)
                {
                    F.Activate();
                    return;
                }
            }
            courses cc = new courses();
            cc.MdiParent = this;
            cc.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is fees)
                {
                    F.Activate();
                    return;
                }
            }
            fees fff = new fees();
            fff.MdiParent = this;
            fff.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is salary)
                {
                    F.Activate();
                    return;
                }
            }
            salary sa = new salary();
            sa.MdiParent = this;
            sa.Show();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is Faculty)
                {
                    F.Activate();
                    return;
                }
            }
            Faculty ff = new Faculty();
            ff.MdiParent = this;
            ff.Show();
        }

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is salfa)
                {
                    F.Activate();
                    return;
                }
            }
            salfa sf = new salfa();
            sf.MdiParent = this;
            sf.Show();
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is scheduling)
                {
                    F.Activate();
                    return;
                }
            }
            scheduling sh = new scheduling();
            sh.MdiParent = this;
            sh.Show();
        }

        private void personalInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is student)
                {
                    F.Activate();
                    return;
                }
            }
            student st = new student();
            st.MdiParent = this;
            st.Show();
        }

        private void feesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if (F is fees)
                {
                    F.Activate();
                    return;
                }
            }
            fees fff = new fees();
            fff.MdiParent = this;
            fff.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
