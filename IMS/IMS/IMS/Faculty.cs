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
    public partial class Faculty : Form
    {
        clsdatabase obj = new clsdatabase();
        string query;

        public Faculty()
        {
            InitializeComponent();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            query = "Select * from tblfaculty";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, name, "fname", "fid");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearboxes();
            query = "Select * from tblfaculty";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, name, "fname", "fid");
        }
        public void clearboxes()
        {
            name.Text = "";
            fname.Text = "";
            doby.Text = "";
            dobm.Text = "";
            dobd.Text = "";
            contact.Text = "";
            email.Text = "";
            address.Text = "";
            qualification.Text = "";
            experiance.Text = "";
            jd.Text = "";
            jm.Text = "";
            jy.Text = "";
            sub.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || fname.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || contact.Text == "" || email.Text == "" || address.Text == "" || qualification.Text == "" || experiance.Text == "" || sub.Text == "" || jy.Text == "" || jm.Text == "" || jd.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Faculty_Load(sender, e);
            }
            else
            {
                query = "insert into tblfaculty values('" + name.Text + "','" + fname.Text + "','" + doby.Text + "','" + dobm.Text + "','" + dobd.Text + "','" + contact.Text + "','" + email.Text + "','" + qualification.Text + "','" + experiance.Text + "','" + sub.Text + "','" + jy.Text + "','" + jm.Text + "','" + jd.Text + "','" + email.Text + "','" + address.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                Faculty_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || fname.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || contact.Text == "" || email.Text == "" || address.Text == "" || qualification.Text == "" || experiance.Text == "" || sub.Text == "" || jy.Text == "" || jm.Text == "" || jd.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Faculty_Load(sender, e);
            }
            else
            {
                query = "update tblfaculty set ffname='" + fname.Text + "',fdoby='" + doby.Text + "',fdobm='" + dobm.Text + "' ,fdobd='" + dobd.Text + "' ,fcontact='" + contact.Text + "',feadd='" + email.Text + "',fadd='" + address.Text + "',fquali='" + qualification.Text + "',fexper='" + experiance.Text + "',fjy='" + jy.Text + "',fjm='" + jm.Text + "',fjd='" + jd.Text + "',fsubject='" + sub.Text + "'  where fname='" + name.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                clearboxes();
                Faculty_Load(sender, e);
            }
        }
        private void name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tblfaculty where fid='" + name.SelectedValue + "'";

            obj.bindTextBox(query, fname, "ffname");
            obj.bindCombobox2(query, doby, "fdoby");
            obj.bindCombobox2(query, dobm, "fdobm");
            obj.bindCombobox2(query, dobd, "fdobd");
            obj.bindTextBox(query, contact, "fcontact");
            obj.bindTextBox(query, email, "feadd");
            obj.bindTextBox(query, address, "fadd");
            obj.bindCombobox2(query, qualification, "fquali");
            obj.bindCombobox2(query, experiance, "fexper");
            obj.bindGrid(query, dataGridView1);
            obj.bindCombobox2(query, jy, "fjy");
            obj.bindCombobox2(query, jm, "fjm");
            obj.bindCombobox2(query, jd, "fjd");
            obj.bindCombobox2(query, sub, "fsubject");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || fname.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || contact.Text == "" || email.Text == "" || address.Text == "" || qualification.Text == "" || experiance.Text == "" || sub.Text == "" || jy.Text == "" || jm.Text == "" || jd.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Faculty_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tblfaculty where fid='" + name.SelectedValue + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    clearboxes();
                    Faculty_Load(sender, e);
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

        private void button6_Click(object sender, EventArgs e)
        {
            salfa sf = new salfa();
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            scheduling sch = new scheduling();
            sch.Show();
        }
    }
}
