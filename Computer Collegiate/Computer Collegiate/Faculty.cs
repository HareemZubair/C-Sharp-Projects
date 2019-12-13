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
    public partial class Faculty : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_faculty";
            obj.bindGrid(query, dataGridViewfaculty);
            obj.bindCombo(query, cboname,"fname","fid"); 
        }

        private void cboname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void ClearBoxes()
        {
            cboname.Text = "";
            txtaddress.Text = "";
            txtcontact.Text = "";
            txtdob.Text = "";
            txtemail.Text = "";
            txtexper.Text = "";
            txtfname.Text = "";
            txtjoiningdate.Text = "";
            txtqualification.Text = "";
            txtsubject.Text = "";
            cboname.Focus();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(cboname.Text==""||txtfname.Text==""||txtdob.Text==""||txtcontact.Text==""||txtaddress.Text==""||txtemail.Text==""||txtqualification.Text==""||txtexper.Text==""||txtjoiningdate.Text==""||txtsubject.Text=="")
            {
                MessageBox.Show("Please Enter All Required Data");
                Faculty_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_faculty values('" + cboname.Text + "','" + txtfname.Text + "','" + txtdob.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtqualification.Text + "','" + txtexper.Text + "','" + txtjoiningdate.Text + "','" + txtsubject.Text + "')";
                obj.Manipulate(query, "Record Added");
                ClearBoxes();
                Faculty_Load(sender, e);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cboname.Text == "" || txtfname.Text == "" || txtdob.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtemail.Text == "" || txtqualification.Text == "" || txtexper.Text == "" || txtjoiningdate.Text == "" || txtsubject.Text == "")
            {
                MessageBox.Show("Please Enter All Required Data");
                Faculty_Load(sender, e);
            }
            else
            {
                query = "update tbl_faculty set ffname='" + txtfname.Text + "',fdob='" + txtdob.Text + "',fcontact='" + txtcontact.Text + "',faddress='" + txtaddress.Text + "',femail='" + txtemail.Text + "',fqualification='" + txtqualification.Text + "',fexperience='" + txtexper.Text + "',fjd='" + txtjoiningdate.Text + "',fsub='" + txtsubject.Text + "'where fname='" + cboname.SelectedValue + "'";
                obj.Manipulate(query, "Updated successfully");
                ClearBoxes();
                Faculty_Load(sender, e);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

       
    }
}
