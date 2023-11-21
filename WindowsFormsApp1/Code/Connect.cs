using System;
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
            string ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase\Sveta.accdb; Persist Security Info = False;";

            return ConnectionString;
        }
        public Connect() {
        }
    }
}
