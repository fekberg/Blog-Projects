namespace InversionOfControl.Payment
{
    public interface IPaymentProvider
{
    PaymentResult Execute(string paymentData);
}
}
