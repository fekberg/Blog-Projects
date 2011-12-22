namespace InversionOfControl.Payment
{
    public class FakePaymentProvider : IPaymentProvider
    {
        public PaymentResult Execute(string paymentData)
        {
            if (paymentData == "OK") return PaymentResult.Success;
        
            return PaymentResult.Failure;
        }
    }
}
