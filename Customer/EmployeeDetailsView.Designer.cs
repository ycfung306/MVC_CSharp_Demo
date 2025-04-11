namespace Project
{
    partial class EmployeeDetailsView
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
            this.cboReportsTo = new System.Windows.Forms.ComboBox();
            this.cboOffice = new System.Windows.Forms.ComboBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeNum = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblExt = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeNum = new System.Windows.Forms.Label();
            this.dvgSupervise = new System.Windows.Forms.DataGridView();
            this.lblSupervise = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSupervise)).BeginInit();
            this.SuspendLayout();
            // 
            // cboReportsTo
            // 
            this.cboReportsTo.Enabled = false;
            this.cboReportsTo.FormattingEnabled = true;
            this.cboReportsTo.Location = new System.Drawing.Point(425, 69);
            this.cboReportsTo.Name = "cboReportsTo";
            this.cboReportsTo.Size = new System.Drawing.Size(181, 20);
            this.cboReportsTo.TabIndex = 32;
            // 
            // cboOffice
            // 
            this.cboOffice.Enabled = false;
            this.cboOffice.FormattingEnabled = true;
            this.cboOffice.Location = new System.Drawing.Point(272, 22);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Size = new System.Drawing.Size(147, 20);
            this.cboOffice.TabIndex = 31;
            // 
            // txtExt
            // 
            this.txtExt.Enabled = false;
            this.txtExt.Location = new System.Drawing.Point(425, 20);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 22);
            this.txtExt.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(4, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(602, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(209, 69);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 22);
            this.txtLastName.TabIndex = 28;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(4, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 22);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(126, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 22);
            this.txtTitle.TabIndex = 26;
            // 
            // txtEmployeeNum
            // 
            this.txtEmployeeNum.Enabled = false;
            this.txtEmployeeNum.Location = new System.Drawing.Point(4, 24);
            this.txtEmployeeNum.Name = "txtEmployeeNum";
            this.txtEmployeeNum.Size = new System.Drawing.Size(104, 22);
            this.txtEmployeeNum.TabIndex = 25;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(124, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 12);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Job Title";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.Location = new System.Drawing.Point(423, 54);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(53, 12);
            this.lblReportsTo.TabIndex = 23;
            this.lblReportsTo.Text = "Reports to";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(271, 6);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(34, 12);
            this.lblOffice.TabIndex = 22;
            this.lblOffice.Text = "Office";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 12);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(423, 5);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(51, 12);
            this.lblExt.TabIndex = 20;
            this.lblExt.Text = "Extension";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(207, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 12);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(4, 54);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 12);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEmployeeNum
            // 
            this.lblEmployeeNum.AutoSize = true;
            this.lblEmployeeNum.Location = new System.Drawing.Point(4, 9);
            this.lblEmployeeNum.Name = "lblEmployeeNum";
            this.lblEmployeeNum.Size = new System.Drawing.Size(93, 12);
            this.lblEmployeeNum.TabIndex = 17;
            this.lblEmployeeNum.Text = "Employee Number";
            // 
            // dvgSupervise
            // 
            this.dvgSupervise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSupervise.Location = new System.Drawing.Point(4, 166);
            this.dvgSupervise.Name = "dvgSupervise";
            this.dvgSupervise.RowTemplate.Height = 24;
            this.dvgSupervise.Size = new System.Drawing.Size(602, 200);
            this.dvgSupervise.TabIndex = 33;
            // 
            // lblSupervise
            // 
            this.lblSupervise.AutoSize = true;
            this.lblSupervise.Location = new System.Drawing.Point(6, 148);
            this.lblSupervise.Name = "lblSupervise";
            this.lblSupervise.Size = new System.Drawing.Size(50, 12);
            this.lblSupervise.TabIndex = 34;
            this.lblSupervise.Text = "Supervise";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(531, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(4, 372);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(93, 23);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Delete Record";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(531, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save Record";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(450, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel Edit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmployeeDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 407);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSupervise);
            this.Controls.Add(this.dvgSupervise);
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
            this.Name = "EmployeeDetailsView";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSupervise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboReportsTo;
        private System.Windows.Forms.ComboBox cboOffice;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtEmployeeNum;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportsTo;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeNum;
        private System.Windows.Forms.DataGridView dvgSupervise;
        private System.Windows.Forms.Label lblSupervise;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}