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
    public partial class Salary : Form
    {
        dbclass obj = new dbclass();
        string query;
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            query = "select * from tblsal";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "subsal", "subsal");
        }
        public void ClearBoxes()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            comboBox1.Focus();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tblsal where subsal='" + comboBox1.SelectedValue + "'";
            obj.bindTextBox(query, textBox1, "sal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Salary_Load(sender, e);
            }
            else
            {
                query = "insert into tblsal values('" + comboBox1.Text + "','" + textBox1.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                ClearBoxes();
                Salary_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Salary_Load(sender, e);
            }
            else
            {
                query = "update tblsal set sal='" + textBox1.Text + "' where subsal='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                Salary_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Salary_Load(sender, e);
            }
            else
            {
                query = "delete from tblsal where subsal='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Deleted Successfully");
                ClearBoxes();
                Salary_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
    }
}
