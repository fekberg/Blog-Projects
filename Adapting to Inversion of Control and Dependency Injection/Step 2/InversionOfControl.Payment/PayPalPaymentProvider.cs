namespace InversionOfControl.Payment
{
public enum PaymentResult
{
    Success,
    Failure
}
public class PayPalPaymentProvider : IPaymentProvider
{
    public PaymentResult Execute(string paymentData)
    {
        if (string.IsNullOrEmpty(paymentData)) return PaymentResult.Failure;
        return PaymentResult.Success;
    }
}
}