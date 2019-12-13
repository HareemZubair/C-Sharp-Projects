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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        clsdatabase obj = new clsdatabase();
        string query;
        int mp, lp;

        int id;

        private void fees_Load(object sender, EventArgs e)
        {
            query = "select isnull(max(recieptid),0)+1 as ID from tblfees";
            obj.IdGenrator(query, recid);

            id = Convert.ToInt32(obj.NewId("recieptid", "tblfees"));
            recid.Text = id.ToString();

            label13.Text = DateTime.Today.ToShortDateString();

            query = "SELECT tblfees.recieptid, tblfees.sid, tblstud.sname, tblstud.sfname, tblcourses.cname, tblcourses.cduration, tblfees.feemonth, tblfees.month, tblfees.admfee,  tblfees.monfee, tblfees.monfeepaid, tblfees.lum, tblfees.lumpaid, tblfees.paydate FROM tblfees INNER JOIN tblstud ON tblfees.sid = tblstud.sid INNER JOIN tblcourses ON tblstud.cid = tblcourses.cid";
            obj.bindGrid(query, dataGridView1);

            query = "select * from tblstud";
            obj.bindCombo(query, comboBox1, "sid", "sid");

            for (int a = 1; a <= 12; a++)
            {
                feem.Items.Add(a);
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "SELECT tblstud.sid, tblstud.sname, tblstud.sfname, tblcourses.cname, tblcourses.cduration, tblcourses.ctfess, tblcourses.cadfee, tblcourses.cmfees, tblcourses.clumpsum, tblsession.sname FROM tblstud INNER JOIN tblcourses ON tblstud.cid = tblcourses.cid INNER JOIN tblsession ON tblstud.sessionid = tblsession.sessionid where tblstud.sid=" + comboBox1.SelectedValue + "";
            obj.bindlabel(query, namelbl, "sname");
            obj.bindlabel(query, fnamelbl, "sfname");
            obj.bindTextBox(query, afee, "cadfee");
            obj.bindTextBox(query, duration, "cduration");
            obj.bindTextBox(query, mfee, "cmfees");
            obj.bindTextBox(query, lumpsum, "clumpsum");
            label14.Text = "month";
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

            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || duration.Text == "" || mon.Text == "" || lumpsum.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "" ||monp.Text=="" || lumpsumpaid.Text==""||feem.Text==""||mfee.Text=="")
            {
                MessageBox.Show("Plz fill All Fields");
                fees_Load(sender, e);
            }
            else
            {
                //" + recid.Text + "," + comboBox1.Text + ",'" + afee.Text + "','" + duration.Text + "','" + feem.Text + "','" + mon.Text + "','" + mfee.Text + "','" + monp.Text + "','" + lumpsum.Text + "','" + lumpsumpaid.Text + "','" + label13.Text + "'
                query = "insert into tblfees values(" + recid + "," + comboBox1.Text + "," + afee.Text + "," + duration.Text + "," + feem.Text + ",'" + mon.Text + "'," + mfee.Text + "," + monp.Text + "," + lumpsum.Text + "," + lumpsumpaid.Text + ",'" + label13.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                fees_Load(sender, e);
            }



           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || afeep.Text == "" || duration.Text == "" || mon.Text == "" || monp.Text == "" || lumpsum.Text == "" || lumpsumpaid.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                fees_Load(sender, e);
            }
            else
            {
                query = "update tblfees set sid=" + comboBox1.Text + ",admfee=" + afee.Text + ",duration=" + duration.Text + ",feemonth=" + feem.Text + " ,month='" + mon.Text + "' ,monfee=" + mfee.Text + ",monfeepaid=" + monp.Text + "lum=" + lumpsum.Text + ",lumpaid=" + lumpsumpaid.Text + ",paydate='" + label13.Text + "'  where recieptid='" + recid.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                button1_Click(sender, e);
                fees_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (namelbl.Text == "" || fnamelbl.Text == "" || afee.Text == "" || afeep.Text == "" || duration.Text == "" || mon.Text == "" || monp.Text == "" || lumpsum.Text == "" || lumpsumpaid.Text == "" || feem.Text == "" || label13.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                fees_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure want to Delete", "Deleted", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tblfees where sid=" + comboBox1.Text + "";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    button1_Click(sender, e);
                    fees_Load(sender, e);
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

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
