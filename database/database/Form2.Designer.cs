﻿namespace database
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mon = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.feem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lumpsumpaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lumpsum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mfee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.monp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.afeep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.afee = new System.Windows.Forms.TextBox();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.recid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mon
            // 
            this.mon.FormattingEnabled = true;
            this.mon.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.mon.Location = new System.Drawing.Point(110, 162);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(100, 21);
            this.mon.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 66;
            // 
            // feem
            // 
            this.feem.FormattingEnabled = true;
            this.feem.Location = new System.Drawing.Point(387, 136);
            this.feem.Name = "feem";
            this.feem.Size = new System.Drawing.Size(100, 21);
            this.feem.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(390, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 64;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(522, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 23);
            this.button5.TabIndex = 63;
            this.button5.Text = "End";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(522, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 187);
            this.dataGridView1.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Pay Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Lumpsup Paid";
            // 
            // lumpsumpaid
            // 
            this.lumpsumpaid.Location = new System.Drawing.Point(110, 217);
            this.lumpsumpaid.Name = "lumpsumpaid";
            this.lumpsumpaid.Size = new System.Drawing.Size(100, 20);
            this.lumpsumpaid.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Lumpsup";
            // 
            // lumpsum
            // 
            this.lumpsum.Location = new System.Drawing.Point(387, 192);
            this.lumpsum.Name = "lumpsum";
            this.lumpsum.Size = new System.Drawing.Size(100, 20);
            this.lumpsum.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Monthaly Fee";
            // 
            // mfee
            // 
            this.mfee.Location = new System.Drawing.Point(110, 189);
            this.mfee.Name = "mfee";
            this.mfee.Size = new System.Drawing.Size(100, 20);
            this.mfee.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Monthaly Fee Paid";
            // 
            // monp
            // 
            this.monp.Location = new System.Drawing.Point(387, 164);
            this.monp.Name = "monp";
            this.monp.Size = new System.Drawing.Size(100, 20);
            this.monp.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fee Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Duration";
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(110, 136);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(27, 20);
            this.duration.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Admission fees Paid";
            // 
            // afeep
            // 
            this.afeep.Location = new System.Drawing.Point(387, 109);
            this.afeep.Name = "afeep";
            this.afeep.Size = new System.Drawing.Size(100, 20);
            this.afeep.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Admission fees";
            // 
            // afee
            // 
            this.afee.Location = new System.Drawing.Point(110, 109);
            this.afee.Name = "afee";
            this.afee.Size = new System.Drawing.Size(100, 20);
            this.afee.TabIndex = 43;
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(455, 72);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(0, 13);
            this.fnamelbl.TabIndex = 42;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(309, 72);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(0, 13);
            this.namelbl.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 21);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Student ID";
            // 
            // recid
            // 
            this.recid.AutoSize = true;
            this.recid.Location = new System.Drawing.Point(121, 72);
            this.recid.Name = "recid";
            this.recid.Size = new System.Drawing.Size(0, 13);
            this.recid.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Recipet ID  # ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 69;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(581, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 70;
            this.button6.Text = "Form3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mon);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.feem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lumpsumpaid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lumpsum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mfee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.monp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.afeep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afee);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recid);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox feem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lumpsumpaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lumpsum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mfee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox monp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox afeep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox afee;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label recid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}