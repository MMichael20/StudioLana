﻿using System;
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
                string sSql = $"select InvoiceId as IdColumn, InvoiceName as Name, InvoicePrice as Price, InvoiceDate as DateColumn from Invoices where InvoiceUser = {id}";
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
                string sSql = $"select InvoiceId as IdColumn, InvoiceName as Name, InvoicePrice as Price, InvoiceDate as DateColumn from Invoices where InvoiceId = {id}";
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

    }
}
