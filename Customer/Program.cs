using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {

        public static MySqlConnection GetConnection()
        {
            string host = Properties.Resources.host;
            string db = Properties.Resources.db;
            string userId = Properties.Resources.userId;
            string password = Properties.Resources.password;
            string connStr = $"Server={host};Database={db};User ID={userId};Password={password};Pooling=true;";

            return new MySqlConnection(connStr);
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeView());
        }
    }
}
