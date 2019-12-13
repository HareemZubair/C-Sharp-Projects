namespace Computer_Collegiate
{
    partial class Main
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnfaculty = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::Computer_Collegiate.Properties.Resources.door_exit;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(341, 236);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(232, 201);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackgroundImage = global::Computer_Collegiate.Properties.Resources.admin;
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadmin.Location = new System.Drawing.Point(101, 236);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(224, 201);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnfaculty
            // 
            this.btnfaculty.BackgroundImage = global::Computer_Collegiate.Properties.Resources.FacultyIcon;
            this.btnfaculty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfaculty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfaculty.Location = new System.Drawing.Point(341, 40);
            this.btnfaculty.Name = "btnfaculty";
            this.btnfaculty.Size = new System.Drawing.Size(232, 190);
            this.btnfaculty.TabIndex = 1;
            this.btnfaculty.Text = "Faculty";
            this.btnfaculty.UseVisualStyleBackColor = true;
            this.btnfaculty.Click += new System.EventHandler(this.btnfaculty_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackgroundImage = global::Computer_Collegiate.Properties.Resources.images;
            this.btnstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstudent.Location = new System.Drawing.Point(101, 40);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(224, 190);
            this.btnstudent.TabIndex = 0;
            this.btnstudent.Text = "Student";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(671, 490);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnfaculty);
            this.Controls.Add(this.btnstudent);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnfaculty;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnexit;
    }
}