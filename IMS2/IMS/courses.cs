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
    public partial class courses : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public courses()
        {
            InitializeComponent();
        }

        private void courses_Load(object sender, EventArgs e)
        {
            query = "select * from tblcourses";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "cname", "cname");
            comboBox2.Items.Add("1 month");
            comboBox2.Items.Add("2 months");
            comboBox2.Items.Add("3 months");
            comboBox2.Items.Add("4 months");
            comboBox2.Items.Add("5 months");
            comboBox2.Items.Add("6 months");
            comboBox2.Items.Add("7 months");
            comboBox2.Items.Add("8 months");
            comboBox2.Items.Add("9 months");
            comboBox2.Items.Add("10 months");
            comboBox2.Items.Add("11 months");
            comboBox2.Items.Add("1 Year");
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tblcourses where cname='" + comboBox1.SelectedValue + "'";

            obj.bindTextBox(query, textBox3, "ctfess");
            obj.bindTextBox(query, textBox4, "cadfee");
            obj.bindTextBox(query, textBox5, "cmfees");
            obj.bindTextBox(query, textBox6, "clumpsum");
            obj.bindGrid(query, dataGridView1);
            obj.bindCombobox2(query, comboBox2, "cduration");
            obj.bindCombobox2(query, comboBox3, "ctype");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                courses_Load(sender, e);
            }
            else
            {
                query = "insert into tblcourses values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                courses_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox3.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                courses_Load(sender, e);
            }
            else
            {
                query = "update tblcourses set cduration='" + comboBox2.Text + "',ctype='" + comboBox3.Text + "',ctfess='" + textBox3.Text + "',cadfee='" + textBox4.Text + "' ,cmfees='" + textBox5.Text + "' ,clumpsum='" + textBox6.Text + "'  where cname='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                courses_Load(sender, e);
            }
        }
        private void ClearBoxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                courses_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sure want to Delete", "Deleted", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tblcourses where cname='" + comboBox1.Text + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    ClearBoxes();
                    courses_Load(sender, e);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
