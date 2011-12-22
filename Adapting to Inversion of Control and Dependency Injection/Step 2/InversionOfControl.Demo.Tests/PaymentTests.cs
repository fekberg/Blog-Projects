using InversionOfControl.Payment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InversionOfControl.Demo.Tests
{
    [TestClass]
    public class PaymentTests
    {
        private IPaymentProvider paymentProvider;

        [TestInitialize]
        public void Initialize()
        {
            paymentProvider = new FakePaymentProvider();
        }
        [TestMethod]
        public void OrderFailsWithEmptyInformation()
        {
            var result = paymentProvider.Execute(null);

            Assert.AreEqual(result, PaymentResult.Failure);
        }
        [TestMethod]
        public void OrderSucceedsWithOKInformation()
        {
            var result = paymentProvider.Execute("OK");

            Assert.AreEqual(result, PaymentResult.Success);
        }
    }
}
