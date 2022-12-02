namespace MusicPlayerApp
{
    public partial class App
    {
        public void OnPlay()
        {
            try {
                Console.WriteLine("Enter the No of the Music you want to Play: ");
                var option6 = Console.ReadLine().ToUpper().Trim();
                if (int.TryParse(option6, out int musicNo))
                {
                    switch (musicNo)
                    {
                        case 1:
                            Console.WriteLine("\"You are the One\" is Playing......");
                            break;
                        case 2:
                            Console.WriteLine("\"Breakfast\" is Playing......");
                            break;
                        case 3:
                            Console.WriteLine("\"Everything\" is Playing......");
                            break;
                        case 4:
                            Console.WriteLine("\"Onulu Ube\" is Playing......");
                            break;

                        case 5:
                            Console.WriteLine("\"Hard-To-Find\" is Playing......");
                            break;
                        default:
                            Console.WriteLine("Please enter a music No from the playlist!");
                            OnPlay();
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Invalid Input! Music Title should not be a numeric value!");
                    OnPlay();
                }
                Console.ReadKey();

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                OnPlay();
            }
            }
        
    }
}
