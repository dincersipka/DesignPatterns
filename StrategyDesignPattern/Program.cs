namespace StrategyDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaymentService Service = new PaymentService();

            while (true) 
            {
                Console.WriteLine("Select payment method: \n1- Method A\n2- Method B");
                var Method = Console.ReadLine();

                switch (Method) 
                {
                    case "1": Service.SetPaymentMethod(new PaymentMethodA()); break;
                    case "2": Service.SetPaymentMethod(new PaymentMethodB()); break;
                    default: Service.SetPaymentMethod(null); Console.WriteLine("Hatalı Seçim"); break;
                }

                Service.Pay();
            }
        }
    }
}