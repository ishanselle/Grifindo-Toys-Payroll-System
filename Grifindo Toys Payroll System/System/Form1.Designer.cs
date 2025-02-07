namespace System
{
    partial class Grieindo_Toys_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grieindo_Toys_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGT = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpw = new System.Windows.Forms.Label();
            this.groupBoxlogin = new System.Windows.Forms.GroupBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(126, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.BackColor = System.Drawing.Color.Transparent;
            this.lblGT.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(154, 24);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(251, 38);
            this.lblGT.TabIndex = 1;
            this.lblGT.Text = "Grieindo Toys";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Location = new System.Drawing.Point(15, 51);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(112, 23);
            this.lbluname.TabIndex = 2;
            this.lbluname.Text = "Username";
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(16, 116);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(111, 23);
            this.lblpw.TabIndex = 3;
            this.lblpw.Text = "Password";
            // 
            // groupBoxlogin
            // 
            this.groupBoxlogin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxlogin.Controls.Add(this.txtpw);
            this.groupBoxlogin.Controls.Add(this.btnlogin);
            this.groupBoxlogin.Controls.Add(this.txtuname);
            this.groupBoxlogin.Controls.Add(this.btnclear);
            this.groupBoxlogin.Controls.Add(this.lblpw);
            this.groupBoxlogin.Controls.Add(this.lbluname);
            this.groupBoxlogin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxlogin.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxlogin.Location = new System.Drawing.Point(84, 315);
            this.groupBoxlogin.Name = "groupBoxlogin";
            this.groupBoxlogin.Size = new System.Drawing.Size(371, 223);
            this.groupBoxlogin.TabIndex = 4;
            this.groupBoxlogin.TabStop = false;
            this.groupBoxlogin.Text = "Login";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(172, 113);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(184, 30);
            this.txtpw.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Location = new System.Drawing.Point(245, 170);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(111, 39);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(172, 48);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(184, 30);
            this.txtuname.TabIndex = 1;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Location = new System.Drawing.Point(20, 170);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 39);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(329, 555);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 38);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Grieindo_Toys_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(538, 605);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBoxlogin);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grieindo_Toys_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grieindo_Toys_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxlogin.ResumeLayout(false);
            this.groupBoxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.PictureBox pictureBox1;
        private Windows.Forms.Label lblGT;
        private Windows.Forms.Label lbluname;
        private Windows.Forms.Label lblpw;
        private Windows.Forms.GroupBox groupBoxlogin;
        private Windows.Forms.Button btnclear;
        private Windows.Forms.Button btnlogin;
        private Windows.Forms.Button btnexit;
        private Windows.Forms.TextBox txtpw;
        private Windows.Forms.TextBox txtuname;
    }
}

