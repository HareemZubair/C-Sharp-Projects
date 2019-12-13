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
    public partial class Courses : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public Courses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_courses";
            obj.bindGrid(query, dataGridViewcourse);
            obj.bindCombo(query, cbocname, "cname", "cid");
        }
        private void cbocname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_courses where cname='" + cbocname.SelectedValue + "'";
            obj.bindTextBox(query, txtadfee,"cafee");
            obj.bindTextBox(query, txtlumpsumfee,"clumsum");
            obj.bindTextBox(query, txtmnthlyfee, "cmfee");
            obj.bindTextBox(query, txttfee, "ctfee");
        }

        private void btncnew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        public void ClearBoxes()
        {
            cbocname.Text = "";
            txtadfee.Text = "";
            txtlumpsumfee.Text = "";
            txtmnthlyfee.Text = "";
            txttfee.Text = "";
            cbocname.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(cbocname.Text==""||txtadfee.Text==""||txtlumpsumfee.Text==""||txtmnthlyfee.Text==""||txttfee.Text=="")
            {
                MessageBox.Show("Please Fill All the required Information");
                Courses_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_courses values('" + cbocname.Text + "','" + txtadfee.Text + "','" + txtmnthlyfee.Text + "','" + txtlumpsumfee.Text + "','" + txttfee.Text + "')";
                obj.Manipulate(query, "Record Inserted");
                ClearBoxes();
                Courses_Load(sender, e);
            }
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            if (cbocname.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                Courses_Load(sender, e);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do You really want to Delete?");
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tbl_courses where cname='" + cbocname.Text + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    ClearBoxes();
                    Courses_Load(sender, e);
                }
            }
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            if (cbocname.Text == "" || txtadfee.Text == "" || txtlumpsumfee.Text == "" || txtmnthlyfee.Text == "" || txttfee.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                Courses_Load(sender, e);
            }
            else
            {
                query = "update tbl_courses set cafee='" + txtadfee.Text +"',cmfee='"+txtmnthlyfee.Text+ "',clumsum='" + txtlumpsumfee.Text + "',ctfee='" + txttfee.Text + "' where cname='" + cbocname.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                Courses_Load(sender, e);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
