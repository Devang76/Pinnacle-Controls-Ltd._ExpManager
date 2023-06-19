namespace Login_Form_Application
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_EMPID = new System.Windows.Forms.TextBox();
            this.txt_DESCRIPTION = new System.Windows.Forms.RichTextBox();
            this.dt_EXPDATE = new System.Windows.Forms.DateTimePicker();
            this.dt_ENTRY = new System.Windows.Forms.DateTimePicker();
            this.txt_EXPID = new System.Windows.Forms.TextBox();
            this.txt_CATEGORY = new System.Windows.Forms.TextBox();
            this.txt_AMT = new System.Windows.Forms.TextBox();
            this.txt_VENDOR = new System.Windows.Forms.TextBox();
            this.txt_RCPTID = new System.Windows.Forms.TextBox();
            this.lb_STS = new System.Windows.Forms.CheckedListBox();
            this.cb_METHOD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_APR = new System.Windows.Forms.DateTimePicker();
            this.button_CLEAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_DATABASE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DATABASE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENDITURE DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "EXP. AMOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "EXP. DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "METHOD OF PAYMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "VENDOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "APPROVAL STATUS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "DESCRIPTION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "RECIEPT ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "EMPLOYEE ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "ENTRY DATE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "EXP. ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 23);
            this.label13.TabIndex = 12;
            this.label13.Text = "EXP. CATEGORY";
            // 
            // txt_EMPID
            // 
            this.txt_EMPID.Location = new System.Drawing.Point(197, 100);
            this.txt_EMPID.Name = "txt_EMPID";
            this.txt_EMPID.Size = new System.Drawing.Size(207, 22);
            this.txt_EMPID.TabIndex = 13;
            // 
            // txt_DESCRIPTION
            // 
            this.txt_DESCRIPTION.Location = new System.Drawing.Point(680, 191);
            this.txt_DESCRIPTION.Name = "txt_DESCRIPTION";
            this.txt_DESCRIPTION.Size = new System.Drawing.Size(248, 103);
            this.txt_DESCRIPTION.TabIndex = 14;
            this.txt_DESCRIPTION.Text = "";
            this.txt_DESCRIPTION.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dt_EXPDATE
            // 
            this.dt_EXPDATE.Location = new System.Drawing.Point(171, 259);
            this.dt_EXPDATE.Name = "dt_EXPDATE";
            this.dt_EXPDATE.Size = new System.Drawing.Size(232, 22);
            this.dt_EXPDATE.TabIndex = 15;
            // 
            // dt_ENTRY
            // 
            this.dt_ENTRY.Location = new System.Drawing.Point(730, 28);
            this.dt_ENTRY.Name = "dt_ENTRY";
            this.dt_ENTRY.Size = new System.Drawing.Size(198, 22);
            this.dt_ENTRY.TabIndex = 17;
            // 
            // txt_EXPID
            // 
            this.txt_EXPID.Location = new System.Drawing.Point(197, 191);
            this.txt_EXPID.Name = "txt_EXPID";
            this.txt_EXPID.Size = new System.Drawing.Size(207, 22);
            this.txt_EXPID.TabIndex = 18;
            // 
            // txt_CATEGORY
            // 
            this.txt_CATEGORY.Location = new System.Drawing.Point(197, 340);
            this.txt_CATEGORY.Name = "txt_CATEGORY";
            this.txt_CATEGORY.Size = new System.Drawing.Size(207, 22);
            this.txt_CATEGORY.TabIndex = 19;
            // 
            // txt_AMT
            // 
            this.txt_AMT.Location = new System.Drawing.Point(197, 430);
            this.txt_AMT.Name = "txt_AMT";
            this.txt_AMT.Size = new System.Drawing.Size(207, 22);
            this.txt_AMT.TabIndex = 20;
            // 
            // txt_VENDOR
            // 
            this.txt_VENDOR.Location = new System.Drawing.Point(730, 98);
            this.txt_VENDOR.Name = "txt_VENDOR";
            this.txt_VENDOR.Size = new System.Drawing.Size(198, 22);
            this.txt_VENDOR.TabIndex = 22;
            // 
            // txt_RCPTID
            // 
            this.txt_RCPTID.Location = new System.Drawing.Point(730, 338);
            this.txt_RCPTID.Name = "txt_RCPTID";
            this.txt_RCPTID.Size = new System.Drawing.Size(198, 22);
            this.txt_RCPTID.TabIndex = 23;
            // 
            // lb_STS
            // 
            this.lb_STS.FormattingEnabled = true;
            this.lb_STS.Items.AddRange(new object[] {
            "INITIATED"});
            this.lb_STS.Location = new System.Drawing.Point(730, 431);
            this.lb_STS.Name = "lb_STS";
            this.lb_STS.Size = new System.Drawing.Size(198, 38);
            this.lb_STS.TabIndex = 25;
            // 
            // cb_METHOD
            // 
            this.cb_METHOD.FormattingEnabled = true;
            this.cb_METHOD.Items.AddRange(new object[] {
            "CASH",
            "CREDIT CARD",
            "DEBIT CARD",
            "ONLINE BANKING",
            "UPI APP",
            "E-WALLET",
            "BANK TRANSFER",
            "NEFT / RTGS",
            "CHEQUES",
            "CRYPTOCURRENCY",
            "INSTALLMENTS"});
            this.cb_METHOD.Location = new System.Drawing.Point(249, 516);
            this.cb_METHOD.Name = "cb_METHOD";
            this.cb_METHOD.Size = new System.Drawing.Size(155, 24);
            this.cb_METHOD.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(522, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "APPROVAL DATE";
            // 
            // dt_APR
            // 
            this.dt_APR.Location = new System.Drawing.Point(730, 514);
            this.dt_APR.Name = "dt_APR";
            this.dt_APR.Size = new System.Drawing.Size(198, 22);
            this.dt_APR.TabIndex = 28;
            // 
            // button_CLEAR
            // 
            this.button_CLEAR.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CLEAR.Location = new System.Drawing.Point(827, 634);
            this.button_CLEAR.Name = "button_CLEAR";
            this.button_CLEAR.Size = new System.Drawing.Size(101, 30);
            this.button_CLEAR.TabIndex = 29;
            this.button_CLEAR.Text = "FEED";
            this.button_CLEAR.UseVisualStyleBackColor = true;
            this.button_CLEAR.Click += new System.EventHandler(this.button_CLEAR_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 30;
            this.button1.Text = "CHECK STATUS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_DATABASE
            // 
            this.dgv_DATABASE.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DATABASE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DATABASE.Location = new System.Drawing.Point(237, 587);
            this.dgv_DATABASE.Name = "dgv_DATABASE";
            this.dgv_DATABASE.RowHeadersWidth = 51;
            this.dgv_DATABASE.RowTemplate.Height = 24;
            this.dgv_DATABASE.Size = new System.Drawing.Size(348, 77);
            this.dgv_DATABASE.TabIndex = 31;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 684);
            this.Controls.Add(this.dgv_DATABASE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_CLEAR);
            this.Controls.Add(this.dt_APR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_METHOD);
            this.Controls.Add(this.lb_STS);
            this.Controls.Add(this.txt_RCPTID);
            this.Controls.Add(this.txt_VENDOR);
            this.Controls.Add(this.txt_AMT);
            this.Controls.Add(this.txt_CATEGORY);
            this.Controls.Add(this.txt_EXPID);
            this.Controls.Add(this.dt_ENTRY);
            this.Controls.Add(this.dt_EXPDATE);
            this.Controls.Add(this.txt_DESCRIPTION);
            this.Controls.Add(this.txt_EMPID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "DETAILS PORTAL";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DATABASE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_EMPID;
        private System.Windows.Forms.RichTextBox txt_DESCRIPTION;
        private System.Windows.Forms.DateTimePicker dt_EXPDATE;
        private System.Windows.Forms.DateTimePicker dt_ENTRY;
        private System.Windows.Forms.TextBox txt_EXPID;
        private System.Windows.Forms.TextBox txt_CATEGORY;
        private System.Windows.Forms.TextBox txt_AMT;
        private System.Windows.Forms.TextBox txt_VENDOR;
        private System.Windows.Forms.TextBox txt_RCPTID;
        private System.Windows.Forms.CheckedListBox lb_STS;
        private System.Windows.Forms.ComboBox cb_METHOD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_APR;
        private System.Windows.Forms.Button button_CLEAR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_DATABASE;
    }
}