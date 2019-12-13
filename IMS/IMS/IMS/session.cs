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
    public partial class session : Form
    {
        public session()
        {
            InitializeComponent();
        }
        clsdatabase obj = new clsdatabase();
        string query;

        private void session_Load(object sender, EventArgs e)
        {
            query = "select * from tblsession";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "sessionid", "sessionid");
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tblsession where sessionid='" + comboBox1.SelectedValue + "'";
            obj.bindtoCombo(query, comboBox2, "sname");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                session_Load(sender, e);
            }
            else
            {
                query = "insert into tblsession values(" + comboBox1.Text + ",'" + comboBox2.Text +  "')";
                obj.Manipulate(query, "New Record Added Successfully");
                ClearBoxes();
                session_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                session_Load(sender, e);
            }
            else
            {
                query = "update tblsession set sname='" + comboBox2.Text + "' where sessionid='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                session_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" )
            {
                MessageBox.Show("Plz fill All Fields");
                session_Load(sender, e);
            }
            else
            {
                query = "delete from tblsession where sessionid='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Deleted Successfully");
                ClearBoxes();
                session_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void ClearBoxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
