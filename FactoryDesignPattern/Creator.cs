namespace FactoryDesignPattern
{
    public enum ApplicationType
    {
        Desktop,
        Mobile
    }

    public class Creator
    {
        public Application FactoryMethod(ApplicationType ApplicationType)
        {
            Application Application = null;

            switch (ApplicationType)
            {
                case ApplicationType.Desktop: 
                    Application = new Desktop(); 
                    break;
                case ApplicationType.Mobile: 
                    Application = new Mobile();
                    break;
            }

            return Application;
        }
    }
}
