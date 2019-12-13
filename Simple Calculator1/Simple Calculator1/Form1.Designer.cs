namespace Simple_Calculator1
{
    partial class Form1
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(54, 275);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 42);
            this.btnC.TabIndex = 35;
            this.btnC.Text = "OFF";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(173, 275);
            this.btnCE.Margin = new System.Windows.Forms.Padding(2);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 42);
            this.btnCE.TabIndex = 34;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(229, 143);
            this.btndiv.Margin = new System.Windows.Forms.Padding(2);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(40, 42);
            this.btndiv.TabIndex = 33;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            // 
            // txtShow
            // 
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(54, 20);
            this.txtShow.Margin = new System.Windows.Forms.Padding(2);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(270, 35);
            this.txtShow.TabIndex = 32;
            this.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(229, 207);
            this.btnminus.Margin = new System.Windows.Forms.Padding(2);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(40, 42);
            this.btnminus.TabIndex = 31;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(286, 206);
            this.btnequal.Margin = new System.Windows.Forms.Padding(2);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(38, 111);
            this.btnequal.TabIndex = 30;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(229, 80);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(40, 42);
            this.btnadd.TabIndex = 29;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(229, 275);
            this.btnmul.Margin = new System.Windows.Forms.Padding(2);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(40, 42);
            this.btnmul.TabIndex = 28;
            this.btnmul.Text = "x";
            this.btnmul.UseVisualStyleBackColor = true;
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(114, 275);
            this.btnzero.Margin = new System.Windows.Forms.Padding(2);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(40, 42);
            this.btnzero.TabIndex = 27;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnsix
            // 
            this.btnsix.Location = new System.Drawing.Point(173, 143);
            this.btnsix.Margin = new System.Windows.Forms.Padding(2);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(40, 42);
            this.btnsix.TabIndex = 26;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(114, 206);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(40, 42);
            this.btnTwo.TabIndex = 25;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnseven
            // 
            this.btnseven.Location = new System.Drawing.Point(54, 80);
            this.btnseven.Margin = new System.Windows.Forms.Padding(2);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(40, 42);
            this.btnseven.TabIndex = 24;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnnine
            // 
            this.btnnine.Location = new System.Drawing.Point(173, 80);
            this.btnnine.Margin = new System.Windows.Forms.Padding(2);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(40, 42);
            this.btnnine.TabIndex = 23;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btneight
            // 
            this.btneight.Location = new System.Drawing.Point(114, 80);
            this.btneight.Margin = new System.Windows.Forms.Padding(2);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(40, 42);
            this.btneight.TabIndex = 22;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(54, 207);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(40, 42);
            this.btnOne.TabIndex = 21;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnthree
            // 
            this.btnthree.Location = new System.Drawing.Point(173, 206);
            this.btnthree.Margin = new System.Windows.Forms.Padding(2);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(40, 42);
            this.btnthree.TabIndex = 20;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnfive
            // 
            this.btnfive.Location = new System.Drawing.Point(114, 143);
            this.btnfive.Margin = new System.Windows.Forms.Padding(2);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(40, 42);
            this.btnfive.TabIndex = 19;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnfour
            // 
            this.btnfour.Location = new System.Drawing.Point(54, 143);
            this.btnfour.Margin = new System.Windows.Forms.Padding(2);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(40, 42);
            this.btnfour.TabIndex = 18;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(286, 143);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(68, 42);
            this.btnexit.TabIndex = 36;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(286, 80);
            this.btnon.Margin = new System.Windows.Forms.Padding(2);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(40, 42);
            this.btnon.TabIndex = 37;
            this.btnon.Text = "ON";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 338);
            this.Controls.Add(this.btnon);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnfour);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnC;
        internal System.Windows.Forms.Button btnCE;
        internal System.Windows.Forms.Button btndiv;
        internal System.Windows.Forms.TextBox txtShow;
        internal System.Windows.Forms.Button btnminus;
        internal System.Windows.Forms.Button btnequal;
        internal System.Windows.Forms.Button btnadd;
        internal System.Windows.Forms.Button btnmul;
        internal System.Windows.Forms.Button btnzero;
        internal System.Windows.Forms.Button btnsix;
        internal System.Windows.Forms.Button btnTwo;
        internal System.Windows.Forms.Button btnseven;
        internal System.Windows.Forms.Button btnnine;
        internal System.Windows.Forms.Button btneight;
        internal System.Windows.Forms.Button btnOne;
        internal System.Windows.Forms.Button btnthree;
        internal System.Windows.Forms.Button btnfive;
        internal System.Windows.Forms.Button btnfour;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btnon;
    }
}

