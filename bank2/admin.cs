using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bank2
{
    public partial class admin : Form
    {
        int counter = 0;
        string[] id = new string[1000];
        string[] name = new string[1000];
        string[] pass = new string[1000];
        string[] phone = new string[1000];
        string[] deposite = new string[1000];
        string[] draw = new string[1000];
        string[] balance = new string[1000];
        public admin()
        {
            InitializeComponent();
            counter = Convert.ToInt16(File.ReadAllText("counter"));

            name = File.ReadAllLines("name");
            pass = File.ReadAllLines("password");
            phone = File.ReadAllLines("phone");
            id = File.ReadAllLines("id");
            deposite = File.ReadAllLines("deposite");
            draw = File.ReadAllLines("draw");
            balance = File.ReadAllLines("balance");

            foreach (string item in id)
            {
                if (item == "")
                {
                }
                else
                {
                    listBox1.Items.Add(item);
                }
            }
            foreach (string item in name)
            {
                if (item == "")
                {
                }
                else
                {
                    listBox2.Items.Add(item);
                }
            }
            foreach (string item in pass)
            {
                if (item == "")
                {
                }
                else
                {
                    listBox3.Items.Add(item);
                }
            }
            foreach (string item in phone)
            {
                if (item == "")
                {
                }
                else
                {
                    listBox4.Items.Add(item);
                }
            }
            foreach (string item in draw)
            {
                if (item == "")
                {
                    listBox5.Items.Add("-");

                }
                else
                {
                    listBox5.Items.Add(item);
                }
            }
            foreach (string item in deposite)
            {
                if (item == "")
                {
                    listBox6.Items.Add("-");

                }
                else
                {
                    listBox6.Items.Add(item);
                }
            }
            foreach (string item in balance)
            {
                if (item == "")
                {
                    listBox7.Items.Add("-");

                }
                else
                {
                    listBox7.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double i = 0;
            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Name Is Too Short!");
            }
            else if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("Password Is Too Short!");
            }

            else if (!string.IsNullOrEmpty(textBox3.Text) &&
                 !double.TryParse(textBox3.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Phone Number!");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value from Gender!");
            }
            else
            {

                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();
                listBox7.Items.Clear();



                id[counter] = (counter + 1).ToString();
                name[counter] = textBox1.Text;
                pass[counter] = textBox2.Text;
                phone[counter] = textBox3.Text;

                foreach (string item in id)
                {
                    if (item == "")
                    {
                    }
                    else
                    {
                        listBox1.Items.Add(item);
                    }
                }
                foreach (string item in name)
                {
                    if (item == "")
                    {
                    }
                    else
                    {
                        listBox2.Items.Add(item);
                    }
                }
                foreach (string item in pass)
                {
                    if (item == "")
                    {
                    }
                    else
                    {
                        listBox3.Items.Add(item);
                    }
                }
                foreach (string item in phone)
                {
                    if (item == "")
                    {
                    }
                    else
                    {
                        listBox4.Items.Add(item);
                    }
                }
                foreach (string item in draw)
                {
                    if (item == "")
                    {
                        listBox5.Items.Add("-");

                    }
                    else
                    {
                        listBox5.Items.Add(item);
                    }
                }
                foreach (string item in deposite)
                {
                    if (item == "")
                    {
                        listBox6.Items.Add("-");
                    }
                    else
                    {
                        listBox6.Items.Add(item);
                    }
                }
                foreach (string item in balance)
                {
                    if (item == "")
                    {
                        listBox7.Items.Add("-");

                    }
                    else
                    {
                        listBox7.Items.Add(item);
                    }
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = " ";




                counter++;


                File.WriteAllText("counter", counter.ToString());
                File.WriteAllLines("name", name);
                File.WriteAllLines("password", pass);
                File.WriteAllLines("id", id);
                File.WriteAllLines("phone", phone);

            }
        }
    }
}
