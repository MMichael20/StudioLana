using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class CheckService
    {
        OleDbConnection myConnection;
        public CheckService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public void NewCheck(Check p)
        {
            string name = p.Name;
            int o = p.User;
            int price = p.Price;
            DateTime date = p.Date;
            int type = p.Type;
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO Checks(CheckName, CheckUser, CheckPrice, CheckDate, CheckType) VALUES('" + name + "'," + o + "," + price + ",#" + date + "#," + type + ")";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
            }
        }
        public DataSet GetAllChecksByType(int t)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks WHERE CheckType = " + t;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
        public DataSet GetAllChecks()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks, Types, Users WHERE Users.UserId = Checks.CheckUser AND Types.TypeId = Checks.CheckType";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
        public DataSet GetAllChecksByDate(DateTime date)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks, Types, Users WHERE CheckDate between #" + date +"# And #" +DateTime.Now+"# And Users.UserId = Checks.CheckUser AND Types.TypeId = Checks.CheckType";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
        public DataSet GetAllChecksByTypeAndDate(int t, DateTime date)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks WHERE CheckType = " + t + " AND CheckDate between #" + date + "# And #" + DateTime.Now + "#";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
    }

}
