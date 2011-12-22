using System;
using System.Windows.Forms;
using InversionOfControl.Payment;

namespace InversionOfControl
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void ProcessOrderClick(object sender, EventArgs e)
        {
            ProcessPayment(orderInformation.Text);
        }

        public void ProcessPayment(string orderData)
        {
            var paymentProvider = new PayPalPaymentProvider();
            var result = paymentProvider.Execute(orderData);

            MessageBox.Show(result.ToString());
        }
    }
}
