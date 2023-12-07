using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class AppDbContext : DbContext { }
    public static class DatabaseHandler
    {
        private static SqlConnection _connection; //Ændre senere
        private static bool _isConnected = false; //Ændre senere

        public static bool IsConnected { get => _isConnected; set => _isConnected = value; }

        public static bool Create(string? connectionstring = "none")
        {
            if (connectionstring == "none")
                connectionstring = Environment.GetEnvironmentVariable("connectionstring");

            try
            {
                _connection = new SqlConnection(connectionstring);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private static bool Connect()
        {
            if (_connection == null)
                Create();

            try
            {
                _connection.Open();
                IsConnected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        private static bool Disconnect()
        {
            try
            {
                _connection.Close();
                IsConnected = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        public static string GetDBEntry(int pKey, string tablename)
        {
            throw new NotImplementedException();
        }

        public static string GetDatabaseEntries()
        {
            throw new NotImplementedException();
        }

        public static void TryAddDBEntry()
        {
            throw new NotImplementedException();
        }

        public static void TryRemoveDBEntry()
        {
            throw new NotImplementedException();
        }

        public static bool TryUpdateDBEntry()
        {
            throw new NotImplementedException();
        }
    }
}
