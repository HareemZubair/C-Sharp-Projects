namespace IMS
{
    partial class main
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnfaculty = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::IMS.Properties.Resources.GAP_01;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(619, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 446);
            this.button1.TabIndex = 4;
            this.button1.Text = "COURSES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::IMS.Properties.Resources.door_exit;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnexit.Location = new System.Drawing.Point(324, 303);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(261, 225);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackgroundImage = global::IMS.Properties.Resources.admin;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnadmin.Location = new System.Drawing.Point(48, 303);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(248, 225);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnfaculty
            // 
            this.btnfaculty.BackgroundImage = global::IMS.Properties.Resources.FacultyIcon;
            this.btnfaculty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaculty.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnfaculty.Location = new System.Drawing.Point(324, 82);
            this.btnfaculty.Name = "btnfaculty";
            this.btnfaculty.Size = new System.Drawing.Size(261, 215);
            this.btnfaculty.TabIndex = 1;
            this.btnfaculty.Text = "Faculty";
            this.btnfaculty.UseVisualStyleBackColor = true;
            this.btnfaculty.Click += new System.EventHandler(this.btnfaculty_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackgroundImage = global::IMS.Properties.Resources.images;
            this.btnstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnstudent.Location = new System.Drawing.Point(48, 82);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(248, 215);
            this.btnstudent.TabIndex = 0;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 603);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnfaculty);
            this.Controls.Add(this.btnstudent);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnfaculty;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button button1;
    }
}