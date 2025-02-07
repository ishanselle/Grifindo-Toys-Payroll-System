namespace System
{
    partial class Salary_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Report));
            this.lblESC = new System.Windows.Forms.Label();
            this.groupBoxreport = new System.Windows.Forms.GroupBox();
            this.btnALLSR = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.comboBoxeid = new System.Windows.Forms.ComboBox();
            this.lblEID = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblSD = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dataGridViewreport = new System.Windows.Forms.DataGridView();
            this.groupBoxMP = new System.Windows.Forms.GroupBox();
            this.btnreportm = new System.Windows.Forms.Button();
            this.groupBoxreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).BeginInit();
            this.groupBoxMP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblESC
            // 
            this.lblESC.AutoSize = true;
            this.lblESC.BackColor = System.Drawing.Color.Transparent;
            this.lblESC.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblESC.Location = new System.Drawing.Point(12, 9);
            this.lblESC.Name = "lblESC";
            this.lblESC.Size = new System.Drawing.Size(252, 38);
            this.lblESC.TabIndex = 5;
            this.lblESC.Text = "Salary Report";
            // 
            // groupBoxreport
            // 
            this.groupBoxreport.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxreport.Controls.Add(this.btnALLSR);
            this.groupBoxreport.Controls.Add(this.btnreport);
            this.groupBoxreport.Controls.Add(this.comboBoxeid);
            this.groupBoxreport.Controls.Add(this.lblEID);
            this.groupBoxreport.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxreport.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxreport.Location = new System.Drawing.Point(19, 50);
            this.groupBoxreport.Name = "groupBoxreport";
            this.groupBoxreport.Size = new System.Drawing.Size(434, 147);
            this.groupBoxreport.TabIndex = 6;
            this.groupBoxreport.TabStop = false;
            this.groupBoxreport.Text = "Report";
            // 
            // btnALLSR
            // 
            this.btnALLSR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnALLSR.ForeColor = System.Drawing.Color.Black;
            this.btnALLSR.Location = new System.Drawing.Point(16, 84);
            this.btnALLSR.Name = "btnALLSR";
            this.btnALLSR.Size = new System.Drawing.Size(207, 35);
            this.btnALLSR.TabIndex = 17;
            this.btnALLSR.Text = "All Salary Report";
            this.btnALLSR.UseVisualStyleBackColor = true;
            this.btnALLSR.Click += new System.EventHandler(this.btnALLSR_Click);
            // 
            // btnreport
            // 
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnreport.ForeColor = System.Drawing.Color.Black;
            this.btnreport.Location = new System.Drawing.Point(294, 75);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(120, 44);
            this.btnreport.TabIndex = 16;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // comboBoxeid
            // 
            this.comboBoxeid.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxeid.FormattingEnabled = true;
            this.comboBoxeid.Location = new System.Drawing.Point(171, 29);
            this.comboBoxeid.Name = "comboBoxeid";
            this.comboBoxeid.Size = new System.Drawing.Size(101, 42);
            this.comboBoxeid.TabIndex = 10;
            this.comboBoxeid.SelectedIndexChanged += new System.EventHandler(this.comboBoxeid_SelectedIndexChanged);
            // 
            // lblEID
            // 
            this.lblEID.AutoSize = true;
            this.lblEID.Location = new System.Drawing.Point(12, 32);
            this.lblEID.Name = "lblEID";
            this.lblEID.Size = new System.Drawing.Size(138, 23);
            this.lblEID.TabIndex = 8;
            this.lblEID.Text = "Employee ID";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(175, 84);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(266, 36);
            this.dateTimePickerEnd.TabIndex = 15;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Location = new System.Drawing.Point(175, 32);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(266, 36);
            this.dateTimePickerStart.TabIndex = 14;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(16, 39);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(115, 23);
            this.lblSD.TabIndex = 12;
            this.lblSD.Text = "Start Date";
            this.lblSD.Click += new System.EventHandler(this.lblSD_Click);
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(16, 91);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(102, 23);
            this.lblED.TabIndex = 13;
            this.lblED.Text = "End Date";
            this.lblED.Click += new System.EventHandler(this.lblED_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnexit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnexit.Location = new System.Drawing.Point(915, 712);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 43);
            this.btnexit.TabIndex = 18;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnMM
            // 
            this.btnMM.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMM.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMM.Location = new System.Drawing.Point(55, 712);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(140, 43);
            this.btnMM.TabIndex = 16;
            this.btnMM.Text = "Main Menu";
            this.btnMM.UseVisualStyleBackColor = false;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnclear.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(356, 223);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 43);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // dataGridViewreport
            // 
            this.dataGridViewreport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewreport.Location = new System.Drawing.Point(55, 356);
            this.dataGridViewreport.Name = "dataGridViewreport";
            this.dataGridViewreport.RowTemplate.Height = 24;
            this.dataGridViewreport.Size = new System.Drawing.Size(993, 324);
            this.dataGridViewreport.TabIndex = 19;
            // 
            // groupBoxMP
            // 
            this.groupBoxMP.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMP.Controls.Add(this.btnreportm);
            this.groupBoxMP.Controls.Add(this.dateTimePickerStart);
            this.groupBoxMP.Controls.Add(this.lblED);
            this.groupBoxMP.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxMP.Controls.Add(this.lblSD);
            this.groupBoxMP.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMP.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxMP.Location = new System.Drawing.Point(551, 50);
            this.groupBoxMP.Name = "groupBoxMP";
            this.groupBoxMP.Size = new System.Drawing.Size(457, 216);
            this.groupBoxMP.TabIndex = 20;
            this.groupBoxMP.TabStop = false;
            this.groupBoxMP.Text = "Monthly Report";
            // 
            // btnreportm
            // 
            this.btnreportm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnreportm.ForeColor = System.Drawing.Color.Black;
            this.btnreportm.Location = new System.Drawing.Point(321, 145);
            this.btnreportm.Name = "btnreportm";
            this.btnreportm.Size = new System.Drawing.Size(120, 44);
            this.btnreportm.TabIndex = 17;
            this.btnreportm.Text = "Report";
            this.btnreportm.UseVisualStyleBackColor = true;
            this.btnreportm.Click += new System.EventHandler(this.btnreportm_Click);
            // 
            // Salary_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::System.Properties.Resources._0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 784);
            this.Controls.Add(this.groupBoxMP);
            this.Controls.Add(this.dataGridViewreport);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnMM);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.groupBoxreport);
            this.Controls.Add(this.lblESC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Salary_Report";
            this.Text = "Salary_Report";
            this.Load += new System.EventHandler(this.Salary_Report_Load);
            this.groupBoxreport.ResumeLayout(false);
            this.groupBoxreport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewreport)).EndInit();
            this.groupBoxMP.ResumeLayout(false);
            this.groupBoxMP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label lblESC;
        private Windows.Forms.GroupBox groupBoxreport;
        private Windows.Forms.ComboBox comboBoxeid;
        private Windows.Forms.Label lblEID;
        private Windows.Forms.DateTimePicker dateTimePickerEnd;
        private Windows.Forms.DateTimePicker dateTimePickerStart;
        private Windows.Forms.Label lblSD;
        private Windows.Forms.Label lblED;
        private Windows.Forms.Button btnexit;
        private Windows.Forms.Button btnMM;
        private Windows.Forms.Button btnclear;
        private Windows.Forms.Button btnreport;
        private Windows.Forms.DataGridView dataGridViewreport;
        private Windows.Forms.Button btnALLSR;
        private Windows.Forms.GroupBox groupBoxMP;
        private Windows.Forms.Button btnreportm;
    }
}