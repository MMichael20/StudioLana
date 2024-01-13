using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

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
        public OleDbDataReader GetAllUsersPhones()
        {

            string sSql = "select UserName & ' ' & UserLName AS FullName, UserPhone, UserDebt from Users";
            OleDbCommand command = new OleDbCommand(sSql, myConnection);
            OleDbDataReader reader = null;

            try
            {
                myConnection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Error: {ex.Message}");
            }

            return reader;
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
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
        public int HighestUser()
        {
            int id = 0;
            string query = "select max(UserId) from Users"; // Replace YourTable with the actual table name
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }

            return id;
        }
        public void InsertUser(User p)
        {
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO Users(UserName, UserLName, UserStreet, UserCity, UserPhone, UserNote, UserDiscount, UserSub, UserEmail, UserDebt) VALUES('" + p.Fname + "', '" + p.LName + "', '" + p.Street + "', " + p.City + ", '" + p.Phone + "', '" + p.Note + "', " + p.Discount + ",'" + p.Sub + "', '" + p.Email + "', '" + p.Debt + "')";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void UpdatetUser(User p)
        {
            try
            {
                myConnection.Open();
                string sSql = "Update Users Set UserName = '" + p.Fname + "', UserLName = '" + p.LName + "', UserStreet = '" + p.Street + "', UserCity = " + p.City + ", UserPhone = '" + p.Phone + "', UserNote = '" + p.Note + "', UserDiscount = " + p.Discount
                    + ", UserSub = '" + p.Sub + "', UserEmail = '" + p.Email + "', UserDebt = " + p.Debt +  " WHERE UserId = " + p.Id;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
        }
        public void SetDebt(int id, int debt)
        {
            try
            {
                myConnection.Open();
                string sSql = $"Update Users Set UserDebt = {debt} WHERE UserId = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
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
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
        
        public DataSet GetUserDebts()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Users, Cities WHERE UserDebt > 0 AND Cities.CityId = Users.UserCity";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Users");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }
    }
}
