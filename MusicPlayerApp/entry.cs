namespace MusicPlayerApp
{
    public static class entry
    {
        public static void Run()
        {
            App app = new App();

            Console.WriteLine("\nEnter \"1\" to Play a Music\nEnter \"2\" to Add a Music\nEnter \"3\" to Remove a Music\nEnter \"4\" to Edit a Music\n");
            
            var option1 = Console.ReadLine();
            
            if (int.TryParse(option1, out int userInput1))
            {
                switch (userInput1)
                {
                    case 1:
                        Console.Clear();
                        app.OnPlay();
                        break;

                    case 2:
                        Console.Clear();
                        app.OnAdd();
                        break;

                    case 3:
                        app.OnRemove();
                        break;

                    case 4:
                        app.OnEdit();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Enter 1, 2, 3 or 4");
                Run();

            }


        }
    
    public static void starter()
    {
        App app = new();
        Console.WriteLine(".........Welcome to FlexPlay Music App!..........");
        app.DisplayList();
        Run();

    }

    }
   
}
