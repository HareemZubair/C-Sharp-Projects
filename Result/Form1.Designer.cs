namespace Result
{
    partial class frmresult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmresult));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboselect = new System.Windows.Forms.ComboBox();
            this.rbtnimprover = new System.Windows.Forms.RadioButton();
            this.rbtnrepeater = new System.Windows.Forms.RadioButton();
            this.rbtnregular = new System.Windows.Forms.RadioButton();
            this.txtfathrname = new System.Windows.Forms.TextBox();
            this.txtseat = new System.Windows.Forms.TextBox();
            this.txtep = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblseatno = new System.Windows.Forms.Label();
            this.lblepno = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsub6 = new System.Windows.Forms.TextBox();
            this.txtsub5 = new System.Windows.Forms.TextBox();
            this.txtsub4 = new System.Windows.Forms.TextBox();
            this.txtsub3 = new System.Windows.Forms.TextBox();
            this.txtsub2 = new System.Windows.Forms.TextBox();
            this.txtsubone = new System.Windows.Forms.TextBox();
            this.lblsubsix = new System.Windows.Forms.Label();
            this.lblsubfive = new System.Windows.Forms.Label();
            this.lblfour = new System.Windows.Forms.Label();
            this.lblsubthree = new System.Windows.Forms.Label();
            this.lblsubtwo = new System.Windows.Forms.Label();
            this.lblsubone = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtobt = new System.Windows.Forms.TextBox();
            this.txtgp = new System.Windows.Forms.TextBox();
            this.txtper = new System.Windows.Forms.TextBox();
            this.txttotalmarks = new System.Windows.Forms.TextBox();
            this.lblobt = new System.Windows.Forms.Label();
            this.lblgp = new System.Windows.Forms.Label();
            this.lblper = new System.Windows.Forms.Label();
            this.lbltotalmarks = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lstshow = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkbd = new System.Windows.Forms.CheckBox();
            this.chkasim = new System.Windows.Forms.CheckBox();
            this.chknadeem = new System.Windows.Forms.CheckBox();
            this.chkhussain = new System.Windows.Forms.CheckBox();
            this.chkkj = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboselect);
            this.groupBox1.Controls.Add(this.rbtnimprover);
            this.groupBox1.Controls.Add(this.rbtnrepeater);
            this.groupBox1.Controls.Add(this.rbtnregular);
            this.groupBox1.Controls.Add(this.txtfathrname);
            this.groupBox1.Controls.Add(this.txtseat);
            this.groupBox1.Controls.Add(this.txtep);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblseatno);
            this.groupBox1.Controls.Add(this.lblepno);
            this.groupBox1.Controls.Add(this.lblfathername);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT IMFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboselect
            // 
            this.cboselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboselect.FormattingEnabled = true;
            this.cboselect.Items.AddRange(new object[] {
            "Semester 1",
            "Semester 2",
            "Semester 3",
            "Semester 4",
            "Semester 5",
            "Semester 6",
            "Semester 7",
            "Semester 8"});
            this.cboselect.Location = new System.Drawing.Point(434, 78);
            this.cboselect.Name = "cboselect";
            this.cboselect.Size = new System.Drawing.Size(181, 28);
            this.cboselect.TabIndex = 1;
            this.cboselect.Text = "Select";
            this.cboselect.SelectedIndexChanged += new System.EventHandler(this.cboselect_SelectedIndexChanged);
            // 
            // rbtnimprover
            // 
            this.rbtnimprover.AutoSize = true;
            this.rbtnimprover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnimprover.Location = new System.Drawing.Point(434, 152);
            this.rbtnimprover.Name = "rbtnimprover";
            this.rbtnimprover.Size = new System.Drawing.Size(102, 28);
            this.rbtnimprover.TabIndex = 11;
            this.rbtnimprover.TabStop = true;
            this.rbtnimprover.Text = "Improver";
            this.rbtnimprover.UseVisualStyleBackColor = true;
            // 
            // rbtnrepeater
            // 
            this.rbtnrepeater.AutoSize = true;
            this.rbtnrepeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnrepeater.Location = new System.Drawing.Point(542, 152);
            this.rbtnrepeater.Name = "rbtnrepeater";
            this.rbtnrepeater.Size = new System.Drawing.Size(105, 28);
            this.rbtnrepeater.TabIndex = 10;
            this.rbtnrepeater.TabStop = true;
            this.rbtnrepeater.Text = "Repeater";
            this.rbtnrepeater.UseVisualStyleBackColor = true;
            // 
            // rbtnregular
            // 
            this.rbtnregular.AutoSize = true;
            this.rbtnregular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnregular.Location = new System.Drawing.Point(320, 152);
            this.rbtnregular.Name = "rbtnregular";
            this.rbtnregular.Size = new System.Drawing.Size(94, 28);
            this.rbtnregular.TabIndex = 9;
            this.rbtnregular.TabStop = true;
            this.rbtnregular.Text = "Regular";
            this.rbtnregular.UseVisualStyleBackColor = true;
            // 
            // txtfathrname
            // 
            this.txtfathrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfathrname.Location = new System.Drawing.Point(159, 86);
            this.txtfathrname.Name = "txtfathrname";
            this.txtfathrname.Size = new System.Drawing.Size(237, 26);
            this.txtfathrname.TabIndex = 8;
            // 
            // txtseat
            // 
            this.txtseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseat.Location = new System.Drawing.Point(127, 180);
            this.txtseat.Name = "txtseat";
            this.txtseat.Size = new System.Drawing.Size(152, 26);
            this.txtseat.TabIndex = 7;
            // 
            // txtep
            // 
            this.txtep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtep.Location = new System.Drawing.Point(127, 132);
            this.txtep.Name = "txtep";
            this.txtep.Size = new System.Drawing.Size(152, 26);
            this.txtep.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(159, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 26);
            this.txtname.TabIndex = 4;
            // 
            // lblseatno
            // 
            this.lblseatno.AutoSize = true;
            this.lblseatno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseatno.Location = new System.Drawing.Point(19, 180);
            this.lblseatno.Name = "lblseatno";
            this.lblseatno.Size = new System.Drawing.Size(82, 24);
            this.lblseatno.TabIndex = 3;
            this.lblseatno.Text = "Seat No:";
            // 
            // lblepno
            // 
            this.lblepno.AutoSize = true;
            this.lblepno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblepno.Location = new System.Drawing.Point(19, 134);
            this.lblepno.Name = "lblepno";
            this.lblepno.Size = new System.Drawing.Size(70, 24);
            this.lblepno.TabIndex = 2;
            this.lblepno.Text = "EP No:";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfathername.Location = new System.Drawing.Point(18, 88);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(125, 24);
            this.lblfathername.TabIndex = 1;
            this.lblfathername.Text = "Father Name:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(18, 40);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(135, 24);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Student Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Controls.Add(this.txtsub6);
            this.groupBox2.Controls.Add(this.txtsub5);
            this.groupBox2.Controls.Add(this.txtsub4);
            this.groupBox2.Controls.Add(this.txtsub3);
            this.groupBox2.Controls.Add(this.txtsub2);
            this.groupBox2.Controls.Add(this.txtsubone);
            this.groupBox2.Controls.Add(this.lblsubsix);
            this.groupBox2.Controls.Add(this.lblsubfive);
            this.groupBox2.Controls.Add(this.lblfour);
            this.groupBox2.Controls.Add(this.lblsubthree);
            this.groupBox2.Controls.Add(this.lblsubtwo);
            this.groupBox2.Controls.Add(this.lblsubone);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COURSES";
            // 
            // txtsub6
            // 
            this.txtsub6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub6.Location = new System.Drawing.Point(533, 139);
            this.txtsub6.Name = "txtsub6";
            this.txtsub6.Size = new System.Drawing.Size(84, 29);
            this.txtsub6.TabIndex = 10;
            // 
            // txtsub5
            // 
            this.txtsub5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub5.Location = new System.Drawing.Point(533, 88);
            this.txtsub5.Name = "txtsub5";
            this.txtsub5.Size = new System.Drawing.Size(84, 29);
            this.txtsub5.TabIndex = 9;
            // 
            // txtsub4
            // 
            this.txtsub4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub4.Location = new System.Drawing.Point(533, 40);
            this.txtsub4.Name = "txtsub4";
            this.txtsub4.Size = new System.Drawing.Size(84, 29);
            this.txtsub4.TabIndex = 8;
            // 
            // txtsub3
            // 
            this.txtsub3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub3.Location = new System.Drawing.Point(214, 143);
            this.txtsub3.Name = "txtsub3";
            this.txtsub3.Size = new System.Drawing.Size(84, 29);
            this.txtsub3.TabIndex = 7;
            // 
            // txtsub2
            // 
            this.txtsub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsub2.Location = new System.Drawing.Point(214, 93);
            this.txtsub2.Name = "txtsub2";
            this.txtsub2.Size = new System.Drawing.Size(84, 29);
            this.txtsub2.TabIndex = 6;
            // 
            // txtsubone
            // 
            this.txtsubone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubone.Location = new System.Drawing.Point(214, 44);
            this.txtsubone.Name = "txtsubone";
            this.txtsubone.Size = new System.Drawing.Size(84, 29);
            this.txtsubone.TabIndex = 2;
            // 
            // lblsubsix
            // 
            this.lblsubsix.AutoSize = true;
            this.lblsubsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubsix.Location = new System.Drawing.Point(335, 142);
            this.lblsubsix.Name = "lblsubsix";
            this.lblsubsix.Size = new System.Drawing.Size(88, 24);
            this.lblsubsix.TabIndex = 5;
            this.lblsubsix.Text = "Subject6:";
            // 
            // lblsubfive
            // 
            this.lblsubfive.AutoSize = true;
            this.lblsubfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubfive.Location = new System.Drawing.Point(335, 96);
            this.lblsubfive.Name = "lblsubfive";
            this.lblsubfive.Size = new System.Drawing.Size(88, 24);
            this.lblsubfive.TabIndex = 4;
            this.lblsubfive.Text = "Subject5:";
            // 
            // lblfour
            // 
            this.lblfour.AutoSize = true;
            this.lblfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfour.Location = new System.Drawing.Point(335, 44);
            this.lblfour.Name = "lblfour";
            this.lblfour.Size = new System.Drawing.Size(88, 24);
            this.lblfour.TabIndex = 3;
            this.lblfour.Text = "Subject4:";
            // 
            // lblsubthree
            // 
            this.lblsubthree.AutoSize = true;
            this.lblsubthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubthree.Location = new System.Drawing.Point(18, 143);
            this.lblsubthree.Name = "lblsubthree";
            this.lblsubthree.Size = new System.Drawing.Size(88, 24);
            this.lblsubthree.TabIndex = 2;
            this.lblsubthree.Text = "Subject3:";
            // 
            // lblsubtwo
            // 
            this.lblsubtwo.AutoSize = true;
            this.lblsubtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtwo.Location = new System.Drawing.Point(18, 93);
            this.lblsubtwo.Name = "lblsubtwo";
            this.lblsubtwo.Size = new System.Drawing.Size(88, 24);
            this.lblsubtwo.TabIndex = 1;
            this.lblsubtwo.Text = "Subject2:";
            // 
            // lblsubone
            // 
            this.lblsubone.AutoSize = true;
            this.lblsubone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubone.Location = new System.Drawing.Point(18, 44);
            this.lblsubone.Name = "lblsubone";
            this.lblsubone.Size = new System.Drawing.Size(88, 24);
            this.lblsubone.TabIndex = 0;
            this.lblsubone.Text = "Subject1:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.txtobt);
            this.groupBox3.Controls.Add(this.txtgp);
            this.groupBox3.Controls.Add(this.txtper);
            this.groupBox3.Controls.Add(this.txttotalmarks);
            this.groupBox3.Controls.Add(this.lblobt);
            this.groupBox3.Controls.Add(this.lblgp);
            this.groupBox3.Controls.Add(this.lblper);
            this.groupBox3.Controls.Add(this.lbltotalmarks);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESULT";
            // 
            // txtobt
            // 
            this.txtobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobt.Location = new System.Drawing.Point(387, 45);
            this.txtobt.Name = "txtobt";
            this.txtobt.Size = new System.Drawing.Size(84, 29);
            this.txtobt.TabIndex = 14;
            // 
            // txtgp
            // 
            this.txtgp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgp.Location = new System.Drawing.Point(387, 94);
            this.txtgp.Name = "txtgp";
            this.txtgp.Size = new System.Drawing.Size(84, 29);
            this.txtgp.TabIndex = 13;
            // 
            // txtper
            // 
            this.txtper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtper.Location = new System.Drawing.Point(137, 94);
            this.txtper.Name = "txtper";
            this.txtper.Size = new System.Drawing.Size(84, 29);
            this.txtper.TabIndex = 12;
            // 
            // txttotalmarks
            // 
            this.txttotalmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalmarks.Location = new System.Drawing.Point(137, 44);
            this.txttotalmarks.Name = "txttotalmarks";
            this.txttotalmarks.Size = new System.Drawing.Size(84, 29);
            this.txttotalmarks.TabIndex = 11;
            // 
            // lblobt
            // 
            this.lblobt.AutoSize = true;
            this.lblobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobt.Location = new System.Drawing.Point(268, 48);
            this.lblobt.Name = "lblobt";
            this.lblobt.Size = new System.Drawing.Size(92, 24);
            this.lblobt.TabIndex = 4;
            this.lblobt.Text = "Obtained:";
            // 
            // lblgp
            // 
            this.lblgp.AutoSize = true;
            this.lblgp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgp.Location = new System.Drawing.Point(268, 90);
            this.lblgp.Name = "lblgp";
            this.lblgp.Size = new System.Drawing.Size(41, 24);
            this.lblgp.TabIndex = 3;
            this.lblgp.Text = "GP:";
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblper.Location = new System.Drawing.Point(7, 94);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(112, 24);
            this.lblper.TabIndex = 2;
            this.lblper.Text = "Percentage:";
            // 
            // lbltotalmarks
            // 
            this.lbltotalmarks.AutoSize = true;
            this.lbltotalmarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalmarks.Location = new System.Drawing.Point(6, 48);
            this.lbltotalmarks.Name = "lbltotalmarks";
            this.lbltotalmarks.Size = new System.Drawing.Size(111, 24);
            this.lbltotalmarks.TabIndex = 1;
            this.lbltotalmarks.Text = "Total Marks:";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(268, 624);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(104, 35);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lstshow
            // 
            this.lstshow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstshow.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lstshow.FormattingEnabled = true;
            this.lstshow.ItemHeight = 25;
            this.lstshow.Location = new System.Drawing.Point(573, 439);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(375, 229);
            this.lstshow.TabIndex = 5;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(115, 624);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 35);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(428, 624);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(104, 35);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "E&XIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Result.Properties.Resources.Karachi_University_logo__1_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(705, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 219);
            this.panel1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.chkbd);
            this.groupBox4.Controls.Add(this.chkasim);
            this.groupBox4.Controls.Add(this.chknadeem);
            this.groupBox4.Controls.Add(this.chkhussain);
            this.groupBox4.Controls.Add(this.chkkj);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(656, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 196);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SELECT YOUR MAIN TEACHER";
            // 
            // chkbd
            // 
            this.chkbd.AutoSize = true;
            this.chkbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbd.Location = new System.Drawing.Point(20, 150);
            this.chkbd.Name = "chkbd";
            this.chkbd.Size = new System.Drawing.Size(134, 24);
            this.chkbd.TabIndex = 18;
            this.chkbd.Text = "Sir Badar Sami";
            this.chkbd.UseVisualStyleBackColor = true;
            // 
            // chkasim
            // 
            this.chkasim.AutoSize = true;
            this.chkasim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkasim.Location = new System.Drawing.Point(20, 120);
            this.chkasim.Name = "chkasim";
            this.chkasim.Size = new System.Drawing.Size(107, 24);
            this.chkasim.TabIndex = 17;
            this.chkasim.Text = "Sir Asim Ali";
            this.chkasim.UseVisualStyleBackColor = true;
            // 
            // chknadeem
            // 
            this.chknadeem.AutoSize = true;
            this.chknadeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknadeem.Location = new System.Drawing.Point(20, 90);
            this.chknadeem.Name = "chknadeem";
            this.chknadeem.Size = new System.Drawing.Size(138, 24);
            this.chknadeem.TabIndex = 16;
            this.chknadeem.Text = "Sir Nadeem ALi";
            this.chknadeem.UseVisualStyleBackColor = true;
            // 
            // chkhussain
            // 
            this.chkhussain.AutoSize = true;
            this.chkhussain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkhussain.Location = new System.Drawing.Point(20, 60);
            this.chkhussain.Name = "chkhussain";
            this.chkhussain.Size = new System.Drawing.Size(167, 24);
            this.chkhussain.TabIndex = 15;
            this.chkhussain.Text = "Sir Hussain Saleem";
            this.chkhussain.UseVisualStyleBackColor = true;
            // 
            // chkkj
            // 
            this.chkkj.AutoSize = true;
            this.chkkj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkkj.Location = new System.Drawing.Point(20, 30);
            this.chkkj.Name = "chkkj";
            this.chkkj.Size = new System.Drawing.Size(140, 24);
            this.chkkj.TabIndex = 14;
            this.chkkj.Text = "Sir Khalid Jamal";
            this.chkkj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Semester:";
            // 
            // frmresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(960, 733);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstshow);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmresult";
            this.Text = "Marksheet";
            this.Load += new System.EventHandler(this.frmresult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnimprover;
        private System.Windows.Forms.RadioButton rbtnrepeater;
        private System.Windows.Forms.RadioButton rbtnregular;
        private System.Windows.Forms.TextBox txtfathrname;
        private System.Windows.Forms.TextBox txtseat;
        private System.Windows.Forms.TextBox txtep;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblseatno;
        private System.Windows.Forms.Label lblepno;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cboselect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsub6;
        private System.Windows.Forms.TextBox txtsub5;
        private System.Windows.Forms.TextBox txtsub4;
        private System.Windows.Forms.TextBox txtsub3;
        private System.Windows.Forms.TextBox txtsub2;
        private System.Windows.Forms.TextBox txtsubone;
        private System.Windows.Forms.Label lblsubsix;
        private System.Windows.Forms.Label lblsubfive;
        private System.Windows.Forms.Label lblfour;
        private System.Windows.Forms.Label lblsubthree;
        private System.Windows.Forms.Label lblsubtwo;
        private System.Windows.Forms.Label lblsubone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtgp;
        private System.Windows.Forms.TextBox txtper;
        private System.Windows.Forms.TextBox txttotalmarks;
        private System.Windows.Forms.Label lblobt;
        private System.Windows.Forms.Label lblgp;
        private System.Windows.Forms.Label lblper;
        private System.Windows.Forms.Label lbltotalmarks;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtobt;
        private System.Windows.Forms.ListBox lstshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkbd;
        private System.Windows.Forms.CheckBox chkasim;
        private System.Windows.Forms.CheckBox chknadeem;
        private System.Windows.Forms.CheckBox chkhussain;
        private System.Windows.Forms.CheckBox chkkj;
        private System.Windows.Forms.Label label1;
    }
}

