using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;


class PrintOrder
{
    private int orderID;
    private SqlConnection connection;
    private SqlCommand command;
    private SqlDataReader reader;
    private PrintDocument printDocument;
    private PrintDialog printDialog;

    public PrintOrder(int orderID)
    {
        this.orderID = orderID;

        // Establish a connection to the database
        string connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;
        connection = new SqlConnection(connectionString);
        connection.Open();

        // Create an SQL command to retrieve the data from tblOrderDetails
        string query = "SELECT [Quantity] ,[Detail],[Price],[Total] FROM tblOrderDetails WHERE Order_ID = @Order_ID";
        command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Order_ID", orderID);

        // Create a PrintDocument object
        printDocument = new PrintDocument();
        printDocument.PrintPage += PrintDocument_PrintPage;

        // Create a PrintDialog object
        printDialog = new PrintDialog();
        printDialog.Document = printDocument;
        printDialog.AllowSomePages = true;
        printDialog.ShowHelp = true;

        // Set the printer settings
        printDocument.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
    }

    public void Print()
    {
        // Show the print dialog and print the document if the user clicks OK
        if (printDialog.ShowDialog() == DialogResult.OK)
        {
            printDocument.Print();
            MessageBox.Show("آرڈر کامیابی سے پرنٹ ہو گیا ہے", "آرڈر پرنٹ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        // Set the font and brush for the header and data
        Font headerFont = new Font("Jameel Noori Nastaleeq", 14, FontStyle.Bold);
        Brush headerBrush = Brushes.Black;
        Font dataFont = new Font("Jameel Noori Nastaleeq", 12);
        Brush dataBrush = Brushes.Black;

        // Set the margin and line height
        int margin = 100;
        int lineHeight = 20;

        // Print the data
        int y = margin + lineHeight * 2;
        //Titles for values
        e.Graphics.DrawString("تعداد", headerFont, headerBrush, margin + 550, y);
        e.Graphics.DrawString("تفصیل", headerFont, headerBrush, margin + 400, y);
        e.Graphics.DrawString("قیمت", headerFont, headerBrush, margin + 300, y);
        e.Graphics.DrawString("ٹوٹل", headerFont, headerBrush, margin + 200, y);

        y += lineHeight;
        command.CommandType = System.Data.CommandType.Text;
        reader = command.ExecuteReader();
        decimal total = 0;

        while (reader.Read())
        {
            int quantity = (int)reader["Quantity"];
            string detail = (string)reader["Detail"];
            decimal unitPrice = (decimal)reader["Price"];
            decimal totalPrice = (decimal)reader["Total"];

            e.Graphics.DrawString(quantity.ToString(), dataFont, dataBrush, margin + 560, y);
            e.Graphics.DrawString(detail, dataFont, dataBrush, margin + 370, y);
            e.Graphics.DrawString(unitPrice.ToString(), dataFont, dataBrush, margin + 290, y);
            e.Graphics.DrawString(totalPrice.ToString(), dataFont, dataBrush, margin + 190, y);

            y += lineHeight;
            total += totalPrice;
        }

        // Draw footer
        e.Graphics.DrawString("ٹوٹل", dataFont, headerBrush, margin + 550, y);
        e.Graphics.DrawString(total.ToString("c"), dataFont, headerBrush, margin + 190, y);

        // Close the reader and the connection
        reader.Close();
        connection.Close();
    }
}