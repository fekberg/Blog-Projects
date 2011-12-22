using System;
using System.Windows.Forms;
using InversionOfControl.Payment;
using Ninject;

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
            var kernel = new StandardKernel(new PaymentProviderModule());

            ProcessPayment(orderInformation.Text, kernel.Get<IPaymentProvider>());
        }

        public void ProcessPayment(string orderData, IPaymentProvider paymentProvider)
        {
            var result = paymentProvider.Execute(orderData);

            MessageBox.Show(result.ToString());
        }
    }
}
