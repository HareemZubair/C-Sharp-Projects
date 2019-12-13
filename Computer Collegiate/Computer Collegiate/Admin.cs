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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          foreach(Form F in Application.OpenForms)
          {
              if(F is User)
              {
                  F.Activate();
                  return;
              }
          }
                User U = new User();
                U.MdiParent = this;
                U.Show();
            
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           foreach(Form F in Application.OpenForms)
           {
               if(F is Courses)
               {
                   F.Activate();
                   return;
               }
           }
                Courses C = new Courses();
                C.MdiParent = this;
                C.Show();
            
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
         foreach(Form F in Application.OpenForms)
         {
             if(F is Time)
             {
                 F.Activate();
                 return;
             }
         }
                Time T = new Time();
                T.MdiParent = this;
                T.Show();
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form F in Application.OpenForms)
            {
                if(F is Faculty)
                {
                    F.Activate();
                    return;
                }
            }
            Faculty Fa = new Faculty();
            Fa.MdiParent = this;
            Fa.Show();
        }

        private void personalInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form F in Application.OpenForms)
            {
                if(F is Student)
                {
                    F.Activate();
                    return;
                }
            }
            Student S = new Student();
            S.MdiParent = this;
            S.Show();
        }

    }
}
