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
using MatrixPOS;

namespace MatrixPOS.Forms
{
    public partial class FormOrderDetails : Form
    {
        private int _orderId;
        private DataTable _orderDetailsTable = new DataTable();

        public FormOrderDetails(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            _orderDetailsTable.Columns.Clear();
            _orderDetailsTable.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string query = "SELECT Quantity, Detail, Size, Price, Discount, Total FROM tblOrderDetails WHERE Order_ID = @OrderID";
            string _connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", SqlDbType.Int).Value = _orderId;

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(_orderDetailsTable);
                    }
                }
            }
            _orderDetailsTable.Columns["Quantity"].ColumnName = "تعداد";
            _orderDetailsTable.Columns["Detail"].ColumnName = "تفصیل";
            _orderDetailsTable.Columns["Size"].ColumnName = "صافی";
            _orderDetailsTable.Columns["Price"].ColumnName = "قیمت";
            _orderDetailsTable.Columns["Discount"].ColumnName = "رعایت";
            _orderDetailsTable.Columns["Total"].ColumnName = "ٹوٹل";

            dataGridView1.DataSource = _orderDetailsTable;

            dataGridView1.Columns["تعداد"].Width = 150;
            dataGridView1.Columns["تفصیل"].Width = 300;
            dataGridView1.Columns["صافی"].Width = 150;
            dataGridView1.Columns["قیمت"].Width = 150;
            dataGridView1.Columns["رعایت"].Width = 150;
            dataGridView1.Columns["ٹوٹل"].Width = 166;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintOrder obj = new PrintOrder(_orderId);
            obj.Print();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("کیا آپ واقعی اس آرڈر کو ڈیلیٹ کرنا چاہتے ہیں؟", "ڈیلیٹ آرڈر", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete the order from tblOrderDetails
                    string deleteOrderDetailsQuery = "DELETE FROM tblOrderDetails WHERE Order_ID = @OrderID";
                    using (SqlCommand command = new SqlCommand(deleteOrderDetailsQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", _orderId);
                        command.ExecuteNonQuery();
                    }

                    // Delete the order from tblOrders
                    string deleteOrderQuery = "DELETE FROM tblOrders WHERE Order_ID = @OrderID";
                    using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", _orderId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("آرڈر کامیابی کے ساتھ ڈیلیٹ ہو گیا۔");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
