namespace FactoryDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Creator Creator = new Creator();
            Application Application;

            Application = Creator.FactoryMethod(ApplicationType.Desktop);
            Application.Platform();

            Application = Creator.FactoryMethod(ApplicationType.Mobile);
            Application.Platform();

        }
    }
}