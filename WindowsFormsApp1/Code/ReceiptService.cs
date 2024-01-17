using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ReceiptService
    {
        OleDbConnection myConnection;
        public ReceiptService()
        {

            string connectionString = Connect.GetConnectionString();

            myConnection = new OleDbConnection(connectionString);
        }
        public int HighestReceipt()
        {
            int id = 0;
            string query = $"SELECT MAX(Id) FROM Receipts"; // Replace YourTable with the actual table name
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
        public void NewReceipt(Receipt i) 
        {
            string sSql = "INSERT INTO Receipts([User], [Name], Price, ReceiptDate, Type) VALUES" + $"({i.User}, '{i.Name}', {i.Price}, Now(), {i.Type})";
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
        public DataSet GetReceiptById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Types.*, Receipts.Price, Receipts.ReceiptDate, Receipts.Name ,Receipts.Type, Receipts.Printed From Types, Receipts Where Receipts.ID = {id} And Receipts.Type = Types.TypeId";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Receipts");
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
        public void SetReceiptPrinted(int id)
        {
            string sSql = $"Update Receipts SET Printed = True Where ID = {id}";
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
        public DataSet GetAllReceiptsByUserId(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select [ID] as IdColumn, [Name], Price, ReceiptDate as DateColumn, [User] as UserId from Receipts where User = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Receipts");
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
        public DataSet GetReceiptByIdTable(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select [ID] as IdColumn, [User] as UserId ,[Name], Price, ReceiptDate as DateColumn from Receipts where [ID] = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Receipts");
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
        public Receipt GetReceiptCopyById(int id)
        {
            Receipt receipt = null;
            try
            {
                myConnection.Open();
                string sSql = $"SELECT [User] as UserId, Price, Type FROM Receipts WHERE [ID] = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);

                using (OleDbDataReader reader = myCmd.ExecuteReader())
                {
                    // Check if any rows were retrieved
                    if (reader.Read())
                    {
                        // Create a new Receipt object and populate its properties
                        receipt = new Receipt
                        {
                            User = Convert.ToInt32(reader["UserId"]),
                            Price = Convert.ToInt32(reader["Price"]),
                            Type = Convert.ToInt32(reader["Type"])
                        };
                    }
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

            return receipt;
        }
        public void NewReReceipt(List<Receipt> receipts)
        {
            myConnection.Open();
            foreach(Receipt i in receipts)
            {
                string sSql = "INSERT INTO ReReceipts([User], [FullName], Price, FullDate, Type) VALUES" + $"({i.User}, '{i.Name}', {i.Price}, Now(), {i.Type})";
                try
                {
                    OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                    myCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            myConnection.Close();
        }

      
        public int HighestReReceipt()
        {
            int id = 0;
            string query = $"SELECT MAX(Id) FROM ReReceipts"; // Replace YourTable with the actual table name
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
        public int GetReceiptTypeById(int id)
        {
            int type = 6;
            string query = $"SELECT Type FROM Receipts Where [ID] = {id}"; // Replace YourTable with the actual table name
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    type = Convert.ToInt32(result);
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
            return type;
        }
        public DataSet GetReReceiptById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Types.*, ReReceipts.Price, ReReceipts.FullDate, ReReceipts.FullName ,ReReceipts.Type, ReReceipts.Printed From Types, ReReceipts Where ReReceipts.ID = {id} And ReReceipts.Type = Types.TypeId";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "ReReceipts");
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
        public void SetReReceiptPrinted(int id)
        {
            string sSql = $"Update ReReceipts SET Printed = True Where ID = {id}";
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
        public void SetReceiptCanceled(int id)
        {
            string sSql = $"Update Receipts SET Canceled = True Where ID = {id}";
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
        public List<int> CanceledReceipts(List<int> ids)
        {
            List<int> listOfReceipts = new List<int>();
            string listOfIds = string.Join(",", ids);
            string query = $"SELECT ID FROM Receipts WHERE [ID] IN ({listOfIds}) AND Canceled = True";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["ID"]);
                    listOfReceipts.Add(orderId);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return listOfReceipts;
        }
    }
}
