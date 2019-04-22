using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MyLibraryClient
{
    class Bridge
    {
        public static Bridge bridge = null;
        public string DataSource { get; private set; }
        public string InitialCatalog { get; private set; }
        public string UserId { get; private set; }
        private string Password { get; set; }
        public Bridge(string user, string password)
        {
            DataSource = @"D114\SQLEXPRESS";
            InitialCatalog = "MyLibrary";
            UserId = user;
            Password = password;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        public string GetConnectionString()
        {
            return $"data source={DataSource};initial catalog={InitialCatalog};User id={UserId};password={Password}";
        }
    }
}
