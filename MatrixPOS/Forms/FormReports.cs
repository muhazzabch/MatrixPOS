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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }
        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadFormSettings();
        }
        private void LoadFormSettings()
        {
            ComboBoxSearchBy.SelectedIndex = 0;
            txtBoxSearch.Focus();
            txtBoxSearch.Clear();
            _ordersTable.Clear();
            _ordersTable.Columns.Clear();
            _ordersTable.Rows.Clear();
        }

        DataTable _ordersTable = new DataTable();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the DataTable and the DataGridView
                _ordersTable.Clear();
                _ordersTable.Columns.Clear();
                _ordersTable.Rows.Clear();
                dataGridView1.DataSource = null;

                // Define the search query
                string query = "";
                if (ComboBoxSearchBy.SelectedIndex == 0)
                {
                    query = "SELECT * FROM tblOrders WHERE Order_ID = @OrderID";
                }
                else if (ComboBoxSearchBy.SelectedIndex == 1)
                {
                    query = "SELECT * FROM tblOrders WHERE Customer_Phone = @CustomerPhone";
                }

                string _connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;
                // Create a new SqlConnection and SqlCommand
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameters to the SqlCommand
                        if (ComboBoxSearchBy.SelectedIndex == 0)
                        {
                            int orderId;
                            if (int.TryParse(txtBoxSearch.Text, out orderId))
                            {
                                command.Parameters.AddWithValue("@OrderID", SqlDbType.Int).Value = orderId;
                            }
                            else
                            {
                                MessageBox.Show("براہ کرم درست آرڈر آئ ڈی درج کریں۔", "غلط ان پٹ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (ComboBoxSearchBy.SelectedIndex == 1)
                        {
                            if (!string.IsNullOrEmpty(txtBoxSearch.Text))
                            {
                                command.Parameters.AddWithValue("@CustomerPhone", SqlDbType.NVarChar).Value = txtBoxSearch.Text;
                            }
                            else
                            {
                                MessageBox.Show("براہ کرم درست کسٹمر فون درج کریں۔", "غلط ان پٹ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Open the SqlConnection and execute the query
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(_ordersTable);
                        }
                    }
                }
                // Map the database column names to custom column names
                _ordersTable.Columns["Order_ID"].ColumnName = "آرڈر نمبر";
                _ordersTable.Columns["Customer_Name"].ColumnName = "کسٹمر کا نام";
                _ordersTable.Columns["Customer_Phone"].ColumnName = "کسٹمر کا فون";
                _ordersTable.Columns["Bill"].ColumnName = "ٹوٹل بل";
                _ordersTable.Columns["Order_Date"].ColumnName = "آرڈر کی تاریخ";
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = _ordersTable;

                // Set the columns width
                dataGridView1.Columns["آرڈر نمبر"].Width = 150;
                dataGridView1.Columns["کسٹمر کا نام"].Width = 250;
                dataGridView1.Columns["کسٹمر کا فون"].Width = 220;
                dataGridView1.Columns["ٹوٹل بل"].Width = 250;
                dataGridView1.Columns["آرڈر کی تاریخ"].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row was clicked
            {
                int orderId = (int)dataGridView1.Rows[e.RowIndex].Cells["آرڈر نمبر"].Value;
                FormOrderDetails orderDetailsForm = new FormOrderDetails(orderId);
                // Create form closing event to To Load Form settings
                orderDetailsForm.FormClosing += OrderDetailsForm_FormClosing;
                orderDetailsForm.Show();
            }
        }
        private void OrderDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                LoadFormSettings();
            }
        }

    }
}
