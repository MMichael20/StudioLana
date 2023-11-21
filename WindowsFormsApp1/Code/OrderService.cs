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
                string sSql = "select * from Orders, Users, Colors, Items WHERE Colors.ColorId = Orders.OrderColor AND Users.UserId = Orders.OrderO AND Items.ItemId = Orders.OrderName";
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

        public void NewOrder(Order p)
        {
            int id =p.Id;
            int o = p.O;
            int desc = p.Desc;
            int color = p.Color;
            DateTime date = p.Date;
            int amount = p.Amount;
            int price = p.Price;
            int cab = p.Cab;
            string status = p.Status;
            DateTime finish = p.Finish;

            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO Orders(OrderO, OrderName, OrderColor, OrderDate, OrderAmount, OrderPrice, OrderCab, OrderStatus, OrderFinish) VALUES(" + o + "," + desc + " ," + color + ",#" + date+ "#, " + amount+ "," + price+ "," + cab+ ",'" + status + "', #" + finish +"#)";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                myConnection.Close();
            }
        }
        public void UpdateStatus(int id, string status)
        {

            try
            {
                myConnection.Open();
                string sSql = "Update Orders set OrderStatus = '" + status + "' where OrderId = " + id ;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                myCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
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

    }
}
