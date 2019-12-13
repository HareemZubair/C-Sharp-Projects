namespace Computer_Collegiate
{
    partial class Courses
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
            this.lbluserinformation = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncdelete = new System.Windows.Forms.Button();
            this.btncupdate = new System.Windows.Forms.Button();
            this.btncnew = new System.Windows.Forms.Button();
            this.dataGridViewcourse = new System.Windows.Forms.DataGridView();
            this.txtlumpsumfee = new System.Windows.Forms.TextBox();
            this.txtmnthlyfee = new System.Windows.Forms.TextBox();
            this.txtadfee = new System.Windows.Forms.TextBox();
            this.txttfee = new System.Windows.Forms.TextBox();
            this.cbocname = new System.Windows.Forms.ComboBox();
            this.lumpsumfee = new System.Windows.Forms.Label();
            this.monthlyfee = new System.Windows.Forms.Label();
            this.Admissionfee = new System.Windows.Forms.Label();
            this.totalfee = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluserinformation
            // 
            this.lbluserinformation.AutoSize = true;
            this.lbluserinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserinformation.Location = new System.Drawing.Point(141, 40);
            this.lbluserinformation.Name = "lbluserinformation";
            this.lbluserinformation.Size = new System.Drawing.Size(403, 37);
            this.lbluserinformation.TabIndex = 27;
            this.lbluserinformation.Text = "COURSE INFORMATION";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(18, 410);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 33);
            this.btnadd.TabIndex = 42;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncdelete
            // 
            this.btncdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncdelete.Location = new System.Drawing.Point(177, 410);
            this.btncdelete.Name = "btncdelete";
            this.btncdelete.Size = new System.Drawing.Size(120, 33);
            this.btncdelete.TabIndex = 41;
            this.btncdelete.Text = "Delete";
            this.btncdelete.UseVisualStyleBackColor = true;
            this.btncdelete.Click += new System.EventHandler(this.btncdelete_Click);
            // 
            // btncupdate
            // 
            this.btncupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncupdate.Location = new System.Drawing.Point(177, 352);
            this.btncupdate.Name = "btncupdate";
            this.btncupdate.Size = new System.Drawing.Size(120, 33);
            this.btncupdate.TabIndex = 40;
            this.btncupdate.Text = "Update";
            this.btncupdate.UseVisualStyleBackColor = true;
            this.btncupdate.Click += new System.EventHandler(this.btncupdate_Click);
            // 
            // btncnew
            // 
            this.btncnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnew.Location = new System.Drawing.Point(18, 352);
            this.btncnew.Name = "btncnew";
            this.btncnew.Size = new System.Drawing.Size(120, 33);
            this.btncnew.TabIndex = 39;
            this.btncnew.Text = "New";
            this.btncnew.UseVisualStyleBackColor = true;
            this.btncnew.Click += new System.EventHandler(this.btncnew_Click);
            // 
            // dataGridViewcourse
            // 
            this.dataGridViewcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcourse.Location = new System.Drawing.Point(260, 126);
            this.dataGridViewcourse.Name = "dataGridViewcourse";
            this.dataGridViewcourse.Size = new System.Drawing.Size(420, 213);
            this.dataGridViewcourse.TabIndex = 38;
            // 
            // txtlumpsumfee
            // 
            this.txtlumpsumfee.Location = new System.Drawing.Point(118, 307);
            this.txtlumpsumfee.Name = "txtlumpsumfee";
            this.txtlumpsumfee.Size = new System.Drawing.Size(121, 20);
            this.txtlumpsumfee.TabIndex = 37;
            // 
            // txtmnthlyfee
            // 
            this.txtmnthlyfee.Location = new System.Drawing.Point(118, 265);
            this.txtmnthlyfee.Name = "txtmnthlyfee";
            this.txtmnthlyfee.Size = new System.Drawing.Size(121, 20);
            this.txtmnthlyfee.TabIndex = 36;
            // 
            // txtadfee
            // 
            this.txtadfee.Location = new System.Drawing.Point(118, 221);
            this.txtadfee.Name = "txtadfee";
            this.txtadfee.Size = new System.Drawing.Size(121, 20);
            this.txtadfee.TabIndex = 35;
            // 
            // txttfee
            // 
            this.txttfee.Location = new System.Drawing.Point(118, 181);
            this.txttfee.Name = "txttfee";
            this.txttfee.Size = new System.Drawing.Size(121, 20);
            this.txttfee.TabIndex = 34;
            // 
            // cbocname
            // 
            this.cbocname.FormattingEnabled = true;
            this.cbocname.Location = new System.Drawing.Point(118, 138);
            this.cbocname.Name = "cbocname";
            this.cbocname.Size = new System.Drawing.Size(121, 21);
            this.cbocname.TabIndex = 33;
            // 
            // lumpsumfee
            // 
            this.lumpsumfee.AutoSize = true;
            this.lumpsumfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumpsumfee.Location = new System.Drawing.Point(19, 307);
            this.lumpsumfee.Name = "lumpsumfee";
            this.lumpsumfee.Size = new System.Drawing.Size(88, 13);
            this.lumpsumfee.TabIndex = 32;
            this.lumpsumfee.Text = "Lumpsum Fee:";
            // 
            // monthlyfee
            // 
            this.monthlyfee.AutoSize = true;
            this.monthlyfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyfee.Location = new System.Drawing.Point(19, 268);
            this.monthlyfee.Name = "monthlyfee";
            this.monthlyfee.Size = new System.Drawing.Size(80, 13);
            this.monthlyfee.TabIndex = 31;
            this.monthlyfee.Text = "Monthly Fee:";
            // 
            // Admissionfee
            // 
            this.Admissionfee.AutoSize = true;
            this.Admissionfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admissionfee.Location = new System.Drawing.Point(15, 224);
            this.Admissionfee.Name = "Admissionfee";
            this.Admissionfee.Size = new System.Drawing.Size(92, 13);
            this.Admissionfee.TabIndex = 30;
            this.Admissionfee.Text = "Admission Fee:";
            // 
            // totalfee
            // 
            this.totalfee.AutoSize = true;
            this.totalfee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalfee.Location = new System.Drawing.Point(19, 184);
            this.totalfee.Name = "totalfee";
            this.totalfee.Size = new System.Drawing.Size(65, 13);
            this.totalfee.TabIndex = 29;
            this.totalfee.Text = "Total Fee:";
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.Location = new System.Drawing.Point(19, 141);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(86, 13);
            this.cname.TabIndex = 28;
            this.cname.Text = "Course Name:";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(546, 428);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 33);
            this.btnexit.TabIndex = 43;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_Collegiate.Properties.Resources.images5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btncdelete);
            this.Controls.Add(this.btncupdate);
            this.Controls.Add(this.btncnew);
            this.Controls.Add(this.dataGridViewcourse);
            this.Controls.Add(this.txtlumpsumfee);
            this.Controls.Add(this.txtmnthlyfee);
            this.Controls.Add(this.txtadfee);
            this.Controls.Add(this.txttfee);
            this.Controls.Add(this.cbocname);
            this.Controls.Add(this.lumpsumfee);
            this.Controls.Add(this.monthlyfee);
            this.Controls.Add(this.Admissionfee);
            this.Controls.Add(this.totalfee);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.lbluserinformation);
            this.Name = "Courses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluserinformation;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncdelete;
        private System.Windows.Forms.Button btncupdate;
        private System.Windows.Forms.Button btncnew;
        private System.Windows.Forms.DataGridView dataGridViewcourse;
        private System.Windows.Forms.TextBox txtlumpsumfee;
        private System.Windows.Forms.TextBox txtmnthlyfee;
        private System.Windows.Forms.TextBox txtadfee;
        private System.Windows.Forms.TextBox txttfee;
        private System.Windows.Forms.ComboBox cbocname;
        private System.Windows.Forms.Label lumpsumfee;
        private System.Windows.Forms.Label monthlyfee;
        private System.Windows.Forms.Label Admissionfee;
        private System.Windows.Forms.Label totalfee;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Button btnexit;
    }
}