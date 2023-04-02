using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixPOS.Forms
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            this.Resize += FormDashboard_Resize;

        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get Orders and sales counts
                string getTodaysOrdersQuery = "SELECT COUNT(*) FROM tblOrders " +
                                              "WHERE CONVERT(date, Order_Date) = CONVERT(date, GETDATE())";

                string get7DaysOrdersQuery = "SELECT COUNT(*) FROM tblOrders " +
                                             "WHERE Order_Date >= DATEADD(day, -7, GETDATE())";

                string getTodaysSale = "SELECT SUM(Bill) FROM tblOrders " +
                                       "WHERE CONVERT(date, order_date) = CONVERT(date, GETDATE())";

                string get7DaysSale = "SELECT SUM(Bill) FROM tblOrders " +
                                      "WHERE order_date >= DATEADD(day, -7, GETDATE())";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Get Today's Orders Count
                    command.CommandText = getTodaysOrdersQuery;
                    int todaysOrders = (int)command.ExecuteScalar();
                    lblTodaysOrders.Text = todaysOrders.ToString();

                    // Get Last 7 Days' Orders Count
                    command.CommandText = get7DaysOrdersQuery;
                    int last7DaysOrders = (int)command.ExecuteScalar();
                    lbl7DaysOrders.Text = last7DaysOrders.ToString();

                    // Get Today's Sales Total
                    command.CommandText = getTodaysSale;
                    object todaysSales = command.ExecuteScalar();
                    if (todaysSales != DBNull.Value)
                    {
                        decimal todaysSalesAmount = (decimal)todaysSales;
                        lblTodaysSale.Text = todaysSalesAmount.ToString();
                    }
                    else
                    {
                        lblTodaysSale.Text = "0.00";
                    }

                    // Get Last 7 Days' Sales Total
                    command.CommandText = get7DaysSale;
                    object last7DaysSales = command.ExecuteScalar();
                    if (last7DaysSales != DBNull.Value)
                    {
                        decimal last7DaysSalesAmount = (decimal)last7DaysSales;
                        lbl7DaysSale.Text = last7DaysSalesAmount.ToString();
                    }
                    else
                    {
                        lbl7DaysSale.Text = "0.00";
                    }

                    // Get the last 7 days of sales data
                    command.CommandText = "SELECT CAST(order_date AS DATE) AS OrderDate, SUM(Bill) AS TotalBill FROM tblOrders WHERE order_date >= DATEADD(day, -6, CAST(GETDATE() AS DATE)) GROUP BY CAST(order_date AS DATE) ORDER BY CAST(order_date AS DATE) ASC;";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            {
                            // Add each data point to the chart series
                            chart1.Series["سیلز"].Points.AddXY(reader.GetDateTime(0), reader.GetDecimal(1));
                        }
                    }

                }
            }
        }


        private void FormDashboard_Resize(object sender, EventArgs e)
        {
            int padding = 20; // Set the padding between panels
            int panelWidth = (this.Width - padding * 5) / 4; // Divide the available width by 4 panels and subtract the padding
            int panelHeight = panelTop1.Height; // Keep the original height of the panels

            panelTop1.Size = new Size(panelWidth, panelHeight);
            panelTop2.Size = new Size(panelWidth, panelHeight);
            panelTop3.Size = new Size(panelWidth, panelHeight);
            panelTop4.Size = new Size(panelWidth, panelHeight);

            panelTop1.Location = new Point(padding, padding);
            panelTop2.Location = new Point(panelWidth + padding * 2, padding);
            panelTop3.Location = new Point(panelWidth * 2 + padding * 3, padding);
            panelTop4.Location = new Point(panelWidth * 3 + padding * 4, padding);
        }
    }
}
