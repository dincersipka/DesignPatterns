namespace StrategyDesignPattern
{
    public class PaymentMethodB : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Payment Method B.");
        }
    }
}
