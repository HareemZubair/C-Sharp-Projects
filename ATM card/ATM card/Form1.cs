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

namespace ATM_card
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        int amount, loan, remaining, current, aftertax;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar == 16)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 16)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || txtamount.Text == "" || txtloan.Text == "" || textBox8.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Please Fill all the required Information!");
            }
            else
            {
                amount = int.Parse(txtamount.Text);
                loan = int.Parse(txtloan.Text);
                current = amount + loan;
                remaining = amount - loan;
                aftertax = remaining - 1000;
                textBox7.Text = current.ToString();
                textBox9.Text = txtloan.Text;
                textBox6.Text = aftertax.ToString();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    bmp = (Bitmap)Bitmap.FromFile(@"C:\Users\TC\Pictures\htm\arrow-left-right-hi");
            //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //    pictureBox1.Image = bmp;
            //}
            //catch (FileNotFoundException)
            //{
            //    MessageBox.Show("File Not Found Exception");
            //}
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = txtamount.Text;
            textBox9.Text = txtloan.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            txtamount.Text = "";
            txtloan.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Do you Really want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
                pictureBox1.Image = bmp;
            }
        }
    }
}
