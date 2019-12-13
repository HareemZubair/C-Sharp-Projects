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
    public partial class order : Form
    {
        
        public order()
        {
            InitializeComponent();
        }


        private void order_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            
            txtzin.Text = "0";
            txtmac.Text = "0";
            txtprawn.Text = "0";
            txtspag.Text = "0";
            txtbeef.Text = "0";
            txtcharges.Text = "100";
            txtchatniroll.Text = "0";
            txtchick.Text = "0";
            txtamountmeal.Text = "0";
            txtchick.Text = "0";
            txtchickroll.Text = "0";
            txtchow.Text = "0";
            txtgrill.Text = "0";
            txttax.Text = "150";
            txttotalamount.Text = "0";

            txtzin.Enabled = false;
            txtbeef.Enabled = false;
            txtchick.Enabled = false;
            txtspag.Enabled = false;
            txtspag.Enabled = false;
            txtchow.Enabled = false;
            txtprawn.Enabled = false;
            txtgrill.Enabled = false;
            txtchickroll.Enabled = false;
            txtchatniroll.Enabled = false;
            txtmac.Enabled = false;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtzin.Text = "0";
            txtmac.Text = "0";
            txtprawn.Text = "0";
            txtspag.Text = "0";
            txtbeef.Text = "0";
            txtcharges.Text = "100";
            txtchatniroll.Text = "0";
            txtchick.Text = "0";
            txtamountmeal.Text = "0";
            txtchick.Text = "0";
            txtchickroll.Text = "0";
            txtchow.Text = "0";
            txtgrill.Text = "0";
            txttax.Text = "150";
            txttotalamount.Text = "0";

            chkzinger.Checked = false;
            chkbeef.Checked = false;
            chkprawns.Checked = false;
            chkchatniroll.Checked = false;
            chkchicken.Checked = false;
            chkchickengrill.Checked = false;
            chkchickenroll.Checked = false;
            chkspeghetti.Checked = false;
            chkmacroni.Checked = false;
            chkchowmen.Checked = false;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkzinger_CheckedChanged(object sender, EventArgs e)
        {
            if(chkzinger.Checked==true)
            {
                txtzin.Enabled = true;
            }
            if(chkzinger.Checked==false)
            {
                txtzin.Enabled = false;
                txtzin.Text = "0";
            }
           
            
        }

        private void chkbeef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbeef.Checked == true)
            {
                txtbeef.Enabled = true;
            }
            if (chkbeef.Checked == false)
            {
                txtbeef.Enabled = false;
                txtbeef.Text = "0";
            }
        }

        private void chkchicken_CheckedChanged(object sender, EventArgs e)
        {
            if(chkchicken.Checked==true)
            {
                txtchick.Enabled = true;
            }
            if(chkchicken.Checked==false)
            {
                txtchick.Enabled = false;
                txtchick.Text = "0";
            }
        }

        private void chkspeghetti_CheckedChanged(object sender, EventArgs e)
        {
            if(chkspeghetti.Checked==true)
            {
                txtspag.Enabled = true;
            }
            if(chkspeghetti.Checked==false)
            {
                txtspag.Enabled = false;
                txtspag.Text = "0";
            }
        }

        private void chkmacroni_CheckedChanged(object sender, EventArgs e)
        {
            if(chkmacroni.Checked==true)
            {
                txtmac.Enabled = true;
            }
            if(chkmacroni.Checked==false)
            {
                txtmac.Enabled = false;
                txtmac.Text = "0";
            }
        }

        private void chkchowmen_CheckedChanged(object sender, EventArgs e)
        {
            if(chkchowmen.Checked==true)
            {
                txtchow.Enabled = true;
            }
            if(chkchowmen.Checked==false)
            {
                txtchow.Enabled = false;
                txtchow.Text = "0";
            }
        }

        private void chkprawns_CheckedChanged(object sender, EventArgs e)
        {
            if(chkprawns.Checked==true)
            {
                txtprawn.Enabled = true;
            }
            if(chkprawns.Checked==false)
            {
                txtprawn.Enabled = false;
                txtprawn.Text = "0";
            }
        }

        private void chkchickengrill_CheckedChanged(object sender, EventArgs e)
        {
            if(chkchickengrill.Checked==true)
            {
                txtgrill.Enabled = true;
            }
            if(chkchickengrill.Checked==false)
            {
                txtgrill.Enabled = false;
                txtgrill.Text = "0";
            }
        }

        private void chkchickenroll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkchickenroll.Checked==true)
            {
                txtchickroll.Enabled = true;
            }
            if(chkchickenroll.Checked==false)
            {
                txtchickroll.Enabled = false;
                txtchickroll.Text = "0";
            }
        }

        private void chkchatniroll_CheckedChanged(object sender, EventArgs e)
        {
            if(chkchatniroll.Checked==true)
            {
                txtchatniroll.Enabled = true;
            }
            if(chkchatniroll.Checked==false)
            {
                txtchatniroll.Enabled = false;
                txtchatniroll.Text = "0";
            }
        }

        private void txtzin_Click(object sender, EventArgs e)
        {
            txtzin.Text = "";
            txtzin.Focus();
        }

        private void txtbeef_Click(object sender, EventArgs e)
        {
            txtbeef.Text = "";
            txtbeef.Focus();
        }

        private void txtchick_Click(object sender, EventArgs e)
        {
            txtchick.Text = "";
            txtchick.Focus();
        }

        private void txtspag_Click(object sender, EventArgs e)
        {
            txtspag.Text = "";
            txtspag.Focus();
        }

        private void txtmac_Click(object sender, EventArgs e)
        {
            txtmac.Text = "";
            txtmac.Focus();
        }

        private void txtchow_Click(object sender, EventArgs e)
        {
            txtchow.Text = "";
            txtchow.Focus();
        }

        private void txtprawn_Click(object sender, EventArgs e)
        {
            txtprawn.Text = "";
            txtprawn.Focus();
        }

        private void txtgrill_Click(object sender, EventArgs e)
        {
            txtgrill.Text = "";
            txtgrill.Focus();
        }

        private void txtchickroll_Click(object sender, EventArgs e)
        {
            txtchickroll.Text = "";
            txtchickroll.Focus();
        }

        private void txtchatniroll_Click(object sender, EventArgs e)
        {
            txtchatniroll.Text = "";
            txtchatniroll.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtreciept.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Cut();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Notepad Text";
            save.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter Sw = new System.IO.StreamWriter(save.FileName))
                    Sw.WriteLine(rtxtreciept.Text);
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtreciept.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtxtreciept.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
        }

        private void btnrecpt_Click(object sender, EventArgs e)
        {
            rtxtreciept.Clear();
            rtxtreciept.AppendText(Environment.NewLine);
            rtxtreciept.AppendText(" \t\t\t " + "Food Corner" + Environment.NewLine);
            rtxtreciept.AppendText("------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText("Zinger Burger\t\t" + txtzin.Text + Environment.NewLine);
            rtxtreciept.AppendText("Beef Burger\t\t" + txtbeef.Text + Environment.NewLine);
            rtxtreciept.AppendText("Chicken Burger\t\t" + txtchick.Text + Environment.NewLine);
            rtxtreciept.AppendText("Spaghetti\t\t" + txtspag.Text + Environment.NewLine);
            rtxtreciept.AppendText("Macroni\t\t" + txtmac.Text + Environment.NewLine);
            rtxtreciept.AppendText("Chowmen\t\t" + txtchow.Text + Environment.NewLine);
            rtxtreciept.AppendText("Prawns\t\t" + txtprawn.Text + Environment.NewLine);
            rtxtreciept.AppendText("Chicken Grill\t\t" + txtgrill.Text + Environment.NewLine);
            rtxtreciept.AppendText("Chicken Roll\t\t" + txtchickroll.Text + Environment.NewLine);
            rtxtreciept.AppendText("Chatni Roll\t\t" + txtchatniroll.Text + Environment.NewLine);
            rtxtreciept.AppendText("---------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText("Tax \t\t\t\t" + txttax.Text + Environment.NewLine);
            rtxtreciept.AppendText("Charges\t\t\t" + txtcharges.Text + Environment.NewLine);
            rtxtreciept.AppendText("Amount of Meal \t\t" + txtamountmeal.Text + Environment.NewLine);
            rtxtreciept.AppendText("Total Amount \t\t" + txttotalamount.Text + Environment.NewLine);
            rtxtreciept.AppendText("----------------------------------------" + Environment.NewLine);
            rtxtreciept.AppendText(lbltime.Text + "\t\t\t" + lbldate);
        }

        /*private void btnsubmit_Click(object sender, EventArgs e)
        {
            double zin, beef, chick, spag, macr, chow, praw, grill, chkroll, chtroll, tax = 150, cha = 100;
            zin = 180;
            beef = 150;
            chick = 120;
            spag = 180;
            macr = 180;
            chow = 150;
            praw = 250;
            grill = 300;
            chkroll = 80;
            chtroll = 70;

            double Z = Convert.ToDouble(txtzin.Text) * zin;
            double B = Convert.ToDouble(txtbeef.Text) * beef;
            double Chi = Convert.ToDouble(txtchick.Text) * chick;
            double S = Convert.ToDouble(txtspag.Text) * spag;
            double C = Convert.ToDouble(txtchow.Text) * chow;
            double M = Convert.ToDouble(txtmac.Text) * macr;
            double P = Convert.ToDouble(txtprawn.Text) * praw;
            double G = Convert.ToDouble(txtgrill.Text) * grill;
            double CR = Convert.ToDouble(txtchickroll.Text) * chkroll;
            double CTR = Convert.ToDouble(txtchatniroll.Text) * chtroll;

            food f = new food(Z, S, Chi, B, C, M, P, G, CR, CTR);

            double tm = Z + S + Chi + B + C + M + P + G + CR + CTR;
            txtamountmeal.Text = Convert.ToString(tm);
            txttotalamount.Text = Convert.ToString(tm + tax + cha);
        }*/

        private void btnsub_Click(object sender, EventArgs e)
        {
            double zin, beef, chick, spag, macr, chow, praw, grill, chkroll, chtroll, tax = 150, cha = 100;
            zin = 180;
            beef = 150;
            chick = 120;
            spag = 180;
            macr = 180;
            chow = 150;
            praw = 250;
            grill = 300;
            chkroll = 80;
            chtroll = 70;

            double Z = Convert.ToDouble(txtzin.Text) * zin;
            double B = Convert.ToDouble(txtbeef.Text) * beef;
            double Chi = Convert.ToDouble(txtchick.Text) * chick;
            double S = Convert.ToDouble(txtspag.Text) * spag;
            double C = Convert.ToDouble(txtchow.Text) * chow;
            double M = Convert.ToDouble(txtmac.Text) * macr;
            double P = Convert.ToDouble(txtprawn.Text) * praw;
            double G = Convert.ToDouble(txtgrill.Text) * grill;
            double CR = Convert.ToDouble(txtchickroll.Text) * chkroll;
            double CTR = Convert.ToDouble(txtchatniroll.Text) * chtroll;

            food f = new food(Z, S, Chi, B, C, M, P, G, CR, CTR);

            double tm = Z + S + Chi + B + C + M + P + G + CR + CTR;
            txtamountmeal.Text = Convert.ToString(tm);
            txttotalamount.Text = Convert.ToString(tm + tax + cha);

        }

       
    }
}
