namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton Example_1 = Singleton.GetInstance();
            Singleton Example_2 = Singleton.GetInstance();

            Console.WriteLine(Example_1 == Example_2);
        }
    }
}