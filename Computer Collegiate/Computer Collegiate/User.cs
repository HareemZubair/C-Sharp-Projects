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
    public partial class User : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_user";
            obj.bindGrid(query, dataGridViewuser);
            obj.bindCombo(query, cbouname, "user_name","user_name");       
        }
        private void cbouname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_user where user_name='" + cbouname.SelectedValue + "'";
            obj.bindtoCombo(query, cboustatus, "user_status");
            obj.bindTextBox(query, txtuuerid, "user_id");
            obj.bindTextBox(query, txtupass, "user_password");
        }
        public void ClearBoxes()
        {
            cbouname.Text = "";
            cboustatus.Text = "";
            txtupass.Text = "";
            txtuuerid.Text = "";
            cbouname.Focus();
        }

        private void btnunew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnuadd_Click(object sender, EventArgs e)
        {
            if (cbouname.Text=="" || cboustatus.Text=="" || txtuuerid.Text==""||txtupass.Text=="")
            {
                MessageBox.Show("Please Fill All the Required Information");
                User_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_user values('" + txtuuerid.Text + "','" + cbouname.Text + "','" + cboustatus.Text + "','" + txtupass.Text + "')";
                obj.Manipulate(query, "Record Added Successfully");
                ClearBoxes();
                User_Load(sender, e);
            }
        }

        private void btnuexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnuupdate_Click(object sender, EventArgs e)
        {
            if (cbouname.Text == "" || cboustatus.Text == "" || txtuuerid.Text == "" || txtupass.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                User_Load(sender, e);
            }
            else
            {
                query = "update tbl_user set user_status='" + cboustatus.Text + "',user_id='" + txtuuerid.Text + "',user_password='" + txtupass.Text + "' where user_name='" + cbouname.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                User_Load(sender, e);
            }
        }

        private void btnudelete_Click(object sender, EventArgs e)
        {
            if (cbouname.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                User_Load(sender, e);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do You really want to Delete?");
                if(dr==DialogResult.Yes)
                {
                    query = "delete from tbl_user where user_name='" + cbouname.Text + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    ClearBoxes();
                    User_Load(sender, e);
                }
            }
        }

       
    }
}
