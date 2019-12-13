using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result
{
    public partial class frmresult : Form
    {
        int one, two, three, four, five, six, total = 600, obt;
        float per;
        string name, fname, ep, seat, sem, gp;


        public frmresult()
        {
            InitializeComponent();
        }

        private void frmresult_Load(object sender, EventArgs e)
        {
            txttotalmarks.Text = total.ToString();
            rbtnregular.AutoCheck = true;
            rbtnrepeater.AutoCheck = true;
            rbtnimprover.AutoCheck = true;
            chkasim.AutoCheck = true;
            chkbd.AutoCheck = true;
            chkhussain.AutoCheck = true;
            chkkj.AutoCheck = true;
            chknadeem.AutoCheck = true;
        }

        private void cboselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboselect.SelectedItem == "Semester 1")
            {
                lblsubone.Text = "ICS";
                lblsubtwo.Text = "ISE";
                lblsubthree.Text = "CLD";
                lblfour.Text = "Islamiat";
                lblsubfive.Text = "Calculus 1";
                lblsubsix.Text = "English";
            }
            else if (cboselect.SelectedItem=="Semester 2")
            {
                lblsubone.Text = "Business Com";
                lblsubtwo.Text = "Calculus 2";
                lblsubthree.Text = "Urdu";
                lblfour.Text = "OOP";
                lblsubfive.Text = "Pak.Studies";
                lblsubsix.Text = "Linear Algebra";
            }
            else if (cboselect.SelectedItem=="Semester 3")
            {
                lblsubone.Text = "Relational Database";
                lblsubtwo.Text = "Statistics and Probability";
                lblsubthree.Text = "Data structure";
                lblfour.Text = "Software Development";
                lblsubfive.Text = "Automata theory";
                lblsubsix.Text = "Diff.Equations";
            }
            else if (cboselect.SelectedItem=="Semester 4")
            {
                lblsubone.Text = "Assembly Language";
                lblsubtwo.Text = "Operating System";
                lblsubthree.Text = "Business Economics";
                lblfour.Text = "Numerical Anaysis";
                lblsubfive.Text = "JAVA";
                lblsubsix.Text = "Business com 2";
            }
            else if (cboselect.SelectedItem=="Semester 5")
            {
                lblsubone.Text = "Compiler Constrt";
                lblsubtwo.Text = "Computer Architec";
                lblsubthree.Text = "Org.Behaviour";
                lblfour.Text = "OOP using Java";
                lblsubfive.Text = "Advance Java";
                lblsubsix.Text = "SE part 2";
            }
            else if (cboselect.SelectedItem=="Semester 6")
            {
                lblsubone.Text = "Networking and data";
                lblsubtwo.Text = "Focus course 1";
                lblsubthree.Text = "internet Programming";
                lblfour.Text = "SPM";
                lblsubfive.Text = "Marketing Manag";
                lblsubsix.Text = "Project 1";
            }
            else if (cboselect.SelectedItem=="Semester 7")
            {
                lblsubone.Text = "Distributed comp";
                lblsubtwo.Text = "Comp.Accounting";
                lblsubthree.Text = "Focus course 2";
                lblfour.Text = "Software project";
                lblsubfive.Text = "Document skill";
                lblsubsix.Text = "SPM";
            }
            else
            {
                lblsubone.Text = "Psychology";
                lblsubtwo.Text = "Software testing";
                lblsubthree.Text = "focus course 3";
                lblfour.Text = "Project 2";
                lblsubfive.Text = "Project 3";
                lblsubsix.Text = "Final Project";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            name = txtname.Text.ToString();
            fname = txtfathrname.Text.ToString();
            ep = txtep.Text.ToString();
            seat = txtseat.Text.ToString();
            sem = cboselect.SelectedItem.ToString();

            one = int.Parse(txtsubone.Text);
            two = int.Parse(txtsub2.Text);
            three = int.Parse(txtsub3.Text);
            four = int.Parse(txtsub4.Text);
            five = int.Parse(txtsub5.Text);
            six = int.Parse(txtsub6.Text);

            obt = one + two + three + four + five + six;
            txtobt.Text = obt.ToString();

            per = (float)obt / total * 100;
            txtper.Text = per.ToString();

            if (one >= 50 && two >= 50 && three >= 50 && four >= 60 && five >= 50 && six >= 50)
            {
                txtgp.ForeColor = Color.Green;
                if (per >= 80)
                {
                    gp = "A+";

                }
                else if (per >= 70)
                {
                    gp = "A";
                    
                }
                else if (per >= 60)
                {
                    gp = "B";

                }
                else if (per >= 50)
                {
                    gp = "C";

                }
                else
                {
                    gp = "Failed";

                }
            }
            else
            {
                txtgp.ForeColor = Color.Red;
                gp = "Failed";
            }
            txtgp.Text = gp.ToString();


            if (one >= 50)
            {
                lstshow.Items.Add("Pass in "+ lblsubone.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in "+lblsubone.Text);

            }
            if (two >= 50)
            {
                lstshow.Items.Add("Pass in "+lblsubtwo.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in "+lblsubtwo.Text);
            }
            if (three >= 50)
            {
                lstshow.Items.Add("Pass in "+lblsubthree.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in "+lblsubthree.Text);
            }
            if (four >= 50)
            {
                lstshow.Items.Add("Pass in "+lblfour.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in "+lblfour.Text);
            }
            if (five>=50)
            {
                lstshow.Items.Add("Pass in " + lblsubfive.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in " + lblsubfive.Text);
            }
            if (six>=50)
            {
                lstshow.Items.Add("Pass in " + lblsubsix.Text);
            }
            else
            {
                lstshow.Items.Add("Fail in " + lblsubsix.Text);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtname.Focus();
            txtfathrname.Text = "";
            txtfathrname.Focus();
            txtep.Text = "";
            txtep.Focus();
            txtseat.Text = "";
            txtseat.Focus();
            txtsubone.Text = "";
            txtsubone.Focus();
            txtsub2.Text = "";
            txtsub2.Focus();
            txtsub3.Text = "";
            txtsub3.Focus();
            txtsub4.Text = "";
            txtsub4.Focus();
            txtsub5.Text = "";
            txtsub5.Focus();
            txtsub6.Text = "";
            txtsub6.Focus();
            txtobt.Text = "";
            txtobt.Focus();
            txtper.Text = "";
            txtper.Focus();
            txtgp.Text = "";
            txtgp.Focus();
            rbtnregular.Checked = false;
            rbtnrepeater.Checked = false;
            rbtnimprover.Checked = false;
            chkasim.AutoCheck = false;
            chkbd.AutoCheck = false;
            chkhussain.AutoCheck = false;
            chkkj.AutoCheck = false;
            chknadeem.AutoCheck = false;
            lstshow.Items.Clear();
            cboselect.SelectedItem = null;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


       

    }
}
