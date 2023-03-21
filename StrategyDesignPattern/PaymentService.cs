namespace StrategyDesignPattern
{
    public class PaymentService
    {
        private IPaymentMethod _PaymentMethod;

        public PaymentService() { }

        public void SetPaymentMethod(IPaymentMethod PaymentMethod) 
        {
            _PaymentMethod = PaymentMethod;
        }

        public void Pay() 
        {
            _PaymentMethod.Pay();
        }
    }
}
