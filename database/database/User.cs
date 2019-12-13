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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        dbclass obj = new dbclass();
        string query;

        private void User_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_Login";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "user_name", "user_name");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void ClearBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                User_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_Login values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                ClearBoxes();
                User_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                User_Load(sender, e);
            }
            else
            {
                query = "update tbl_Login set user_status='" + comboBox2.Text + "',user_id='" + textBox1.Text + "',user_password='" + textBox2.Text + "' where user_name='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                User_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                User_Load(sender, e);
            }
            else
            {
                query = "delete from tbl_Login where user_name='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Deleted Successfully");
                ClearBoxes();
                User_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_Login where user_name='" + comboBox1.SelectedValue + "'";
            obj.bindtoCombo(query, comboBox2, "user_status");
            obj.bindTextBox(query, textBox1, "user_id");
            obj.bindTextBox(query, textBox2, "user_password");
        }
    }
}
