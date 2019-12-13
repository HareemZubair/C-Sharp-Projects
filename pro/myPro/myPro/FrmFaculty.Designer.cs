namespace myPro
{
    partial class FrmFaculty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doby = new System.Windows.Forms.ComboBox();
            this.dobm = new System.Windows.Forms.ComboBox();
            this.dobd = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qualification = new System.Windows.Forms.ComboBox();
            this.experiance = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.jd = new System.Windows.Forms.ComboBox();
            this.jm = new System.Windows.Forms.ComboBox();
            this.jy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(12, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 21);
            this.name.TabIndex = 1;
            this.name.SelectionChangeCommitted += new System.EventHandler(this.name_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(151, 29);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(133, 20);
            this.fname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Father Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Birrth";
            // 
            // doby
            // 
            this.doby.FormattingEnabled = true;
            this.doby.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.doby.Location = new System.Drawing.Point(291, 29);
            this.doby.Name = "doby";
            this.doby.Size = new System.Drawing.Size(64, 21);
            this.doby.TabIndex = 6;
            this.doby.SelectedIndexChanged += new System.EventHandler(this.doby_SelectedIndexChanged);
            // 
            // dobm
            // 
            this.dobm.FormattingEnabled = true;
            this.dobm.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apri",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.dobm.Location = new System.Drawing.Point(361, 29);
            this.dobm.Name = "dobm";
            this.dobm.Size = new System.Drawing.Size(40, 21);
            this.dobm.TabIndex = 7;
            // 
            // dobd
            // 
            this.dobd.FormattingEnabled = true;
            this.dobd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dobd.Location = new System.Drawing.Point(407, 29);
            this.dobd.Name = "dobd";
            this.dobd.Size = new System.Drawing.Size(40, 21);
            this.dobd.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(504, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 24);
            this.button5.TabIndex = 23;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Contact";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(15, 71);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(133, 20);
            this.contact.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(151, 71);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(133, 20);
            this.email.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(292, 71);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(155, 20);
            this.address.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Qualification";
            // 
            // qualification
            // 
            this.qualification.FormattingEnabled = true;
            this.qualification.Items.AddRange(new object[] {
            "8th",
            "9th",
            "Matric",
            "Inter",
            "Graduation",
            "Master"});
            this.qualification.Location = new System.Drawing.Point(12, 110);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(133, 21);
            this.qualification.TabIndex = 32;
            // 
            // experiance
            // 
            this.experiance.FormattingEnabled = true;
            this.experiance.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "4 Months",
            "5 Months",
            "6 Months",
            "7 Months",
            "8 Months",
            "9 Months",
            "10 Months",
            "11 Months",
            "1 Year",
            "2 Years",
            "3 Years",
            "4 Years",
            "5 Years"});
            this.experiance.Location = new System.Drawing.Point(151, 110);
            this.experiance.Name = "experiance";
            this.experiance.Size = new System.Drawing.Size(133, 21);
            this.experiance.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Experiance";
            // 
            // sub
            // 
            this.sub.FormattingEnabled = true;
            this.sub.Items.AddRange(new object[] {
            "Adobe Photoshop",
            "C#",
            "Visual Basic",
            "Androaid",
            "Html & Css",
            "Server Side Script",
            "Clint Side Script",
            "Wordpress",
            "Ms Office",
            "AutoCAD 3D",
            "AutoDesk MAYA",
            "Inpage",
            "A+ Hardware",
            "Networking",
            "Freelancer"});
            this.sub.Location = new System.Drawing.Point(12, 155);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(133, 21);
            this.sub.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Special Subject";
            // 
            // jd
            // 
            this.jd.FormattingEnabled = true;
            this.jd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.jd.Location = new System.Drawing.Point(409, 110);
            this.jd.Name = "jd";
            this.jd.Size = new System.Drawing.Size(40, 21);
            this.jd.TabIndex = 40;
            // 
            // jm
            // 
            this.jm.FormattingEnabled = true;
            this.jm.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apri",
            "May",
            "June",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.jm.Location = new System.Drawing.Point(363, 110);
            this.jm.Name = "jm";
            this.jm.Size = new System.Drawing.Size(40, 21);
            this.jm.TabIndex = 39;
            // 
            // jy
            // 
            this.jy.FormattingEnabled = true;
            this.jy.Items.AddRange(new object[] {
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.jy.Location = new System.Drawing.Point(293, 110);
            this.jy.Name = "jy";
            this.jy.Size = new System.Drawing.Size(64, 21);
            this.jy.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Join Date";
            // 
            // FrmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 379);
            this.ControlBox = false;
            this.Controls.Add(this.jd);
            this.Controls.Add(this.jm);
            this.Controls.Add(this.jy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.experiance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dobd);
            this.Controls.Add(this.dobm);
            this.Controls.Add(this.doby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.FrmFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doby;
        private System.Windows.Forms.ComboBox dobm;
        private System.Windows.Forms.ComboBox dobd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox qualification;
        private System.Windows.Forms.ComboBox experiance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox jd;
        private System.Windows.Forms.ComboBox jm;
        private System.Windows.Forms.ComboBox jy;
        private System.Windows.Forms.Label label10;
    }
}