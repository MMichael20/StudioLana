using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    class UserService
    {
        OleDbConnection myConnection;
        public UserService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public DataSet GetUserById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Users where UserId = " + id;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
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

        public DataSet GetUsers()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select UserId, UserName, UserLName, CityName, UserPhone from Cities, Users WHERE Cities.CityId = Users.UserCity";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
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
        public DataSet HighestUser()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select max(UserId) from Users";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
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
        public void InsertUser(User p)
        {
            string fname = p.Fname;
            string ln = p.LName;
            string street = p.Street;
            int city = p.City;
            string pn = p.Phone;
            string note = p.Note;
            int dis = p.Discount;
            string sub = p.Sub;
            string email = p.Email;
            double debt = p.Debt;
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO Users(UserName, UserLName, UserStreet, UserCity, UserPhone, UserNote, UserDiscount, UserSub, UserEmail, UserDebt) VALUES('" + fname + "', '" + ln + "', '" + street + "', " + city + ", '" + pn + "', '" + note + "', " + dis + ",'" + sub + "', '" + email + "', '" + debt + "')";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
            }
        }
        public void UpdatetUser(User p)
        {
            int id = p.Id;
            string fname = p.Fname;
            string ln = p.LName;
            string street = p.Street;
            int city = p.City;
            string pn = p.Phone;
            string note = p.Note;
            int dis = p.Discount;
            string sub = p.Sub;
            string email = p.Email;
            double debt = p.Debt;
            try
            {
                myConnection.Open();
                string sSql = "Update Users Set UserName = '" + fname + "', UserLName = '" + ln + "', UserStreet = '" + street + "', UserCity = " + city + ", UserPhone = '" + pn + "', UserNote = '" + note + "', UserDiscount = " + dis
                    + ", UserSub = '" + sub + "', UserEmail = '" + email + "', UserDebt = " + debt +  " WHERE UserId = " + id;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
            }
        }
        public void SetDebt(double id, double debt)
        {
            try
            {
                myConnection.Open();
                string sSql = "Update Users Set UserDebt = UserDebt + " + debt + " WHERE UserId = " + id;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }

            catch (Exception ex)

            {
                myConnection.Close();
            }
        }
        public DataSet GetDebt(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select UserDebt from Users Where UserId =" + id;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
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
