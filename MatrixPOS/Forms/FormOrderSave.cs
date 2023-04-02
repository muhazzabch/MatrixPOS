using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                MessageBox.Show("Please enter a valid customer name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCustomerPhone.Text))
            {
                MessageBox.Show("Please enter a valid customer phone number.");
                return;
            }

            CustomerName = textBoxCustomerName.Text;
            CustomerPhone = textBoxCustomerPhone.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
