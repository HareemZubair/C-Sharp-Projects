using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class Session : Form
    {
        public Session()
        {
            InitializeComponent();
        }
        dbclass obj = new dbclass();
        string query;
        public void ClearBoxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Focus();
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

        private void Session_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_session";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "Sessionid", "Sessionid");
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_session where Sessionid='" + comboBox1.SelectedValue + "'";
            obj.bindtoCombo(query, comboBox2, "sname");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Session_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_session values(" + comboBox1.Text + ",'" + comboBox2.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                ClearBoxes();
                Session_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Session_Load(sender, e);
            }
            else
            {
                query = "update tbl_session set sname='" + comboBox2.Text + "' where Sessionid='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                Session_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Session_Load(sender, e);
            }
            else
            {
                query = "delete from tbl_session where Sessionid='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Deleted Successfully");
                ClearBoxes();
                Session_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
