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
    public partial class Form1 : Form
    {
        string[] id = new string[1000];
       string[] name = new string[1000];
        string[] pass = new string[1000];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            name = File.ReadAllLines("name");
            id = File.ReadAllLines("id");

            pass = File.ReadAllLines("password");
            index = Array.IndexOf(id, textBox1.Text);



            if ((textBox1.Text == "admin") && (textBox1.Text == "admin"))
            {
                admin m = new admin();
                m.Show();
                this.Hide();
            }
            else if (index == -1)
            {
                MessageBox.Show("Incorrect User Name Or Password!");
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Plese Enter All Fields");
            }
            else if ((textBox1.Text == id[index]) && (textBox2.Text == pass[index]))
            {

                user u = new user(index);
                u.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name Or Password!");
            }
        }
    }
}
