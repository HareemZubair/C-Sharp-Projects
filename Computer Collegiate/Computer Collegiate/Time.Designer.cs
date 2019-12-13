namespace Computer_Collegiate
{
    partial class Time
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
            this.btncexit = new System.Windows.Forms.Button();
            this.btntadd = new System.Windows.Forms.Button();
            this.btntdelete = new System.Windows.Forms.Button();
            this.btntupdate = new System.Windows.Forms.Button();
            this.btntnew = new System.Windows.Forms.Button();
            this.cboshift = new System.Windows.Forms.ComboBox();
            this.cbotime = new System.Windows.Forms.ComboBox();
            this.lblshift = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.dataGridViewtime = new System.Windows.Forms.DataGridView();
            this.lbltimeinformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtime)).BeginInit();
            this.SuspendLayout();
            // 
            // btncexit
            // 
            this.btncexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncexit.Location = new System.Drawing.Point(501, 421);
            this.btncexit.Name = "btncexit";
            this.btncexit.Size = new System.Drawing.Size(126, 40);
            this.btncexit.TabIndex = 38;
            this.btncexit.Text = "Exit";
            this.btncexit.UseVisualStyleBackColor = true;
            // 
            // btntadd
            // 
            this.btntadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntadd.Location = new System.Drawing.Point(28, 264);
            this.btntadd.Name = "btntadd";
            this.btntadd.Size = new System.Drawing.Size(120, 33);
            this.btntadd.TabIndex = 37;
            this.btntadd.Text = "Add";
            this.btntadd.UseVisualStyleBackColor = true;
            this.btntadd.Click += new System.EventHandler(this.btntadd_Click);
            // 
            // btntdelete
            // 
            this.btntdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntdelete.Location = new System.Drawing.Point(28, 369);
            this.btntdelete.Name = "btntdelete";
            this.btntdelete.Size = new System.Drawing.Size(120, 33);
            this.btntdelete.TabIndex = 36;
            this.btntdelete.Text = "Delete";
            this.btntdelete.UseVisualStyleBackColor = true;
            // 
            // btntupdate
            // 
            this.btntupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntupdate.Location = new System.Drawing.Point(28, 312);
            this.btntupdate.Name = "btntupdate";
            this.btntupdate.Size = new System.Drawing.Size(120, 33);
            this.btntupdate.TabIndex = 35;
            this.btntupdate.Text = "Update";
            this.btntupdate.UseVisualStyleBackColor = true;
            this.btntupdate.Click += new System.EventHandler(this.btntupdate_Click);
            // 
            // btntnew
            // 
            this.btntnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntnew.Location = new System.Drawing.Point(28, 216);
            this.btntnew.Name = "btntnew";
            this.btntnew.Size = new System.Drawing.Size(120, 33);
            this.btntnew.TabIndex = 34;
            this.btntnew.Text = "New";
            this.btntnew.UseVisualStyleBackColor = true;
            this.btntnew.Click += new System.EventHandler(this.btntnew_Click);
            // 
            // cboshift
            // 
            this.cboshift.FormattingEnabled = true;
            this.cboshift.Location = new System.Drawing.Point(12, 174);
            this.cboshift.Name = "cboshift";
            this.cboshift.Size = new System.Drawing.Size(121, 21);
            this.cboshift.TabIndex = 33;
            // 
            // cbotime
            // 
            this.cbotime.FormattingEnabled = true;
            this.cbotime.Location = new System.Drawing.Point(12, 115);
            this.cbotime.Name = "cbotime";
            this.cbotime.Size = new System.Drawing.Size(121, 21);
            this.cbotime.TabIndex = 32;
            this.cbotime.SelectedIndexChanged += new System.EventHandler(this.cbotime_SelectedIndexChanged);
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshift.Location = new System.Drawing.Point(14, 148);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(42, 16);
            this.lblshift.TabIndex = 31;
            this.lblshift.Text = "Shift:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(12, 90);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(47, 16);
            this.lbltime.TabIndex = 30;
            this.lbltime.Text = "Time:";
            // 
            // dataGridViewtime
            // 
            this.dataGridViewtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtime.Location = new System.Drawing.Point(209, 127);
            this.dataGridViewtime.Name = "dataGridViewtime";
            this.dataGridViewtime.Size = new System.Drawing.Size(455, 275);
            this.dataGridViewtime.TabIndex = 29;
            // 
            // lbltimeinformation
            // 
            this.lbltimeinformation.AutoSize = true;
            this.lbltimeinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeinformation.Location = new System.Drawing.Point(156, 34);
            this.lbltimeinformation.Name = "lbltimeinformation";
            this.lbltimeinformation.Size = new System.Drawing.Size(341, 37);
            this.lbltimeinformation.TabIndex = 39;
            this.lbltimeinformation.Text = "TIME INFORMATION";
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_Collegiate.Properties.Resources.images2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.ControlBox = false;
            this.Controls.Add(this.lbltimeinformation);
            this.Controls.Add(this.btncexit);
            this.Controls.Add(this.btntadd);
            this.Controls.Add(this.btntdelete);
            this.Controls.Add(this.btntupdate);
            this.Controls.Add(this.btntnew);
            this.Controls.Add(this.cboshift);
            this.Controls.Add(this.cbotime);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.dataGridViewtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.Load += new System.EventHandler(this.Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncexit;
        private System.Windows.Forms.Button btntadd;
        private System.Windows.Forms.Button btntdelete;
        private System.Windows.Forms.Button btntupdate;
        private System.Windows.Forms.Button btntnew;
        private System.Windows.Forms.ComboBox cboshift;
        private System.Windows.Forms.ComboBox cbotime;
        private System.Windows.Forms.Label lblshift;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.DataGridView dataGridViewtime;
        private System.Windows.Forms.Label lbltimeinformation;
    }
}