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
using Microsoft.VisualBasic;
using MatrixPOS;


namespace MatrixPOS.Forms
{
  public partial class FormOrders : Form
    {
      public FormOrders()
        {
            InitializeComponent();
        }

        private long total, rate, discount = 0;
        private int sizeY, qty, sequence, totalUnites = 0;
        DataTable _currentBillTable = new DataTable();
        private void FormOrders_Load(object sender, EventArgs e)
        {
            UnitTxt.SelectedIndex = 0;
            QtyNum.Focus();
            _currentBillTable.Columns.Clear();
            _currentBillTable.Rows.Clear();
            //** adding Columns
            _currentBillTable.Columns.Add("#", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("تعداد", Type.GetType("System.Int32"));
            //_currentBillTable.Columns.Add("یونٹ", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("تفصیل", Type.GetType("System.String"));
            _currentBillTable.Columns.Add("صافی", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("ریٹ", Type.GetType("System.Decimal"));
            _currentBillTable.Columns.Add("ڈسکاؤنٹ", Type.GetType("System.Decimal"));
            _currentBillTable.Columns.Add("ٹوٹل", Type.GetType("System.Decimal"));
            dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.MultiSelect = false;
            dataGridViewMain.AllowUserToAddRows = false;
        }
        private void SizeY_ValueChanged(object sender, EventArgs e)
        {
            sizeY = (int)SizeY.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }

        private void RateTxt_ValueChanged(object sender, EventArgs e)
        {
            rate = (int)RateTxt.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }

        private void DiscTxt_ValueChanged(object sender, EventArgs e)
        {
            discount = (int)DiscTxt.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }

        private long Calculate(int _qty, int _sizeY, long _rate, long _discount)
        {
            long ttl = _qty * _sizeY * _rate;
            long discount_ = _qty * _sizeY * _discount;
            ttl = ttl - discount_;
            return ttl;
        }

        private void UnitTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UnitTxt.SelectedIndex == 0)
            {
                RatePerLbl.Text = "ریٹ فی میٹر";
            }
            else RatePerLbl.Text = "ریٹ فی گز";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            sequence++;
            DataRow _item = _currentBillTable.NewRow();
            _item[0] = sequence;
            _item[1] = qty;
            _item[2] = String.Format("{4} {3} = {2} x {1} - {0}",
                DescriptionTxtOpt.Text, QtyNum.Value, SizeY.Value, totalUnites, UnitTxt.Text);
            _item[3] = totalUnites;
            _item[4] = RateTxt.Value;
            _item[5] = DiscTxt.Value;
            _item[6] = total;



            if (!int.TryParse(DiscTxt.Text, out int disc))
            {
                MessageBox.Show("براہ کرم درست ڈسکاونٹ رقم درج کریں", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DiscTxt.Focus();
                return;
            }
            if (disc >= int.Parse(RateTxt.Text))
            {
                MessageBox.Show("ڈسکاؤنٹ، ریٹ سے کم ہونا چاہیے", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DiscTxt.Focus();
                return;
            }
            if (total != 0 )
            {
                _currentBillTable.Rows.Add(_item);
                dataGridViewMain.DataSource = _currentBillTable;
                dataGridViewMain.Columns["تفصیل"].Width = 525;
                Clear();
            }
            else
            {
                MessageBox.Show("ٹوٹل رقم صفر نہیں ہو سکتی", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QtyNum.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var formOrderSave = new FormOrderSave();
            var result = formOrderSave.ShowDialog();

            int _OrdeId = 0; //Declare variable to save ID for Print function

            if (result == DialogResult.OK)
            {
                string customerName = formOrderSave.CustomerName;
                string customerPhone = formOrderSave.CustomerPhone;

                // Establish a connection to the database
                string connectionString = ConfigurationManager.ConnectionStrings["MatrixPOSConnection"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Create an SQL insert query for tblOrders
                    string insertOrdersQuery = "INSERT INTO tblOrders (Customer_Name, Customer_Phone, Bill, Order_Date) VALUES (@Customer_Name, @Customer_Phone, @Bill, GETDATE()); SELECT SCOPE_IDENTITY();";
                    // Create an SQL insert query for tblOrderDetails
                    string insertOrderDetailsQuery = "INSERT INTO tblOrderDetails (Order_ID, Quantity, Detail, Size, Price, Discount, Total) VALUES (@Order_ID, @Quantity, @Detail, @Size, @Price, @Discount, @Total)";
                    // Create a SqlCommand object for executing the SQL queries
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Set the parameters for the insertOrdersQuery
                        command.CommandText = insertOrdersQuery;
                        command.Parameters.AddWithValue("@Customer_Name", customerName);
                        command.Parameters.AddWithValue("@Customer_Phone", customerPhone);
                        command.Parameters.AddWithValue("@Bill", 0);

                        // Execute the SQL insert query for tblOrders and get the generated Order_ID
                        int orderId = Convert.ToInt32(command.ExecuteScalar());
                        //Assign _OrdeId to use that value in print function
                        _OrdeId = orderId;

                        // Set the parameters for the insertOrderDetailsQuery
                        command.CommandText = insertOrderDetailsQuery;
                        //Declare grand Total for Order table field @Bill
                        decimal grandTotal = 0;

                        foreach (DataRow row in _currentBillTable.Rows)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@Order_ID", orderId);
                            command.Parameters.AddWithValue("@Quantity", row["تعداد"]);
                            command.Parameters.AddWithValue("@Detail", row["تفصیل"]);
                            command.Parameters.AddWithValue("@Size", row["صافی"]);
                            command.Parameters.AddWithValue("@Price", row["ریٹ"]);
                            command.Parameters.AddWithValue("@Discount", row["ڈسکاؤنٹ"]);
                            command.Parameters.AddWithValue("@Total", row["ٹوٹل"]);

                            //Add all totals of an order
                            decimal g_total = Convert.ToDecimal(row["ٹوٹل"]);
                            grandTotal += g_total;

                            // Execute the insertOrderDetailsQuery
                            command.ExecuteNonQuery();
                        }
                        // Add the grand total to the tblOrders
                        command.CommandText = "UPDATE tblOrders SET Bill = @Bill WHERE Order_ID = @Order_ID";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Order_ID", orderId);
                        command.Parameters.AddWithValue("@Bill", grandTotal);
                        command.ExecuteNonQuery();

                    }
                }
                DialogResult printable = MessageBox.Show("کیا آپ آرڈر پرنٹ کرنا چاہتے ہیں؟", "پرنٹ آرڈر", MessageBoxButtons.YesNo);
                if (printable == DialogResult.Yes)
                {
                    PrintOrder obj = new PrintOrder(_OrdeId);
                    obj.Print();
                }
            }
        }
   

        private void DeleteRowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.Rows.Count > 0)
                    //int selecteRow = dataGridViewMain.SelectedRows[0].Index;
                    dataGridViewMain.Rows.Remove(dataGridViewMain.SelectedRows[0]);
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            sequence = 0;
            _currentBillTable.Rows.Clear();

        }

        private void Clear()
        {
            total = rate = discount = sizeY = qty = sequence = totalUnites = 0;
            DiscTxt.Value = 0;
            QtyNum.Value = 0;
            RateTxt.Value = 0;
            DescriptionTxtOpt.Text = "";
            SizeY.Value = 0;
            SizeX.Text = "";
            TotalUnits.Text = "";
            TotalTxt.Text = "";

        }

        private void QtyNum_ValueChanged(object sender, EventArgs e)
        {
            qty = (int)QtyNum.Value;

            TotalUnits.Text = (QtyNum.Value * SizeY.Value).ToString();
            SizeX.Text = QtyNum.Value.ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }
    }
}
