using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class InvoiceService
    {
        OleDbConnection myConnection;
        public InvoiceService()
        {

            string connectionString = Connect.GetConnectionString();

            myConnection = new OleDbConnection(connectionString);
        }
        public int HighestInvoice()
        {
            int id = 0;
            string query = $"SELECT MAX(InvoiceId) AS MaxValue FROM Invoices"; // Replace YourTable with the actual table name
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
        public void NewInvoice(Invoice i)
        {
            string sSql = "INSERT INTO Invoices(InvoiceUser, InvoiceName, InvoicePrice, InvoiceDate) VALUES" + $"({i.User}, '{i.Name}', {i.Price}, Now())";
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
        public DataSet GetInvoiceById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Invoices.InvoiceName, Invoices.InvoicePrice, Invoices.InvoiceDate, Invoices.InvoicePrinted from Invoices Where Invoices.InvoiceId = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Invoices");
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
        public void SetInvoicePrinted(int id)
        {
            string sSql = $"Update Invoices SET InvoicePrinted = True Where InvoiceId = {id}";
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
        public DataSet GetAllInvoicesByUserId(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select InvoiceId as IdColumn, InvoiceName as Name, InvoicePrice as Price, InvoiceDate as DateColumn, InvoiceUser as UserId from Invoices where InvoiceUser = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Invoices");
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
        public DataSet GetAllInvoicesByIdTable(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select InvoiceId as IdColumn, InvoiceName as Name, InvoicePrice as Price, InvoiceDate as DateColumn, InvoiceUser as UserId from Invoices where InvoiceId = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Invoices");
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
        public DataTable GetAllFinanceById(int id)
        {
            DataTable table = new DataTable();
            string query = $"Select CheckId as IdColumn, CheckName as Name, CheckPrice as Price, CheckDate as DateColumn, 3 as TableName From Checks Where CheckUser = {id}" +
                $" UNION SELECT InvoiceId as IdColumn, InvoiceName as Name, InvoicePrice as Price, InvoiceDate as DateColumn, 2 as TableName FROM Invoices Where InvoiceUser = {id}" +
                $" UNION SELECT [ID] as IdColumn, [Name], Price, ReceiptDate as DateColumn, 1 as TableName FROM RECEIPTS WHERE [User] = {id}" +
                $" Order BY TableName, IdColumn";
            try
            {
                myConnection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, myConnection);
                adapter.Fill(table);
                return table;
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
        public void NewReInvoice(Invoice i)
        {
            string sSql = "INSERT INTO ReInvoices([User], FullName, Price, FullDate) VALUES" + $"({i.User}, '{i.Name}', {i.Price}, Now())";
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
        public List<int> canceledInvoices(List<int> ids)
        {
            List<int> listOfInvoices = new List<int>();
            string listOfIds = string.Join(",", ids);
            string query = $"SELECT InvoiceId FROM Invoices WHERE InvoiceId IN ({listOfIds}) AND Canceled = True";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["InvoiceId"]);
                    listOfInvoices.Add(orderId);
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
            return listOfInvoices;
        }
      
        public Invoice GetInvoiceCopyById(int id)
        {
            Invoice invoice = null;
            try
            {
                myConnection.Open();
                string sSql = $"SELECT InvoiceId, InvoiceUser as UserId, InvoicePrice as Price FROM Invoices WHERE InvoiceId = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);

                using (OleDbDataReader reader = myCmd.ExecuteReader())
                {
                    // Check if any rows were retrieved
                    if (reader.Read())
                    {
                        // Create a new Receipt object and populate its properties
                        invoice = new Invoice
                        {
                            Id = Convert.ToInt32(reader["InvoiceId"]),
                            User = Convert.ToInt32(reader["UserId"]),
                            Price = Convert.ToInt32(reader["Price"]),
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

            return invoice;
        }
        public int HighestReInvoice()
        {
            int id = 0;
            string query = $"SELECT MAX([ID]) FROM ReInvoices"; // Replace YourTable with the actual table name
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
        public void NewReInvoice(List<Invoice> invoices)
        {
            myConnection.Open();
            foreach (Invoice i in invoices)
            {
                string sSql = "INSERT INTO ReInvoices([User], [FullName], Price, FullDate) VALUES" + $"({i.User}, '{i.Name}', {i.Price}, Now())";
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
        public DataSet GetReInvoiceById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select * from ReInvoices Where [ID] = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "ReInvoices");
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
        public void SetInvoiceCanceled(int id)
        {
            string sSql = $"Update Invoices SET Canceled = True Where InvoiceId = {id}";
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
        public void SetReInvoicePrinted(int id)
        {
            string sSql = $"Update ReInvoices SET Printed = True Where [ID] = {id}";
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
    }
}
