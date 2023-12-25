using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    class ShopService
    {
        OleDbConnection myConnection;
        public ShopService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public DataSet ShopList()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Shop WHERE ShopBought = False";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Shop");
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
        public void NewShop(Shop p)
        {
            try
            {
                myConnection.Open();
                string sSql = $"INSERT INTO Shop(ShopName, ShopNote, ShopAmount, ShopDate) VALUES('{p.Name}', '{p.Note}', {p.Bought}, #{p.Date}#)";
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
        public void isBought(List<int> ids)
        {
            myConnection.Open();
            for (int i = 0; i < ids.Count; i++)
            {
                string sSql = "Update Shop set ShopBought = true where ShopId = " + ids[i];
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
    }
}
