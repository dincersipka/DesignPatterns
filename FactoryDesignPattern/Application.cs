namespace FactoryDesignPattern
{
    public abstract class Application
    {
        public abstract void Platform();
    }

    public class Desktop : Application
    {
        public override void Platform()
        {
            Console.WriteLine("Desktop Application");
        }
    }

    public class Mobile : Application 
    {
        public override void Platform()
        {
            Console.WriteLine("Mobile Application");
        }
    }
}
