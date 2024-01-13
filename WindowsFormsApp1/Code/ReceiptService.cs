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
                string sSql = $"select [ID] as IdColumn, [Name], Price, ReceiptDate as DateColumn from Receipts where User = {id}";
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
                string sSql = $"select [ID] as IdColumn, [Name], Price, ReceiptDate as DateColumn from Receipts where [ID] = {id}";
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
    }
}
