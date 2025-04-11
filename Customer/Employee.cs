using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public class Employee
    {
        private int employeeNumber;
        private string lastName;
        private string firstName;
        private string extension;
        private string email;
        private string officeCode;
        private Office office;
        private int reportsToId;
        private Employee reportsTo;
        private List<Employee> supervise;
        private string jobTitle;
        public int EmployeeNumber { get { return employeeNumber; } set { employeeNumber = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string Extension { get { return extension; } set { extension = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string OfficeCode { get { return officeCode; } set { officeCode = value; } }
        public Office Office { get { return office; } set { office = value; } }
        public int ReportsToId { get { return reportsToId; } set { reportsToId = value; } }
        public Employee ReportsTo { get { return reportsTo; } set { reportsTo = value; } }
        public List<Employee> Supervise { get { return supervise; } set { supervise = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
        //Constructor
        public Employee() { }
    }
    public class EmployeeRepo
    {
        public List<Employee> GetAll()
        {
            OfficeRepo officeRepo = new OfficeRepo();
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM employees", conn);
            MySqlDataReader reader = sql.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeNumber = reader.GetInt32("employeeNumber");
                employee.LastName = reader.GetString("lastName");
                employee.FirstName = reader.GetString("firstName");
                employee.Extension = reader.GetString("extension");
                employee.Email = reader.GetString("email");
                employee.OfficeCode = reader.GetString("officeCode");
                employee.Office = officeRepo.GetById(reader.GetInt32("officeCode"));
                employee.JobTitle = reader.GetString("jobTitle");
                employee.ReportsToId = (reader.IsDBNull(reader.GetOrdinal("reportsTo")) ? -1 : reader.GetInt32("reportsTo"));
                employee.ReportsTo = employee.ReportsToId >= 0 ? GetById(employee.ReportsToId) : null;
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public Employee GetById(int id)
        {
            OfficeRepo officeRepo = new OfficeRepo();
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM employees WHERE employeeNumber = @id", conn);
            sql.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = sql.ExecuteReader();
            Employee employee = null;
            if (reader.Read())
            {
                employee = new Employee();
                employee.EmployeeNumber = reader.GetInt32("employeeNumber");
                employee.LastName = reader.GetString("lastName");
                employee.FirstName = reader.GetString("firstName");
                employee.Extension = reader.GetString("extension");
                employee.Email = reader.GetString("email");
                employee.OfficeCode = reader.GetString("officeCode");
                employee.Office = officeRepo.GetById(reader.GetInt32("officeCode"));
                employee.JobTitle = reader.GetString("jobTitle");
                employee.ReportsToId = (reader.IsDBNull(reader.GetOrdinal("reportsTo")) ? -1 : reader.GetInt32("reportsTo"));
                employee.ReportsTo = employee.ReportsToId >= 0 ? GetById(employee.ReportsToId) : null;
            }
            conn.Close();
            return employee;
        }

        public List<Employee> GetByName(string name)
        {
            OfficeRepo officeRepo = new OfficeRepo();
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM employees WHERE lastName LIKE @name OR firstName LIKE @name", conn);
            sql.Parameters.AddWithValue("@name", "%" + name + "%");
            MySqlDataReader reader = sql.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeNumber = reader.GetInt32("employeeNumber");
                employee.LastName = reader.GetString("lastName");
                employee.FirstName = reader.GetString("firstName");
                employee.Extension = reader.GetString("extension");
                employee.Email = reader.GetString("email");
                employee.OfficeCode = reader.GetString("officeCode");
                employee.Office = officeRepo.GetById(reader.GetInt32("officeCode"));
                employee.JobTitle = reader.GetString("jobTitle");
                employee.ReportsToId = (reader.IsDBNull(reader.GetOrdinal("reportsTo")) ? -1 : reader.GetInt32("reportsTo"));
                employee.ReportsTo = employee.ReportsToId >= 0 ? GetById(employee.ReportsToId) : null;
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public List<Employee> GetSupervise(int id)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM employees WHERE reportsTo = @id", conn);
            sql.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = sql.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeNumber = reader.GetInt32("employeeNumber");
                employee.LastName = reader.GetString("lastName");
                employee.FirstName = reader.GetString("firstName");
                employee.Extension = reader.GetString("extension");
                employee.Email = reader.GetString("email");
                employee.OfficeCode = reader.GetString("officeCode");
                employee.JobTitle = reader.GetString("jobTitle");
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public bool Delete(int id)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("DELETE FROM employees WHERE employeeNumber = @id", conn);
            sql.Parameters.AddWithValue("@id", id);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
        public bool Edit(Employee employee)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("UPDATE employees SET lastName = @lastName, firstName = @firstName, extension = @extension, email = @email, officeCode = @officeCode, jobTitle = @jobTitle, reportsTo = @reportsToId WHERE employeeNumber = @employeeNumber", conn);
            sql.Parameters.AddWithValue("@lastName", employee.LastName);
            sql.Parameters.AddWithValue("@firstName", employee.FirstName);
            sql.Parameters.AddWithValue("@extension", employee.Extension);
            sql.Parameters.AddWithValue("@email", employee.Email);
            sql.Parameters.AddWithValue("@officeCode", employee.OfficeCode);
            sql.Parameters.AddWithValue("@jobTitle", employee.JobTitle);
            sql.Parameters.AddWithValue("@reportsToId", employee.ReportsToId <= 0 ? (object)DBNull.Value : employee.ReportsToId);
            sql.Parameters.AddWithValue("@employeeNumber", employee.EmployeeNumber);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
        public bool Add(Employee employee)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("INSERT INTO employees (employeeNumber, lastName, firstName, extension, email, officeCode, jobTitle, reportsTo) VALUES (@employeeNumber, @lastName, @firstName, @extension, @email, @officeCode, @jobTitle, @reportsTo)", conn);
            sql.Parameters.AddWithValue("@employeeNumber", employee.EmployeeNumber);
            sql.Parameters.AddWithValue("@lastName", employee.LastName);
            sql.Parameters.AddWithValue("@firstName", employee.FirstName);
            sql.Parameters.AddWithValue("@extension", employee.Extension);
            sql.Parameters.AddWithValue("@email", employee.Email);
            sql.Parameters.AddWithValue("@officeCode", employee.OfficeCode);
            sql.Parameters.AddWithValue("@jobTitle", employee.JobTitle);
            sql.Parameters.AddWithValue("@reportsTo", employee.ReportsToId < 0 ? (object)DBNull.Value : employee.ReportsToId);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
        
    }
}
