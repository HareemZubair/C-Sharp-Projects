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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        clsdatabase obj = new clsdatabase();
        string query;


        private void student_Load(object sender, EventArgs e)
        {
            query = "select isnull(max(sid),0)+1 as ID from tblstud";
            obj.IdGenrator(query, Idlbl);


            query = "SELECT     tblstud.sid, tblstud.sname, tblstud.sfname, tblstud.sdoby, tblstud.sdobm, tblstud.sdobd, tblstud.semail, tblstud.saddress, tblcourses.cname, tbltime.ttime, tblsession.sname, tblstud.saddate FROM tblstud INNER JOIN tbltime ON tblstud.tid = tbltime.tid INNER JOIN tblsession ON tblstud.sessionid = tblsession.sessionid INNER JOIN tblcourses ON tblstud.cid = tblcourses.cid";
            obj.bindGrid(query, dataGridView1);

            query = "select * from tblstud";
            obj.bindCombo(query, comboBox1, "sname", "sname");
            label11.Text = DateTime.Today.ToShortDateString();

            query = "select * from tblcourses";
            obj.bindCombo(query, comboBox2, "cname", "cname");

            query = "select * from tbltime";
            obj.bindCombo(query, comboBox4, "ttime", "ttime");

            query = "select * from tblsession";
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
            textBox5.Text = "";

        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "SELECT  tblstud.sid, tblstud.sname, tblstud.sfname, tblstud.sdoby, tblstud.sdobm, tblstud.sdobd, tblstud.semail, tblstud.saddress, tblcourses.cname, tbltime.ttime,tblsession.sname, tblstud.saddate FROM tblstud INNER JOIN tbltime ON tblstud.tid = tbltime.tid INNER JOIN tblsession ON tblstud.sessionid = tblsession.sessionid INNER JOIN tblcourses ON tblstud.cid = tblcourses.cid where name='" + comboBox1.SelectedValue + "'";

            obj.bindTextBox(query, textBox2, "sfname");
            obj.bindTextBox(query, textBox3, "semail");
            obj.bindCombobox2(query, doby, "sdoby");
            obj.bindCombobox2(query, dobm, "sdobm");
            obj.bindCombobox2(query, dobd, "sdobd");
            obj.bindTextBox(query, textBox5, "saddress");
            obj.bindCombobox2(query, comboBox2, "cname");
            obj.bindCombobox2(query, comboBox4, "ttime");
            obj.bindCombobox2(query, comboBox5, "sname");
            obj.bindlabel(query, label11, "saddate");




        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                student_Load(sender, e);
            }
            else
            {
                query = "select * from tblcourses where cname='" + comboBox2.Text + "'";
                int id = Convert.ToInt32(obj.FindField(query, "cid"));

                query = "select * from tbltime where ttime=" + comboBox4.Text + "";
                int tid = Convert.ToInt32(obj.FindField(query, "tid"));

                query = "select * from tblsession where sname=" + comboBox5.Text + "";
                int sid = Convert.ToInt32(obj.FindField(query, "sessionid"));

                query = "insert into tblstud values(" + Idlbl.Text + ",'"+ comboBox1.Text + "','" + textBox2.Text + "'," + doby.Text + ",'" + dobm.Text + "'," + dobd.Text + ",'" + textBox3.Text + "','" + textBox5.Text + "'," + comboBox2.Text + "," + comboBox4.Text + "," + comboBox5.Text + ")";
                obj.Manipulate(query, "New Record Added Successfully");
                student_Load(sender, e);
                clearboxes();
               // + Idlbl.Text 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearboxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are You Sure want To Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fees fed = new fees();
            fed.Show();
        }
    }
}
