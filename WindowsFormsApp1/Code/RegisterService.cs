using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RegisterService
    {
        OleDbConnection myConnection;
        public RegisterService()
        {

            string connectionString = Connect.GetConnectionString();

            myConnection = new OleDbConnection(connectionString);
        }
        public void OpenRegister(int amount)
        {
            string sSql = $"Insert into Register(RegisterDate, Start) VALUES(Now(), {amount})";
            try
            {
                myConnection.Open();
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void AddMoney(int amount, string type)
        {
            string sSql = $"Update Register Set {type} = {type} + {amount} Where ID = (SELECT MAX(ID) FROM Register)";
            try
            {
                myConnection.Open();
                OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public bool isRegisterOpen()
        {
            DateTime date = new DateTime();
            string sSql = "SELECT RegisterDate FROM Register WHERE ID = (SELECT MAX(ID) FROM Register)";
            try
            {
                myConnection.Open();
                OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    date = (DateTime)reader["RegisterDate"];
                }
                if(date.Date == DateTime.Now.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
                
            }
            finally
            {
                myConnection.Close();
            }
        }
        public int SuggestOpen()
        {
            int amount = 0;
            string sSql = "SELECT Start FROM Register WHERE ID = (SELECT MAX(ID) FROM Register)";
            try
            {
                myConnection.Open();
                OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    amount = (int)reader["Start"];
                }
                return amount;
            }
            catch(Exception ex)
            {
                return amount;
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public Register GetTodayRegister()
        {
            Register register = null;
            string sSql = "SELECT * FROM Register WHERE ID = (SELECT MAX(ID) FROM Register)";
            try
            {
                myConnection.Open();
                OleDbCommand cmd = new OleDbCommand(sSql, myConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    register = new Register
                    { 
                        Start = Convert.ToInt32(reader["Start"]),
                        Cash = Convert.ToInt32(reader["Cash"]),
                        Bit = Convert.ToInt32(reader["Bit"]),
                        Paybox = Convert.ToInt32(reader["PayBox"]),
                        Checks = Convert.ToInt32(reader["Checks"]),
                        Credit = Convert.ToInt32(reader["Credit"]),
                        Other = Convert.ToInt32(reader["Other"])
                    };
                }
                return register;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
