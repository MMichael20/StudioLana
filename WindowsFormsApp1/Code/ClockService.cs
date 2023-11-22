using System;
using System.Data;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    class ClockService
    {
        OleDbConnection myConnection;
        public ClockService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public void SetWork(string name, DateTime dateTime, int type)
        {
            try
            {
                myConnection.Open();
                // string sSql = string.Format("INSERT INTO Work (WorkWorker, WorkDate, WorkStatus) VALUES ('{0}', #{1}#, {2})" , name, dateTime, type);
                // string sSql = "Insert into Work(WorkWorker, WorkDate, WorkStatus) Values('" + name + "', #" + dateTime + "#, " + type + ")";
                string sSql = string.Format("INSERT INTO Clock(ClockName, ClockDate, ClockStatus) VALUES('{0}', #{1}#, {2})", name, dateTime, type);
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
            }
        }
    }
}
