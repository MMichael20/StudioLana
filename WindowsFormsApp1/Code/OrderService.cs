using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class OrderService
    {
        OleDbConnection myConnection;
        public OrderService()
        {

            string connectionString = Connect.GetConnectionString();

            myConnection = new OleDbConnection(connectionString);
        }
        public DataSet GetOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Orders, Users, Colors, Items where OrderO = " + id + "AND OrderStatus = 'בטיפול' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetAllOrders()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select *, Users.UserName & ' ' & Users.UserLName AS FullName from Orders, Users, Colors, Items WHERE Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName ";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetAllOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Orders, Users, Colors, Items WHERE OrderO = " + id + " AND  Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetAllUnfinishedOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select  Orders.*, Users.*, Colors.*, Items.* , Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Orders, Users, Colors, Items where (OrderStatus = 'בטיפול' OR  OrderStatus = 'מוכן') AND OrderO = " + id + " AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetAllUnpaidOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select * from Orders where OrderO = {id} and OrderFull = false AND OrderPaid = 0 and OrderStatus <> 'בוטל' And OrderInvoice = 1 and OrderCheck = 1";
                
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetCheckPrint(int check)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderCheck = {check} AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetInvoicePrint(int invoice)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderInvoice = {invoice} AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetAllInvoicelessOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select * from Orders where OrderO = {id} and OrderFull = false AND OrderPaid > 0 and OrderStatus <> 'בוטל' And OrderInvoice = 1 and OrderCheck = 1";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetOrderPrint(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderO = {id} and OrderDate >= Now()-#0:0:30# and OrderDate <= Now() AND OrderStatus = 'בטיפול' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetOrderPrintByIds(List<int> ids)
        {
            string stringIds = string.Join(",", ids);
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderId IN ({stringIds}) AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public Dictionary<string, decimal> OrderMonthReport(int month, int year)
        {
            Dictionary<string, decimal> results = new Dictionary<string, decimal>();
            OleDbDataReader reader = null;
            string query = $"SELECT " +
                         $"SUM(IIF(Month(OrderDate) = {month} AND Year(OrderDate) = {year}, OrderAmount, 0)) AS AmountSum, " +
                         $"SUM(IIF(Month(OrderDate) = {month} AND Year(OrderDate) = {year}, OrderPaid, 0)) AS PaidSum, " +
                         $"SUM(IIF(Month(OrderDate) = {month} AND Year(OrderDate) = {year}, OrderPrice, 0)) AS PriceSum " +
                         $"FROM Orders";
            OleDbCommand cmd = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    decimal amountSum = Convert.ToDecimal(reader["AmountSum"] != DBNull.Value ? reader["AmountSum"] : 0);
                    decimal paidSum = Convert.ToDecimal(reader["PaidSum"] != DBNull.Value ? reader["PaidSum"] : 0);
                    decimal priceSum = Convert.ToDecimal(reader["PriceSum"] != DBNull.Value ? reader["PriceSum"] : 0);

                    results.Add("AmountSum", amountSum);
                    results.Add("PaidSum", paidSum);
                    results.Add("PriceSum", priceSum);

                }
                return results;
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
        public void NewOrder(List<Order> orders)
        {
            myConnection.Open();

            for (int i = 0; i < orders.Count; i++)
            {
                Order p = orders[i];
                string sSql = "INSERT INTO Orders(OrderO, OrderName, OrderColor, OrderDate, OrderAmount, OrderPrice, OrderCab, OrderStatus, OrderFinish, OrderPaid, OrderFull, OrderInvoice, OrderCheck) VALUES" + $"({p.O}, {p.Desc}, {p.Color}, Now(), {p.Amount}, {p.Price}, '{p.Cab}', '{p.Status}', #{p.Finish.ToString("MM/dd/yyyy")}#, {p.Paid}, {p.Full}, {p.Invoice}, {p.Check})";
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
        public void UpdateStatus(List<int> ids, string status)
        {
            string listOfIds = string.Join(",", ids);
            string sSql = $"Update Orders set OrderStatus = '{status}' where OrderId IN ({listOfIds})";
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
        public void PayForOrders(int id, int amount)
        {
            try
            {
                myConnection.Open();
                string sSql = $"Update Orders set OrderPaid = {amount} where OrderId = {id}";
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
        public void Pay(List<int[]> listId)
        {
            myConnection.Open();
            int orderId = 0;
            int paid = 0;
            bool full = false;
            for (int i = 0; i < listId.Count; i++)
            {
                foreach (int[] item in listId)
                {
                    orderId = item[0];
                    paid = item[1];
                    if (item[2] == 1)
                    {
                        full = true;
                    }
                    else
                    {
                        full = false;
                    }
                    string sSql = $"Update Orders set OrderPaid = {paid}, OrderFull = {full} where OrderId = {orderId}";
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
            }
            myConnection.Close();
        }
        public void CloseDebt(int id, int amount)
        {
            try
            {
                myConnection.Open();
                string sSql = $"Update Orders set OrderPaid = {amount}, OrderFull = True where OrderId = {id}";
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
        public void UpdateFull(int id)
        {
            try
            {
                myConnection.Open();
                string sSql = $"Update Orders set OrderFull = True where OrderId = {id}";
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
        public DataSet GetFinishById(int o)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Orders, Users, Colors, Items where OrderO = " + o + "AND OrderStatus = 'מוכן' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public DataSet GetUnfinished()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select  Orders.*, Users.*, Colors.*, Items.* , Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Orders, Users, Colors, Items  where OrderStatus = '" + "בטיפול" + "' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName ORDER BY OrderFinish ASC";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public void SetCabin(List<int> ids, string cabin)
        {
            string listOfIds = string.Join(",", ids);
            string sSql = $"Update Orders set OrderCab = '{cabin}' where  OrderId IN ({listOfIds})";
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
        public DataSet GetAllSent()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select  Orders.*, Users.*, Colors.*, Items.* , Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Orders, Users, Colors, Items where OrderStatus = 'נמסר' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public void Deliver(List<int> ids)
        {
            string listOfIds = string.Join(",", ids);
            string sSql = $"Update Orders set OrderStatus = 'נמסר' , OrderDelivered = Now() where OrderId IN ({listOfIds})";
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
        public DataSet GetAllSentById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select  Orders.*, Users.*, Colors.*, Items.* , Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Orders, Users, Colors, Items where OrderStatus = 'נמסר' AND OrderO = " + id + " AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
        public List<int> ListOfInvoices(List<int> ids)
        {
            List<int> listOfInvoices = new List<int>();
            string listOfIds = string.Join(",", ids);
            string query = $"SELECT OrderId FROM Orders WHERE OrderId IN ({listOfIds}) AND (OrderInvoice <> 1 or OrderCheck <> 1)";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["OrderId"]);
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
        public int OrdersPriceSum(List<int> ids)
        {
            int total = 0;
            string stringIds = string.Join(",", ids);
            string query = $"SELECT SUM(OrderPrice) AS TotalPrice FROM Orders WHERE OrderID IN ({stringIds})";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    total = Convert.ToInt32(result);
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
            return total;
        }
        public void UpdateOrdersInvoice(List<int> ids, int invoiceId)
        {
            string stringIds = string.Join(",", ids);
            string query = $"UPDATE Orders SET OrderInvoice = {invoiceId} WHERE OrderId IN ({stringIds})";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                command.ExecuteNonQuery();
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
        public void SetOrdersCheck(List<int> ids, int CheckId)
        {
            string stringIds = string.Join(",", ids);
            string sSql = $"UPDATE Orders SET OrderCheck = {CheckId}, OrderFull = True, OrderPaid = OrderPrice WHERE OrderId IN ({stringIds})";
            myConnection.Open();
            try
            {
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
        public DataSet NeedsReceipt(int id)
        {
            string query = $"SELECT * FROM Orders WHERE OrderFull = False and OrderO = {id} and OrderInvoice <> 1 and OrderCheck = 1 and OrderStatus <> 'בוטל'";
            DataSet dataSet = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            try
            {
                myConnection.Open();
                dataAdapter.Fill(dataSet, "Orders");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataSet;
        }
        public DataSet ReceiptRefund(int id)
        {
            string query = $"SELECT * FROM Orders WHERE OrderO = {id} and OrderCheck = 1 and OrderPaid > 0 AND OrderStatus <> 'בוטל' ORDER BY OrderDate DESC";
            DataSet dataSet = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnection);
            try
            {
                myConnection.Open();
                dataAdapter.Fill(dataSet, "Orders");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return dataSet;
        }
        public void Refund(List<int[]> listId)
        {
            myConnection.Open();
            int orderId = 0;
            int paid = 0;
            for (int i = 0; i < listId.Count; i++)
            {
                foreach (int[] item in listId)
                {
                    orderId = item[0];
                    paid = item[1];
                    string sSql = $"Update Orders set OrderPaid = {paid}, OrderFull = False where OrderId = {orderId}";
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
            }
            myConnection.Close();
        }
        public List<int> OrdersPaid(List<int> ids)
        {
            List<int> listOfOrders = new List<int>();
            string listOfIds = string.Join(",", ids);
            string query = $"SELECT OrderId FROM Orders WHERE OrderId IN ({listOfIds}) AND OrderPaid > 0";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["OrderId"]);
                    listOfOrders.Add(orderId);
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
            return listOfOrders;
        }
        public List<int> OrdersPaidByInvoice(List<int> ids)
        {
            List<int> listOfOrders = new List<int>();
            string listOfIds = string.Join(",", ids);
            string query = $"SELECT OrderInvoice FROM Orders WHERE OrderInvoice IN ({listOfIds}) AND OrderPaid > 0";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try
            {
                myConnection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int orderInvoice = Convert.ToInt32(reader["orderInvoice"]);
                    listOfOrders.Add(orderInvoice);
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
            return listOfOrders;
        }
        public void SetOrdersReInvoiceByInvoice(int InvoiceId, int reInvoiceId)
        {
            string sSql = $"UPDATE Orders SET OrderInvoice = 1, OrderReInvoice = {reInvoiceId}, OrderStatus = 'בוטל' WHERE OrderInvoice = {InvoiceId}";
            myConnection.Open();
            try
            {
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
        public void SetOrdersReInvoiceByCheck(int CheckId, int reInvoiceId)
        {
            string sSql = $"UPDATE Orders SET OrderCheck = 1, OrderReInvoice = {reInvoiceId}, OrderStatus = 'בוטל' WHERE OrderCheck = {CheckId}";
            myConnection.Open();
            try
            {
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
        public DataSet GetReInvoicePrint(int reInvoice)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderReInvoice = {reInvoice} AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Orders");
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
