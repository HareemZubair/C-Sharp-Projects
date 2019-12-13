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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        dbclass obj = new dbclass();
        string query;

        private void Form3_Load(object sender, EventArgs e)
        {
            query = "Select * from tbl_faculty";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, name, "fname", "fid");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearboxes();
            query = "Select * from tbl_faculty";
            obj.bindGrid(query, dataGridView1);
            obj.bindCombo(query, name, "fname", "fid");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || fname.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || contact.Text == "" || email.Text == "" || address.Text == "" || qualification.Text == "" || experiance.Text == "" || sub.Text == "" || jy.Text == "" || jm.Text == "" || jd.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Form3_Load(sender, e);
            }
            else
            {
                query = "insert into tbl_faculty values('" + name.Text + "','" + fname.Text + "','" + doby.Text + "','" + dobm.Text + "','" + dobd.Text + "','" + contact.Text + "','" + email.Text + "','" + address.Text + "','" + qualification.Text + "','" + experiance.Text + "','" + jy.Text + "','" + jm.Text + "','" + jd.Text + "','" + sub.Text + "')";
                obj.Manipulate(query, "New Record Added Successfully");
                Form3_Load(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || fname.Text == "" || doby.Text == "" || dobm.Text == "" || dobd.Text == "" || contact.Text == "" || email.Text == "" || address.Text == "" || qualification.Text == "" || experiance.Text == "" || sub.Text == "" || jy.Text == "" || jm.Text == "" || jd.Text == "")
            {
                MessageBox.Show("Plz fill All Fields");
                Form3_Load(sender, e);
            }
            else
            {
                query = "update tbl_faculty set ffname='" + fname.Text + "',fdoby='" + doby.Text + "',fdobm='" + dobm.Text + "' ,fdobd='" + dobd.Text + "' ,fcontact='" + contact.Text + "',feadd='" + email.Text + "',fadd='" + address.Text + "',fquli='" + qualification.Text + "',fexper='" + experiance.Text + "',fjy='" + jy.Text + "',fjm='" + jm.Text + "',fjd='" + jd.Text + "',fsubject='" + sub.Text + "'  where fname='" + name.Text + "'";
                obj.Manipulate(query, "Record Updated Successfully");
                clearboxes();
                Form3_Load(sender, e);
            }
        }

        private void name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            query = "select * from tbl_faculty where fid='" + name.SelectedValue + "'";

            obj.bindTextBox(query, fname, "ffname");
            obj.bindCombobox2(query, doby, "fdoby");
            obj.bindCombobox2(query, dobm, "fdobm");
            obj.bindCombobox2(query, dobd, "fdobd");
            obj.bindTextBox(query, contact, "fcontact");
            obj.bindTextBox(query, email, "feadd");
            obj.bindTextBox(query, address, "fadd");
            obj.bindCombobox2(query, qualification, "fquli");
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
                Form3_Load(sender, e);
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are you sere you want to exit", "Exit", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    query = "delete from tbl_faculty where fid='" + name.SelectedValue + "'";
                    obj.Manipulate(query, "Record Deleted Successfully");
                    clearboxes();
                    Form3_Load(sender, e);
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

        private void button6_Click(object sender, EventArgs e)
        {
            User Us = new User();
            this.Hide();
            Us.Show();
        }
    }
}
