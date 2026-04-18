using System;
using System.Data.SqlClient;

namespace DAL
{
    public static class DatabaseConnection
    {
        // ⚠️ CAMBIA ESTO según tu servidor
        private static string connectionString = @"Server=DIEGO\SQLEXPRESS;Database=SuperCashDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
    }
}