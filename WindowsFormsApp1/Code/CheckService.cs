using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    class CheckService
    {
        OleDbConnection myConnection;
        public CheckService()
        {
            string connectionString = Connect.GetConnectionString();
            myConnection = new OleDbConnection(connectionString);
        }
        public void NewCheck(Check p)
        {
            try
            {
                myConnection.Open();
                string sSql = "INSERT INTO Checks(CheckName, CheckUser, CheckPrice, CheckDate, CheckType) VALUES('" + p.Name + "'," + p.User + "," + p.Price + ",#" + p.Date + "#," + p.Type + ")";
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
        public DataSet GetAllChecksByType(int t)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks WHERE CheckType = " + t;
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public DataSet GetAllChecksByTypeAndId(int t, int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select * from Checks WHERE CheckType = {t} AND CheckUser = {id}";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public DataSet GetAllChecks()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select Checks.*, Types.*, Users.*,  Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Checks, Types, Users WHERE Users.UserId = Checks.CheckUser AND Types.TypeId = Checks.CheckType";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public DataSet GetAllPrices()
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select CheckPrice, CheckDate from Checks";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public DataSet GetAllChecksById(int id)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = $"select Checks.*, Types.*, Users.*,  Users.UserName + ' ' + Users.UserLName + ' (' + CStr(Users.UserId) + ') ' AS FullName from Checks, Types, Users WHERE CheckUser = {id} AND Users.UserId = Checks.CheckUser AND Types.TypeId = Checks.CheckType";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public void SortChecks()
        {
            try
            {
                myConnection.Open();
                DateTime pastDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-12);
                string formatted = pastDate.ToString("MM/dd/yyyy");
                string sSql = "SELECT Year(CheckDate) AS PaymentYear, Month(CheckDate) AS PaymentMonth, SUM(CheckPrice) AS TotalPaidAmount " +
                                  "FROM Checks " +
                                  $"WHERE CheckDate >= #{formatted}# " + // Filter for the past 12 months
                                  "GROUP BY Year(CheckDate), Month(CheckDate)";

                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataReader reader = myCmd.ExecuteReader();
                while (reader.Read())
                {
                    int year = Convert.ToInt32(reader["PaymentYear"]);
                    int month = Convert.ToInt32(reader["PaymentMonth"]);
                    decimal totalAmount = Convert.ToDecimal(reader["TotalPaidAmount"]);

                    MessageBox.Show($"Year: {year}, Month: {month}, Total Paid Amount: {totalAmount}");
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
        }
        public static Chart GenerateChart()
        {
            string connectionString = Connect.GetConnectionString();
            Chart chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                DateTime pastDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-12);
                string formatted = pastDate.ToString("MM/dd/yyyy");
                string sSql = "SELECT Year(CheckDate) AS PaymentYear, Month(CheckDate) AS PaymentMonth, SUM(CheckPrice) AS TotalPaidAmount " +
                                  "FROM Checks " +
                                  $"WHERE CheckDate >= #{formatted}# " + // Filter for the past 12 months
                                  "GROUP BY Year(CheckDate), Month(CheckDate)";

                OleDbCommand command = new OleDbCommand(sSql, connection);
                chart.Series.Add("Values");                
                try
                {
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int year = Convert.ToInt32(reader["PaymentYear"]);
                        int month = Convert.ToInt32(reader["PaymentMonth"]);
                        decimal totalAmount = Convert.ToDecimal(reader["TotalPaidAmount"]);
                        chart.Series["Values"].Points.AddXY($"{month},{year - 2000}", totalAmount);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }
            chart.Series["Values"].ChartType = SeriesChartType.Column;
            return chart;
        }

        public DataSet GetAllChecksByDate(DateTime date)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks, Types, Users WHERE CheckDate between #" + date +"# And #" +DateTime.Now+"# And Users.UserId = Checks.CheckUser AND Types.TypeId = Checks.CheckType";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
        public DataSet GetAllChecksByTypeAndDate(int t, DateTime date)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string sSql = "select * from Checks WHERE CheckType = " + t + " AND CheckDate between #" + date + "# And #" + DateTime.Now + "#";
                OleDbCommand myCmd = new OleDbCommand(sSql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset, "Checks");
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
