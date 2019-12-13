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

    public partial class user : Form
    {
        int a = 0, index=0;
                  int i=0;

        string[] id = new string[1000];
        string[] name = new string[1000];
        string[] pass = new string[1000];
        string[] phone = new string[1000];
        string[] deposite = new string[1000];
        string[] draw = new string[1000];
        int[] balance = new int[1000];
        string[] balance2 = new string[1000];
        public user(int index)

        {
            a = index;
            id = File.ReadAllLines("id");

            balance2 = File.ReadAllLines("balance");
            pass = File.ReadAllLines("password");
            deposite = File.ReadAllLines("deposite");
            draw = File.ReadAllLines("draw");


            InitializeComponent();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();

            label3.Hide();
            textBox3.Hide();
            textBox2.Hide();
            label2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            button7.Show();
            textBox2.Show();
            label2.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text="";
            textBox2.Show();

            button2.Hide();
            button3.Hide();
            button7.Hide();

            label2.Show();
            button6.Show();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Show();
            textBox3.Show();
            button5.Show();
            button6.Hide();
            textBox2.Show();
            label2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Pleae Enter Password");
            }
            else   if (textBox1.Text==pass[a])
            {
                MessageBox.Show("Verified!");
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Hide();
                label1.Hide();
                textBox1.Hide();
                
            }
            else
            {

                MessageBox.Show("Password Incorrect!");
                textBox1.Text = "";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {  if (textBox3.Text=="")
            {
                MessageBox.Show("Please Enter ID");

            }
             else if (!string.IsNullOrEmpty(textBox3.Text) &&
                 !Int32.TryParse(textBox3.Text, out i)
              )
            {
                MessageBox.Show("Enter Valid Customer ID!");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please Enter Amount");
          
            }

            else
            {


                index = Array.IndexOf(id, textBox3.Text);
                if (index==-1)
                {
                    MessageBox.Show("Customer Not Found");
                }
                else
                {
                  
                     double len = Double.Parse(balance2[index]);
                     len=len+Double.Parse(textBox2.Text);
                     balance2[index] = len.ToString();
                     File.WriteAllLines("balance", balance2);
                     MessageBox.Show("Transfered");
                
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")


            {
                MessageBox.Show("Please Enter Amount");

            }

           
            else   {


                int c = 0, d = 0;
                 c = Int32.Parse(textBox2.Text);
                 d = Int32.Parse(balance2[a]);
                   if (c >= d)
                {
                    MessageBox.Show("You Don't Have Enoungh Money To Draw");
                    textBox2.Text = "";
                }
                else 
                {
                    draw[a] = textBox2.Text;
                    balance[a] = Int32.Parse(balance2[a]);
                    balance[a] = balance[a] - (Int32.Parse(textBox2.Text));
                    balance2[a] = balance[a].ToString();
                    File.WriteAllLines("draw", draw);
                    File.WriteAllLines("balance", balance2);
                    MessageBox.Show("With Drawed");
                }

            }
           
            
           

           // b = Int16.Parse(balance2[a]);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (balance2[a] == "")
            {
                balance2[a] = "0";
            }
            if (textBox2.Text == "")
            {

                MessageBox.Show("Enter Amount");
            }
            else
            {
                button6.Hide();

                balance[a] = Int32.Parse(balance2[a]);
                deposite[a] = textBox2.Text;
                balance[a] += Int32.Parse(textBox2.Text);
                balance2[a] = balance[a].ToString();
                File.WriteAllLines("deposite", deposite);

                File.WriteAllLines("balance", balance2);
                MessageBox.Show("Deposited");
                textBox1.Text = "";

            }
            
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

    }
}
