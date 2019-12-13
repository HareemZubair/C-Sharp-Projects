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
    public partial class Student : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_stud";
            obj.bindGrid(query, dataGridViewstudent);
            obj.bindCombo(query, cboname, "sname", "sid");
        }

        private void cboname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        public void ClearBoxes()
        {
            cboname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtdob.Text = "";
            txtemail.Text = "";
            txtfname.Text = "";
            txtsession.Text = "";
            cboname.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(cboname.Text==""||txtfname.Text==""||txtdob.Text==""||txtemail.Text==""||txtcontact.Text==""||txtaddress.Text==""||txtsession.Text=="")
            {
                MessageBox.Show("Please Enter All the Required Data");
                Student_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_stud values('" + cboname.Text + "','" + txtfname.Text + "','" + txtdob.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtsession.Text + "')";
                obj.Manipulate(query, "Record Added");
                ClearBoxes();
                Student_Load(sender, e);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(cboname.Text==""||txtfname.Text==""||txtdob.Text==""||txtemail.Text==""||txtcontact.Text==""||txtaddress.Text==""||txtsession.Text=="")
            {
                MessageBox.Show("Please Enter All the Required Data");
                Student_Load(sender, e);
            }
            else
            {
                query = "update tbl_stud set sfname='" + txtfname.Text + "',sdob='" + txtdob.Text + "',semail='" + txtemail.Text + "',scontact='" + txtcontact.Text + "',saddress='" + txtaddress.Text + "',session='" + txtsession.Text + "'where sname'" + cboname.SelectedValue + "'";
                obj.Manipulate(query, "Record Updated");
                ClearBoxes();
                Student_Load(sender, e);
            }
        }

        

        
    }
}
