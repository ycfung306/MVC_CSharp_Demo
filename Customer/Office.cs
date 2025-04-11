using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Project
{
    public class Office
    {
        private string officeCode;
        private string city;
        private string phone;
        private string addressLine1;
        private string addressLine2;
        private string state;
        private string country;
        private string postalCode;
        private string territory;
        public string OfficeCode { get { return officeCode; } set { officeCode = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string AddressLine1 { get { return addressLine1; } set { addressLine1 = value; } }
        public string AddressLine2 { get { return addressLine2; } set { addressLine2 = value; } }
        public string State { get { return state; } set { state = value; } }
        public string Country { get { return country; } set { country = value; } }
        public string PostalCode { get { return postalCode; } set { postalCode = value; } }
        public string Territory { get { return territory; } set { territory = value; } }
        public Office() { }
        public Office(string officeCode, string city, string phone, string addressLine1, string addressLine2, string state, string country, string postalCode, string territory)
        {
            this.officeCode = officeCode;
            this.city = city;
            this.phone = phone;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.state = state;
            this.country = country;
            this.postalCode = postalCode;
            this.territory = territory;
        }
    }

    public class OfficeRepo
    {

        public bool Add(string officeCode, string city, string phone, string addressLine1, string addressLine2, string state, string country, string postalCode, string territory)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("INSERT INTO offices (officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory) VALUES (@officeCode, @city, @phone, @addressLine1, @addressLine2, @state, @country, @postalCode, @territory)", conn);
            sql.Parameters.AddWithValue("@officeCode", officeCode);
            sql.Parameters.AddWithValue("@city", city);
            sql.Parameters.AddWithValue("@phone", phone);
            sql.Parameters.AddWithValue("@addressLine1", addressLine1);
            sql.Parameters.AddWithValue("@addressLine2", addressLine2);
            sql.Parameters.AddWithValue("@state", state);
            sql.Parameters.AddWithValue("@country", country);
            sql.Parameters.AddWithValue("@postalCode", postalCode);
            sql.Parameters.AddWithValue("@territory", territory);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
        public bool Add(Office office)
        {
            return Add(office.OfficeCode, office.City, office.Phone, office.AddressLine1, office.AddressLine2, office.State, office.Country, office.PostalCode, office.Territory);
        }

        public List<Office> GetAll()
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM offices", conn);
            MySqlDataReader reader = sql.ExecuteReader();
            List<Office> offices = new List<Office>();
            while (reader.Read())
            {
                Office office = new Office();
                office.OfficeCode = reader.GetString("officeCode");
                office.City = reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city");
                office.Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? "" : reader.GetString("phone");
                office.AddressLine1 = reader.IsDBNull(reader.GetOrdinal("addressLine1")) ? "" : reader.GetString("addressLine1");
                office.AddressLine2 = reader.IsDBNull(reader.GetOrdinal("addressLine2")) ? "" : reader.GetString("addressLine2");
                office.State = reader.IsDBNull(reader.GetOrdinal("state")) ? "" : reader.GetString("state");
                office.Country = reader.IsDBNull(reader.GetOrdinal("country")) ? "" : reader.GetString("country");
                office.PostalCode = reader.IsDBNull(reader.GetOrdinal("postalCode")) ? "" : reader.GetString("postalCode");
                office.Territory = reader.IsDBNull(reader.GetOrdinal("territory")) ? "" : reader.GetString("territory");
                offices.Add(office);
            }
            conn.Close();
            return offices;
        }

        public Office GetById(int officeCode)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("SELECT * FROM offices WHERE officeCode = @officeCode", conn);
            sql.Parameters.AddWithValue("@officeCode", officeCode);
            MySqlDataReader reader = sql.ExecuteReader();
            Office office = null;
            if (reader.Read())
            {
                office = new Office();
                office.OfficeCode = reader.GetString("officeCode");
                office.City = reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city");
                office.Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? "" : reader.GetString("phone");
                office.AddressLine1 = reader.IsDBNull(reader.GetOrdinal("addressLine1")) ? "" : reader.GetString("addressLine1");
                office.AddressLine2 = reader.IsDBNull(reader.GetOrdinal("addressLine2")) ? "" : reader.GetString("addressLine2");
                office.State = reader.IsDBNull(reader.GetOrdinal("state")) ? "" : reader.GetString("state");
                office.Country = reader.IsDBNull(reader.GetOrdinal("country")) ? "" : reader.GetString("country");
                office.PostalCode = reader.IsDBNull(reader.GetOrdinal("postalCode")) ? "" : reader.GetString("postalCode");
                office.Territory = reader.IsDBNull(reader.GetOrdinal("territory")) ? "" : reader.GetString("territory");
            }
            conn.Close();
            return office;
        }
        public bool Edit(Office office)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("UPDATE offices SET city = @city, phone = @phone, addressLine1 = @addressLine1, addressLine2 = @addressLine2, state = @state, country = @country, postalCode = @postalCode, territory = @territory WHERE officeCode = @officeCode", conn);
            sql.Parameters.AddWithValue("@officeCode", office.OfficeCode);
            sql.Parameters.AddWithValue("@city", office.City);
            sql.Parameters.AddWithValue("@phone", office.Phone);
            sql.Parameters.AddWithValue("@addressLine1", office.AddressLine1);
            sql.Parameters.AddWithValue("@addressLine2", office.AddressLine2);
            sql.Parameters.AddWithValue("@state", office.State);
            sql.Parameters.AddWithValue("@country", office.Country);
            sql.Parameters.AddWithValue("@postalCode", office.PostalCode);
            sql.Parameters.AddWithValue("@territory", office.Territory);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }

        public bool Delete(Office office)
        {
            return this.Delete(office.OfficeCode);
        }
        public bool Delete(string officeCode)
        {
            MySqlConnection conn = Program.GetConnection();
            conn.Open();
            MySqlCommand sql = new MySqlCommand("DELETE FROM offices WHERE officeCode = @officeCode", conn);
            sql.Parameters.AddWithValue("@officeCode", officeCode);
            int result = sql.ExecuteNonQuery();
            conn.Close();
            return result == 1;
        }
    }
}
