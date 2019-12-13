namespace Computer_Collegiate
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.txtupass = new System.Windows.Forms.TextBox();
            this.lblupass = new System.Windows.Forms.Label();
            this.txtuuerid = new System.Windows.Forms.TextBox();
            this.lbluuserid = new System.Windows.Forms.Label();
            this.lblustatus = new System.Windows.Forms.Label();
            this.cboustatus = new System.Windows.Forms.ComboBox();
            this.lbluname = new System.Windows.Forms.Label();
            this.cbouname = new System.Windows.Forms.ComboBox();
            this.btnuexit = new System.Windows.Forms.Button();
            this.btnudelete = new System.Windows.Forms.Button();
            this.btnuupdate = new System.Windows.Forms.Button();
            this.btnuadd = new System.Windows.Forms.Button();
            this.btnunew = new System.Windows.Forms.Button();
            this.dataGridViewuser = new System.Windows.Forms.DataGridView();
            this.lbluserinformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtupass
            // 
            this.txtupass.Location = new System.Drawing.Point(418, 104);
            this.txtupass.Name = "txtupass";
            this.txtupass.Size = new System.Drawing.Size(100, 20);
            this.txtupass.TabIndex = 16;
            // 
            // lblupass
            // 
            this.lblupass.AutoSize = true;
            this.lblupass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupass.Location = new System.Drawing.Point(418, 86);
            this.lblupass.Name = "lblupass";
            this.lblupass.Size = new System.Drawing.Size(69, 15);
            this.lblupass.TabIndex = 15;
            this.lblupass.Text = "Password";
            // 
            // txtuuerid
            // 
            this.txtuuerid.Location = new System.Drawing.Point(295, 104);
            this.txtuuerid.Name = "txtuuerid";
            this.txtuuerid.Size = new System.Drawing.Size(100, 20);
            this.txtuuerid.TabIndex = 14;
            // 
            // lbluuserid
            // 
            this.lbluuserid.AutoSize = true;
            this.lbluuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluuserid.Location = new System.Drawing.Point(295, 85);
            this.lbluuserid.Name = "lbluuserid";
            this.lbluuserid.Size = new System.Drawing.Size(55, 15);
            this.lbluuserid.TabIndex = 13;
            this.lbluuserid.Text = "User ID";
            // 
            // lblustatus
            // 
            this.lblustatus.AutoSize = true;
            this.lblustatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblustatus.Location = new System.Drawing.Point(155, 86);
            this.lblustatus.Name = "lblustatus";
            this.lblustatus.Size = new System.Drawing.Size(47, 15);
            this.lblustatus.TabIndex = 12;
            this.lblustatus.Text = "Status";
            // 
            // cboustatus
            // 
            this.cboustatus.FormattingEnabled = true;
            this.cboustatus.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cboustatus.Location = new System.Drawing.Point(155, 104);
            this.cboustatus.Name = "cboustatus";
            this.cboustatus.Size = new System.Drawing.Size(121, 21);
            this.cboustatus.TabIndex = 11;
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(12, 86);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(45, 15);
            this.lbluname.TabIndex = 10;
            this.lbluname.Text = "Name";
            // 
            // cbouname
            // 
            this.cbouname.FormattingEnabled = true;
            this.cbouname.Location = new System.Drawing.Point(12, 104);
            this.cbouname.Name = "cbouname";
            this.cbouname.Size = new System.Drawing.Size(121, 21);
            this.cbouname.TabIndex = 9;
            // 
            // btnuexit
            // 
            this.btnuexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuexit.Location = new System.Drawing.Point(554, 416);
            this.btnuexit.Name = "btnuexit";
            this.btnuexit.Size = new System.Drawing.Size(126, 34);
            this.btnuexit.TabIndex = 21;
            this.btnuexit.Text = "Exit";
            this.btnuexit.UseVisualStyleBackColor = true;
            this.btnuexit.Click += new System.EventHandler(this.btnuexit_Click);
            // 
            // btnudelete
            // 
            this.btnudelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnudelete.Location = new System.Drawing.Point(554, 293);
            this.btnudelete.Name = "btnudelete";
            this.btnudelete.Size = new System.Drawing.Size(126, 34);
            this.btnudelete.TabIndex = 20;
            this.btnudelete.Text = "Delete";
            this.btnudelete.UseVisualStyleBackColor = true;
            this.btnudelete.Click += new System.EventHandler(this.btnudelete_Click);
            // 
            // btnuupdate
            // 
            this.btnuupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuupdate.Location = new System.Drawing.Point(554, 250);
            this.btnuupdate.Name = "btnuupdate";
            this.btnuupdate.Size = new System.Drawing.Size(126, 34);
            this.btnuupdate.TabIndex = 19;
            this.btnuupdate.Text = "Update";
            this.btnuupdate.UseVisualStyleBackColor = true;
            this.btnuupdate.Click += new System.EventHandler(this.btnuupdate_Click);
            // 
            // btnuadd
            // 
            this.btnuadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuadd.Location = new System.Drawing.Point(554, 206);
            this.btnuadd.Name = "btnuadd";
            this.btnuadd.Size = new System.Drawing.Size(126, 34);
            this.btnuadd.TabIndex = 18;
            this.btnuadd.Text = "Add";
            this.btnuadd.UseVisualStyleBackColor = true;
            this.btnuadd.Click += new System.EventHandler(this.btnuadd_Click);
            // 
            // btnunew
            // 
            this.btnunew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunew.Location = new System.Drawing.Point(554, 159);
            this.btnunew.Name = "btnunew";
            this.btnunew.Size = new System.Drawing.Size(126, 34);
            this.btnunew.TabIndex = 17;
            this.btnunew.Text = "New";
            this.btnunew.UseVisualStyleBackColor = true;
            this.btnunew.Click += new System.EventHandler(this.btnunew_Click);
            // 
            // dataGridViewuser
            // 
            this.dataGridViewuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewuser.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewuser.Name = "dataGridViewuser";
            this.dataGridViewuser.Size = new System.Drawing.Size(519, 266);
            this.dataGridViewuser.TabIndex = 22;
            // 
            // lbluserinformation
            // 
            this.lbluserinformation.AutoSize = true;
            this.lbluserinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserinformation.Location = new System.Drawing.Point(140, 20);
            this.lbluserinformation.Name = "lbluserinformation";
            this.lbluserinformation.Size = new System.Drawing.Size(353, 37);
            this.lbluserinformation.TabIndex = 23;
            this.lbluserinformation.Text = "USER INFORMATION";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Computer_Collegiate.Properties.Resources.images1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.ControlBox = false;
            this.Controls.Add(this.lbluserinformation);
            this.Controls.Add(this.dataGridViewuser);
            this.Controls.Add(this.btnuexit);
            this.Controls.Add(this.btnudelete);
            this.Controls.Add(this.btnuupdate);
            this.Controls.Add(this.btnuadd);
            this.Controls.Add(this.btnunew);
            this.Controls.Add(this.txtupass);
            this.Controls.Add(this.lblupass);
            this.Controls.Add(this.txtuuerid);
            this.Controls.Add(this.lbluuserid);
            this.Controls.Add(this.lblustatus);
            this.Controls.Add(this.cboustatus);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.cbouname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtupass;
        private System.Windows.Forms.Label lblupass;
        private System.Windows.Forms.TextBox txtuuerid;
        private System.Windows.Forms.Label lbluuserid;
        private System.Windows.Forms.Label lblustatus;
        private System.Windows.Forms.ComboBox cboustatus;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.ComboBox cbouname;
        private System.Windows.Forms.Button btnuexit;
        private System.Windows.Forms.Button btnudelete;
        private System.Windows.Forms.Button btnuupdate;
        private System.Windows.Forms.Button btnuadd;
        private System.Windows.Forms.Button btnunew;
        private System.Windows.Forms.DataGridView dataGridViewuser;
        private System.Windows.Forms.Label lbluserinformation;
    }
}