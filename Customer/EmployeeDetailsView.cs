using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployeeDetailsView : Form
    {
        private readonly int employeeNum;
        private EmployeeRepo employeeRepo = new EmployeeRepo();
        private OfficeRepo officeRepo = new OfficeRepo();

        public EmployeeDetailsView(int employeeNum)
        {
            InitializeComponent();
            this.employeeNum = employeeNum;
            refreshData();
        }

        private void refreshData()
        {
            List<Employee> employees = employeeRepo.GetAll();

            employees = employees.OrderBy(e => e.FullName).ToList();
            employees.Remove(employees.FirstOrDefault(e => e.EmployeeNumber == employeeNum));
            employees.Insert(0, new Employee { EmployeeNumber = -1, LastName = "NONE" });
            cboReportsTo.DataSource = employees;
            cboReportsTo.DisplayMember = "FullName";
            cboReportsTo.ValueMember = "employeeNumber";
            List<Office> offices = officeRepo.GetAll();
            offices = offices.OrderBy(o => o.City).ToList();
            cboOffice.DataSource = offices;
            cboOffice.DisplayMember = "city";
            cboOffice.ValueMember = "officeCode";
            Employee employee = employeeRepo.GetById(employeeNum);
            if (employee != null)
            {
                txtEmployeeNum.Text = employee.EmployeeNumber.ToString();
                txtLastName.Text = employee.LastName;
                txtFirstName.Text = employee.FirstName;
                txtTitle.Text = employee.JobTitle;
                txtExt.Text = employee.Extension;
                txtEmail.Text = employee.Email;
                cboOffice.SelectedValue = employee.OfficeCode;
                cboReportsTo.SelectedValue = employee.ReportsToId;
                List<Employee> supervise = employeeRepo.GetSupervise(employee.EmployeeNumber);
                dvgSupervise.Columns.Clear();
                dvgSupervise.AutoGenerateColumns = false;
                dvgSupervise.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Employee Number", DataPropertyName = "employeeNumber", Name = "employeeNumber" });
                dvgSupervise.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "fullName", Name = "fullName" });
                dvgSupervise.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "jobTitle", Name = "jobTitle" });
                dvgSupervise.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "email", Name = "email" });
                dvgSupervise.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Extension", DataPropertyName = "extension", Name = "extension" });
                dvgSupervise.DataSource = supervise;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            List<Employee> supervise = employeeRepo.GetSupervise(employeeNum);
            if(supervise.Count > 0)
            {
                MessageBox.Show("Cannot delete employee with supervisees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (employeeRepo.Delete(employeeNum))
                {
                    MessageBox.Show("Employee deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error deleting employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                toogleInput(false);
                refreshData();
                MessageBox.Show("Changes cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Employee employee = new Employee();
                employee.EmployeeNumber = Convert.ToInt32(txtEmployeeNum.Text);
                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.JobTitle = txtTitle.Text;
                employee.Extension = txtExt.Text;
                employee.Email = txtEmail.Text;
                employee.OfficeCode = Convert.ToString(cboOffice.SelectedValue);
                employee.ReportsToId = Convert.ToInt32(cboReportsTo.SelectedValue);
                if (employeeRepo.Edit(employee))
                {
                    MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    toogleInput(false);
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Error updating employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            toogleInput(true);
        }

        private void toogleInput(bool enable)
        {
            txtLastName.Enabled = enable;
            txtFirstName.Enabled = enable;
            txtTitle.Enabled = enable;
            txtExt.Enabled = enable;
            txtEmail.Enabled = enable;
            cboOffice.Enabled = enable;
            cboReportsTo.Enabled = enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;
            btnDel.Visible = enable;
            btnEdit.Visible = !enable;
        }
    }
}
