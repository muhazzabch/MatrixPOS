using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixPOS.Forms
{
    public partial class FormOrderSave : Form
    {
        public string CustomerName { get; private set; }
        public string CustomerPhone { get; private set; }
       
        public FormOrderSave()
        {
            InitializeComponent();
        }
        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCustomerName.Text))
            {
                MessageBox.Show("برائے مہربانی درست نام کا اندراج کریں");
                return;
            }

            // Define the regular expression pattern for a 10-digit phone number
            string phonePattern = @"^\d{11}$";

            // Check if the phone number matches the pattern
            if (!Regex.IsMatch(textBoxCustomerPhone.Text, phonePattern))
            {
                MessageBox.Show("براہ کرم ایک درست 11 ہندسوں والا فون نمبر درج کریں");
                return;
            }

            CustomerName = textBoxCustomerName.Text;
            CustomerPhone = textBoxCustomerPhone.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
