using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myPro
{
    public partial class frmTime : Form
    {
        clsDatabase obj = new clsDatabase();
        string query;
        private void ClearBoxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            query = "select * from tbl_shift";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, comboBox1, "ttime", "tid");
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_shift where tid=" + comboBox1.SelectedValue + "";
            obj.bindCombobox2(query, comboBox2, "tshift");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            frmTime_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                frmTime_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_shift values('" + comboBox1.Text + "','" + comboBox2.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                frmTime_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "") 
            {
                MessageBox.Show("Plz fill All Fields");
                frmTime_Load(sender, e);
            }
            else
            {
                query = "update tbl_shift set tshift='" + comboBox2.Text +"'where ttime='" + comboBox1.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                ClearBoxes();
                frmTime_Load(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                frmTime_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tbl_shift where ttime='" + comboBox1.Text + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    ClearBoxes();
                    frmTime_Load(sender, e);
                }
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

    

  

    }
}
