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
    public partial class Time : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public Time()
        {
            InitializeComponent();
        }

        private void Time_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_time";
            obj.bindGrid(query, dataGridViewtime);
            obj.bindCombo(query, cbotime, "time", "tid");
        }
       

        private void cbotime_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select * from tbl_time where time='" + cbotime.SelectedValue + "'";
            obj.bindtoCombo(query, cboshift, "shift");
        }

        private void btntnew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        public void ClearBoxes()
        {
            cbotime.Text = "";
            cboshift.Text = "";
            cbotime.Focus();
        }

        private void btntadd_Click(object sender, EventArgs e)
        {
            if (cboshift.Text == "" || cbotime.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                Time_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_time values(" + cbotime.Text + "," + cboshift.Text + ")";
                obj.Manipulate(query, "Record Added");
                ClearBoxes();
                Time_Load(sender, e);
            }
        }

        private void btntupdate_Click(object sender, EventArgs e)
        {
            if (cboshift.Text == "" || cbotime.Text == "")
            {
                MessageBox.Show("Please Fill All the Required Information");
                Time_Load(sender, e);
            }
            else
            {
                query= "update tbl_time set shift='" + cboshift.Text + "', where time=" + cbotime.SelectedValue + "";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                Time_Load(sender, e);
            }
        }
    }
}
