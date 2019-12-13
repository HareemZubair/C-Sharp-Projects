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
    public partial class Form1 : Form
    {
        dbclass obj = new dbclass();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            query = "select isnull(max(studid),0)+1 as ID from tbl_Stud";
            obj.IdGenrator(query, Idlbl);


            query = "SELECT     tbl_Stud.studid, tbl_Stud.name, tbl_Stud.fname, tbl_Stud.doby, tbl_Stud.dobm, tbl_Stud.dobd, tbl_Stud.email, tbl_Stud.contact, tbl_Stud.address, tbl_courses.cname, tbl_shift.ttime,tbl_session.sname, tbl_Stud.adddate FROM tbl_Stud INNER JOIN tbl_shift ON tbl_Stud.tid = tbl_shift.tid INNER JOIN tbl_session ON tbl_Stud.sessionid = tbl_session.Sessionid INNER JOIN tbl_courses ON tbl_Stud.cid = tbl_courses.cid";
            obj.bindGrid(query, dataGridView1);

            query = "select * from tbl_Stud";
            obj.bindCombo(query, comboBox1, "name", "name");
            label11.Text = DateTime.Today.ToShortDateString();

            query = "select * from tbl_courses";
            obj.bindCombo(query, comboBox2, "cname", "cname");

            query = "select * from tbl_shift";
            obj.bindCombo(query, comboBox4, "ttime", "ttime");

            query = "select * from tbl_session";
            obj.bindCombo(query, comboBox5, "sname", "sname");
        }

        
        public void clearboxes()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            doby.Text = "";
            dobm.Text = "";
            dobd.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearboxes();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Form1_Load(sender, e);
            }
            else
            {
                query = "select * from tbl_courses where cname='" + comboBox2.Text + "'";
                int id = Convert.ToInt32(obj.FindField(query, "cid"));

                query = "select * from tbl_shift where ttime='" + comboBox4.Text + "'";
                int tid = Convert.ToInt32(obj.FindField(query, "tid"));

                query = "select * from tbl_session where sname='" + comboBox5.Text + "'";
                int sid = Convert.ToInt32(obj.FindField(query, "sessionid"));

                query = "insert into tbl_Stud values(" + Idlbl.Text + ",'" + comboBox1.Text + "','" + textBox2.Text + "','" + doby.Text + "','" + dobm.Text + "','" + dobd.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + id + "," + tid + "," + sid + ",'" + label11.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                Form1_Load(sender, e);
                clearboxes();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are You Sure You Want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {

            query = "SELECT     tbl_Stud.studid, tbl_Stud.name, tbl_Stud.fname, tbl_Stud.doby, tbl_Stud.dobm, tbl_Stud.dobd, tbl_Stud.email, tbl_Stud.contact, tbl_Stud.address, tbl_courses.cname, tbl_shift.ttime,tbl_session.sname, tbl_Stud.adddate FROM tbl_Stud INNER JOIN tbl_shift ON tbl_Stud.tid = tbl_shift.tid INNER JOIN tbl_session ON tbl_Stud.sessionid = tbl_session.Sessionid INNER JOIN tbl_courses ON tbl_Stud.cid = tbl_courses.cid where name='" + comboBox1.SelectedValue + "'";

            obj.bindTextBox(query, textBox2, "fname");
            obj.bindTextBox(query, textBox3, "email");
            obj.bindCombobox2(query, doby, "doby");
            obj.bindCombobox2(query, dobm, "dobm");
            obj.bindCombobox2(query, dobd, "dobd");
            obj.bindTextBox(query, textBox4, "contact");
            obj.bindTextBox(query, textBox5, "address");
            obj.bindCombobox2(query, comboBox2, "cname");
            obj.bindCombobox2(query, comboBox4, "ttime");
            obj.bindCombobox2(query, comboBox5, "sname");
            obj.bindlabel(query, label11, "adddate");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
        }
    }

