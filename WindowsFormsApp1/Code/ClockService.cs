﻿using System;
using System.Data;
using System.Data.OleDb;


namespace WindowsFormsApp1
{
    class ClockService
    {
        OleDbConnection myConnection;
        public ClockService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public void SetStartWork(string name)
        {
            try
            {
                myConnection.Open();
                
                string sSql = $"INSERT INTO Clock(ClockName, ClockEntry) VALUES('{name}', Now())";
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
        public void SetEndWork(string name)
        {
            try
            {
                myConnection.Open();

                string sSql = $"UPDATE Clock SET ClockExit = Now() , ClockDiff =DATEDIFF('n', ClockEntry, Now()) WHERE ClockName = '{name}' And ClockExit IS NULL";
                
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
        public DataSet GetClocks()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "SELECT * from Clock";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Clock");
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
        public DataSet GetClocksByMonth(int year, int month, string name)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"SELECT * from Clock Where YEAR(ClockEntry) = {year} AND MONTH(ClockEntry) = {month} AND ClockName = '{name}' ";
                //string sSql = $"SELECT * from Clock Where YEAR(ClockEntry) = {year}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Clock");
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
        public DataSet GetClocksByYear(int year, string name)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"SELECT * from Clock Where YEAR(ClockEntry) = {year} AND ClockName = '{name}' ";
                //string sSql = $"SELECT * from Clock Where YEAR(ClockEntry) = {year}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Clock");
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
        public int IsThereEntry(string name)
        {
            int count = 0;
            string date = DateTime.Now.ToString("MM/dd/yyyy");
            try
            {
                myConnection.Open();
                string sSql = $"SELECT COUNT(*) FROM Clock WHERE ClockName = '{name}' AND DATEVALUE(ClockEntry) = #{date}# AND ClockExit IS NULL";
                
                OleDbCommand checkCommand = new OleDbCommand(sSql, myConnection);
                count = (int)checkCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                myConnection.Close();
            }
            return count;
        }
        
    }
}
