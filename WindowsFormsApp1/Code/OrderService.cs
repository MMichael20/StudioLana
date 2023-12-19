using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


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
        public DataSet GetAllUnpaidOrdersById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select * from Orders where OrderO = {id} and OrderFull = false and OrderStatus <> 'בוטל'";
                
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
                string sSql = $"select Orders.*, Colors.*, Users.UserName, Users.UserId, Items.* from Orders, Colors, Users, Items where OrderO = {id} and OrderDate >= #{DateTime.Now.AddSeconds(-30)}# and OrderDate <= #{DateTime.Now}# AND OrderStatus = 'בטיפול' AND Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
                //string sSql = $"select * from Orders, Users, Colors, Items WHERE OrderO = {id} AND OrderDate >= #{DateTime.Now.AddSeconds(-30)}# and OrderDate <= #{DateTime.Now}# AND OrderStatus = 'בטיפול' and Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
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
                //string sSql = $"select * from Orders, Users, Colors, Items WHERE OrderO = {id} AND OrderDate >= #{DateTime.Now.AddSeconds(-30)}# and OrderDate <= #{DateTime.Now}# AND OrderStatus = 'בטיפול' and Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
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

        public void NewOrder(List<Order> orders)
        {
            myConnection.Open();

            for (int i = 0; i < orders.Count; i++)
            {
                Order p = orders[i];
                string sSql = "INSERT INTO Orders(OrderO, OrderName, OrderColor, OrderDate, OrderAmount, OrderPrice, OrderCab, OrderStatus, OrderFinish, OrderPaid, OrderFull) VALUES" + $"({p.O}, {p.Desc}, {p.Color}, #{p.Date}#, {p.Amount}, {p.Price}, '{p.Cab}', '{p.Status}', #{p.Finish}#, {p.Paid}, {p.Full})";
                // sSql = $"({p.O}, {p.Desc}, {p.Color}, #{p.Date}#, {p.Amount}, {p.Price}, '{p.Cab}', '{p.Status}', #{p.Finish}#, {p.Paid}, {p.Full})";
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
            myConnection.Open();
            int id = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                id = ids[i];
                string sSql = "Update Orders set OrderStatus = '" + status + "' where OrderId = " + id;
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
                    string sSql = $"Update Orders set OrderPaid = {paid}, OrderFull = {full} where OrderId = {orderId} and OrderStatus <> 'בוטל'";
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
            myConnection.Open();
            int id = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                id = ids[i];
                string sSql = "Update Orders set OrderCab = '" + cabin + "' where OrderId = " + id;
                // sSql = $"({p.O}, {p.Desc}, {p.Color}, #{p.Date}#, {p.Amount}, {p.Price}, '{p.Cab}', '{p.Status}', #{p.Finish}#, {p.Paid}, {p.Full})";
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
            myConnection.Open();
            int id = 0;
            for (int i = 0; i < ids.Count; i++)
            {
                id = ids[i];
                string sSql = "Update Orders set OrderStatus = 'נמסר' , OrderDelivered = #" + DateTime.Now + "# where OrderId = " + id;
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
    }
}
