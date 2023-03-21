namespace StrategyDesignPattern
{
    public class PaymentMethodA : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payment Method A.");
        }
    }
}
