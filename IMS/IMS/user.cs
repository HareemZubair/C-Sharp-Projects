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
    public partial class user : Form
    {
        clsdatabase obj = new clsdatabase();

        string query;

        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            
            query = "select * from tbluser";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "uname", "uname");
        }
        private void ClearBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbluser where uname='" + comboBox1.SelectedValue + "'";
            obj.bindtoCombo(query, comboBox2, "ustatus");
            obj.bindTextBox(query, textBox1, "uid");
            obj.bindTextBox(query, textBox2, "upass");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                user_Load(sender, e);
            }
            else
            {
                query = "insert into tbluser values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                ClearBoxes();
                user_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                user_Load(sender, e);
            }
            else
            {
                query = "update tbluser set ustatus='" + comboBox2.Text + "',uid='" + textBox1.Text + "',upass='" + textBox2.Text + "' where uname='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                user_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                user_Load(sender, e);
            }
            else
            {
                query = "delete from tbluser where uname='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Deleted Successfully");
                ClearBoxes();
                user_Load(sender, e);
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}