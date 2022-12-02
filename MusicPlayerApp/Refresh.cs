namespace MusicPlayerApp
{
    public static class Refresh
    {
        
        public static void refreshAdd()
        {
            App app = new App();
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            Console.Clear();
            app.OnAdd();
        }

        public static void refreshDelete()
        {
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            Console.Clear();
            App app = new App();
            app.OnRemove();
            
        }
    }
}
