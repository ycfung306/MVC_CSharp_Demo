using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployeeView : Form
    {
        private EmployeeRepo employeeRepo = new EmployeeRepo();
        private int aguygighigiugiu;
        public EmployeeView()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        public void refreshDataGrid()
        {

            List<Employee> employees = employeeRepo.GetByName(txtName.Text);
            dgvEmployee.Columns.Clear();
            dgvEmployee.DataSource = null;

            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Employee Number", DataPropertyName = "employeeNumber", Name = "employeeNumber" });
            dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "fullName", Name = "fullName" });
            dgvEmployee.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "jobTitle", Name = "jobTitle" });

            dgvEmployee.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm(this);
            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvEmployee.Rows[selectedRowIndex];
                int employeeNum = Convert.ToInt32(selectedRow.Cells["employeeNumber"].Value.ToString());
                if (employeeRepo.GetById(employeeNum) != null) {
                    EmployeeDetailsView view = new EmployeeDetailsView(employeeNum);
                    view.Show();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    refreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a employee to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
