using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class Connect
    {
        const string FileName = "Sveta.accdb";
        public static string GetConnectionString()
        {
            //string ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase\Sveta.accdb; Persist Security Info = False;";
            string ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =G:\_PROJECT_\DataBase\Sveta2.accdb; Persist Security Info = False;";
            //try
            //{
            //    OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder(ConnectionString);
            //    string databasePath = builder.DataSource;

            //    // Get the absolute path if it's a relative path
            //    string absolutePath = Path.GetFullPath(databasePath);

            //    Choose.location = ($"The database is located at: {absolutePath}");
            //}
            //catch (Exception ex)
            //{
            //    Choose.location = ($"Error: {ex.Message}");
            //}

            return ConnectionString;
        }
        public Connect() {
        }
    }
}
