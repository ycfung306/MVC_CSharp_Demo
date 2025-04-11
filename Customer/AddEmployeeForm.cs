using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Project
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeeRepo employeeRepo = new EmployeeRepo();
        private OfficeRepo officeRepo = new OfficeRepo();
        private EmployeeView parent;
        private int a;

        public AddEmployeeForm(EmployeeView parent)
        {
            InitializeComponent();
            this.parent = parent;

            List<Employee> employees = employeeRepo.GetAll();
            employees = employees.OrderBy(e => e.FullName).ToList();
            employees.Insert(0, new Employee { EmployeeNumber = -1, LastName = "NONE" });
            cboReportsTo.DataSource = employees;
            cboReportsTo.DisplayMember = "FullName";
            cboReportsTo.ValueMember = "employeeNumber";

            List<Office> offices = officeRepo.GetAll();
            offices = offices.OrderBy(o => o.City).ToList();
            cboOffice.DataSource = offices;
            cboOffice.DisplayMember = "city";
            cboOffice.ValueMember = "officeCode";
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = employeeRepo.GetById(Convert.ToInt32(txtEmployeeNum.Text));
            if(Convert.ToInt32(txtEmployeeNum.Text) <= 0)
            {
               MessageBox.Show("Employee number must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            } 
            else if (employee != null)
            {
               MessageBox.Show("Employee ID already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                employee = new Employee();
                employee.EmployeeNumber = Convert.ToInt32(txtEmployeeNum.Text);
                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.JobTitle = txtTitle.Text;
                employee.Extension = txtExt.Text;
                employee.Email = txtEmail.Text;
                employee.OfficeCode = Convert.ToString(cboOffice.SelectedValue);
                employee.ReportsToId = Convert.ToInt32(cboReportsTo.SelectedValue);
                employeeRepo.Add(employee);
                Close();
                parent.refreshDataGrid();
            }
        }
    }
}
