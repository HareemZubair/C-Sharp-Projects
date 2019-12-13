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
    public partial class Frmfeeinfo : Form
    {
        public Frmfeeinfo()
        {
            InitializeComponent();
        }
        clsDatabase obj = new clsDatabase();
        string query;
        int mp, lp;

        int id;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmfeeinfo_Load(object sender, EventArgs e)
        {
            //query = "select isnull(max(receipt_id),0)+1 as ID from TBL_FEE";
            //obj.IdGenrator(query, recid);

            id=Convert.ToInt32(obj.NewId("receipt_id", "TBL_FEE"));
            recid.Text = id.ToString();

            label13.Text = DateTime.Today.ToShortDateString();

            query = "SELECT     TBL_FEE.RECEIPT_ID, TBL_FEE.STUDID, tbl_Stud.name, tbl_Stud.fname, tbl_courses.cname, tbl_courses.cduration, TBL_FEE.FEE_MONTH, TBL_FEE.MONTH, TBL_FEE.ADM_FEE,  TBL_FEE.MONTHLY_FEE, TBL_FEE.MONTHLY_FEE_PAID, TBL_FEE.LUMPSUM, TBL_FEE.LUMPSUM_PAID, TBL_FEE.PAY_DATE FROM TBL_FEE INNER JOIN tbl_Stud ON TBL_FEE.STUDID = tbl_Stud.studid INNER JOIN tbl_courses ON tbl_Stud.cid = tbl_courses.cid";
            obj.bindGrid(query, dataGridView1);

            query = "select * from tbl_Stud";
            obj.bindCombo(query, comboBox1, "Studid", "Studid");

            for (int a = 1; a <= 12; a++)
            {
                feem.Items.Add(a);
            }


        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "SELECT tbl_Stud.studid, tbl_Stud.name, tbl_Stud.fname, tbl_courses.cname, tbl_courses.cduration, tbl_courses.ctfees, tbl_courses.cafees, tbl_courses.cmfees, tbl_courses.clumsum, tbl_session.sname FROM tbl_Stud INNER JOIN tbl_courses ON tbl_Stud.cid = tbl_courses.cid INNER JOIN tbl_session ON tbl_Stud.sessionid = tbl_session.Sessionid where tbl_Stud.studid=" + comboBox1.SelectedValue + "";
            obj.bindlabel(query,namelbl,"name");
            obj.bindlabel(query, fnamelbl, "fname");
            obj.bindTextBox(query, afee, "cafees");
            obj.bindTextBox(query, duration, "cduration");
            obj.bindTextBox(query, mfee, "cmfees");
            obj.bindTextBox(query, lumpsum, "clumsum");
            label14.Text = "Month";
            //query = "SELECT     TBL_FEE.RECEIPT_ID, TBL_FEE.STUDID, tbl_Stud.name, tbl_Stud.fname, tbl_courses.cname, tbl_courses.cduration, TBL_FEE.FEE_MONTH, TBL_FEE.MONTH, TBL_FEE.ADM_FEE,  TBL_FEE.MONTHLY_FEE, TBL_FEE.MONTHLY_FEE_PAID, TBL_FEE.LUMPSUM, TBL_FEE.LUMPSUM_PAID, TBL_FEE.PAY_DATE FROM TBL_FEE INNER JOIN tbl_Stud ON TBL_FEE.STUDID = tbl_Stud.studid INNER JOIN tbl_courses ON tbl_Stud.cid = tbl_courses.cid";

            //obj.bindlabel(query, recid, "RECEIPT_ID");

            //query = "select * from TBL_FEE WHERE STUDID = "+comboBox1.Text+"";

            
            obj.bindGrid(query, dataGridView1);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            namelbl.Text = "";
            fnamelbl.Text = "";

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    c.Text = "";
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (monp.Text == "")
            {
                mp = 0;
            }
            else
            {
                mp = Convert.ToInt32(monp.Text);
            }
            
            if (lumpsumpaid.Text == "")
            {
                lp = 0;
            }
            else
            {
                lp = Convert.ToInt32(lumpsumpaid.Text);
            }
            




            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || duration.Text == "" || mon.Text == "" ||lumpsum.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "" )
            {
                MessageBox.Show("Plz fill All Fields");
                Frmfeeinfo_Load(sender, e);
            }
            else
            {
                //" + recid.Text + "," + comboBox1.Text + ",'" + afee.Text + "','" + duration.Text + "','" + feem.Text + "','" + mon.Text + "','" + mfee.Text + "','" + monp.Text + "','" + lumpsum.Text + "','" + lumpsumpaid.Text + "','" + label13.Text + "'
                query = "insert into TBL_FEE values(" + id + "," + comboBox1.Text + "," + afee.Text + ",'" + duration.Text + "'," + feem.Text + ",'" + mon.Text + "'," + mfee.Text + "," + mp + "," + lumpsum.Text + "," + lp + ",'" + label13.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                Frmfeeinfo_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || afeep.Text == "" || duration.Text == "" || mon.Text == "" || monp.Text == "" || lumpsum.Text == "" || lumpsumpaid.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Frmfeeinfo_Load(sender, e);
            }
            else
            {
                query = "update TBL_FEE set STUDID=" + comboBox1.Text + ",ADM_FEE=" + afee.Text + ",DURATION=" + duration.Text + ",FEE_MONTH=" + feem.Text + " ,MONTH='" + mon.Text + "' ,MONTHLY_FEE=" + mfee.Text + ",MONTHLY_FEE_PAID=" + mp + "LUMPSUM=" + lumpsum.Text + ",LUMPSUM_PAID=" + lp + ",PAY_DATE='" + label13.Text + "'  where RECEIPT_ID='" + recid.Text+ "'";
                obj.Manipulate(query, "Record Updated Successfully");
                button1_Click(sender, e);
                Frmfeeinfo_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || afeep.Text == "" || duration.Text == "" || mon.Text == "" || monp.Text == "" || lumpsum.Text == "" || lumpsumpaid.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Frmfeeinfo_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from TBL_FEE where STUDID='" + comboBox1.Text + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    button1_Click(sender, e);
                    Frmfeeinfo_Load(sender, e);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure you want to exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                
            }


        }

        

     
    }
}
