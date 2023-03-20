namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton Example_1 = Singleton.GetInstance();
            Singleton Example_2 = Singleton.GetInstance();

            System.Diagnostics.Debug.WriteLine($"Example_1: {Example_1}");
            System.Diagnostics.Debug.WriteLine($"Example_2: {Example_2}");
            System.Diagnostics.Debug.WriteLine(Example_1 == Example_2);
        }
    }
}