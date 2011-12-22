using Ninject.Modules;
using InversionOfControl.Payment;

namespace InversionOfControl
{
    public class PaymentProviderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPaymentProvider>().To<FakePaymentProvider>();
        }
    }
}
