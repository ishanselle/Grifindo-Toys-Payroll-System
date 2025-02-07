namespace System
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.lblgt = new System.Windows.Forms.Label();
            this.groupBoxMM = new System.Windows.Forms.GroupBox();
            this.LinkLabelSetting = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmployeesSalary = new System.Windows.Forms.LinkLabel();
            this.linkLabelEmployeeregister = new System.Windows.Forms.LinkLabel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.linkLabelSR = new System.Windows.Forms.LinkLabel();
            this.groupBoxMM.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblgt
            // 
            this.lblgt.AutoSize = true;
            this.lblgt.BackColor = System.Drawing.Color.Transparent;
            this.lblgt.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblgt.Location = new System.Drawing.Point(12, 9);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(251, 38);
            this.lblgt.TabIndex = 2;
            this.lblgt.Text = "Grieindo Toys";
            // 
            // groupBoxMM
            // 
            this.groupBoxMM.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMM.Controls.Add(this.linkLabelSR);
            this.groupBoxMM.Controls.Add(this.LinkLabelSetting);
            this.groupBoxMM.Controls.Add(this.linkLabelEmployeesSalary);
            this.groupBoxMM.Controls.Add(this.linkLabelEmployeeregister);
            this.groupBoxMM.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMM.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxMM.Location = new System.Drawing.Point(93, 73);
            this.groupBoxMM.Name = "groupBoxMM";
            this.groupBoxMM.Size = new System.Drawing.Size(285, 311);
            this.groupBoxMM.TabIndex = 3;
            this.groupBoxMM.TabStop = false;
            this.groupBoxMM.Text = "Main Menu";
            // 
            // LinkLabelSetting
            // 
            this.LinkLabelSetting.AutoSize = true;
            this.LinkLabelSetting.LinkColor = System.Drawing.SystemColors.Control;
            this.LinkLabelSetting.Location = new System.Drawing.Point(42, 205);
            this.LinkLabelSetting.Name = "LinkLabelSetting";
            this.LinkLabelSetting.Size = new System.Drawing.Size(84, 23);
            this.LinkLabelSetting.TabIndex = 3;
            this.LinkLabelSetting.TabStop = true;
            this.LinkLabelSetting.Text = "Setting";
            this.LinkLabelSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSetting_LinkClicked);
            // 
            // linkLabelEmployeesSalary
            // 
            this.linkLabelEmployeesSalary.AutoSize = true;
            this.linkLabelEmployeesSalary.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabelEmployeesSalary.Location = new System.Drawing.Point(42, 133);
            this.linkLabelEmployeesSalary.Name = "linkLabelEmployeesSalary";
            this.linkLabelEmployeesSalary.Size = new System.Drawing.Size(179, 23);
            this.linkLabelEmployeesSalary.TabIndex = 2;
            this.linkLabelEmployeesSalary.TabStop = true;
            this.linkLabelEmployeesSalary.Text = "Employee Salary";
            this.linkLabelEmployeesSalary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmployeesSalary_LinkClicked);
            // 
            // linkLabelEmployeeregister
            // 
            this.linkLabelEmployeeregister.AutoSize = true;
            this.linkLabelEmployeeregister.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabelEmployeeregister.Location = new System.Drawing.Point(42, 69);
            this.linkLabelEmployeeregister.Name = "linkLabelEmployeeregister";
            this.linkLabelEmployeeregister.Size = new System.Drawing.Size(196, 23);
            this.linkLabelEmployeeregister.TabIndex = 1;
            this.linkLabelEmployeeregister.TabStop = true;
            this.linkLabelEmployeeregister.Text = "Employee register";
            this.linkLabelEmployeeregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmployeeregister_LinkClicked);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Wheat;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogout.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.Location = new System.Drawing.Point(93, 404);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 43);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Wheat;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(274, 404);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 43);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // linkLabelSR
            // 
            this.linkLabelSR.AutoSize = true;
            this.linkLabelSR.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabelSR.Location = new System.Drawing.Point(42, 263);
            this.linkLabelSR.Name = "linkLabelSR";
            this.linkLabelSR.Size = new System.Drawing.Size(152, 23);
            this.linkLabelSR.TabIndex = 4;
            this.linkLabelSR.TabStop = true;
            this.linkLabelSR.Text = "Salary Report";
            this.linkLabelSR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSR_LinkClicked);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::System.Properties.Resources._0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.groupBoxMM);
            this.Controls.Add(this.lblgt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grieindo_Toys_Main_Form";
            this.groupBoxMM.ResumeLayout(false);
            this.groupBoxMM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label lblgt;
        private Windows.Forms.GroupBox groupBoxMM;
        private Windows.Forms.LinkLabel LinkLabelSetting;
        private Windows.Forms.LinkLabel linkLabelEmployeesSalary;
        private Windows.Forms.LinkLabel linkLabelEmployeeregister;
        private Windows.Forms.Button btnlogout;
        private Windows.Forms.Button btnNext;
        private Windows.Forms.LinkLabel linkLabelSR;
    }
}