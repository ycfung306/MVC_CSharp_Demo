namespace Project
{
    partial class AddEmployeeForm
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
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmployeeNum = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.cboOffice = new System.Windows.Forms.ComboBox();
            this.cboReportsTo = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.AutoSize = true;
            this.lblEmployeeNum.Location = new System.Drawing.Point(8, 7);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 12);
            this.lblEmployeeNum.TabIndex = 0;
            this.lblEmployeeNum.Text = "Employee Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 102);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 12);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(211, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 12);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(321, 146);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(51, 12);
            this.lblExt.TabIndex = 3;
            this.lblExt.Text = "Extension";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 12);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(8, 56);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(34, 12);
            this.lblOffice.TabIndex = 5;
            this.lblOffice.Text = "Office";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(188, 56);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(53, 12);
            this.lblReportsTo.TabIndex = 6;
            this.lblReportsTo.Text = "Reports to";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(188, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 12);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Job Title";
            // 
            // txtEmployeeNum
            // 
            this.txtEmployeeNum.Location = new System.Drawing.Point(8, 22);
            this.txtEmployeeNum.Name = "txtEmployeeNum";
            this.txtEmployeeNum.Size = new System.Drawing.Size(104, 22);
            this.txtEmployeeNum.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(190, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 22);
            this.txtTitle.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(8, 117);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(213, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(323, 161);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 22);
            this.txtExt.TabIndex = 13;
            // 
            // cboOffice
            // 
            this.cboOffice.FormattingEnabled = true;
            this.cboOffice.Location = new System.Drawing.Point(9, 72);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Size = new System.Drawing.Size(147, 20);
            this.cboOffice.TabIndex = 14;
            // 
            // cboReportsTo
            // 
            this.cboReportsTo.FormattingEnabled = true;
            this.cboReportsTo.Location = new System.Drawing.Point(190, 71);
            this.cboReportsTo.Name = "cboReportsTo";
            this.cboReportsTo.Size = new System.Drawing.Size(168, 20);
            this.cboReportsTo.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 237);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboReportsTo);
            this.Controls.Add(this.cboOffice);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtEmployeeNum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblReportsTo);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeNum);
            this.Name = "AddEmployeeForm";
            this.Text = "Add a Employee Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEmployeeNum;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.ComboBox cboOffice;
        private System.Windows.Forms.ComboBox cboReportsTo;
        private System.Windows.Forms.Button btnAdd;
    }
}