namespace MusicPlayerApp
{
    class T
    {
        public int No { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string source { get; set; }
       
    }
    internal class App
    {
        List<T> playList = new List<T>()
            {
                new T() {No = 1, title = "You are the One", artist = "Shania Twain", source = "i-net.com"},
                new T() {No = 2, title = "Breakfast", artist = "Ugoccie & Phyno", source = "TrendyBeatz.com"},
                new T() {No = 3, title = "Everything", artist = "Timi Dakolo", source = "Topnaija.com"},
                new T() {No = 4, title = "Onulu Ube", artist = "Jennifer Eliogu", source = "Xclusiveloaded.com"},
                new T() {No = 5, title = "Hard-To-Find", artist = "Chike & Flavour", source = "TrendyBeatz.com"},
            };


        

        public void OnAdd()
        {
            try
            {
                Console.WriteLine("Enter music Id: ");
                var option2 = Console.ReadLine();

                if (int.TryParse(option2, out int number))
                {
                    Console.WriteLine("Enter Music title: ");
                    string? musicTitle = Console.ReadLine();
                    if (int.TryParse(musicTitle, out int option3))
                    {
                        Console.WriteLine("Invalid Input! Music Title should not be a numeric value!");
                        refresh();
                    }
                    else
                    {
                        Console.WriteLine("Enter the Artist name: ");
                        string? artistName = Console.ReadLine();
                        if (int.TryParse(artistName, out int option4))
                        {
                            Console.WriteLine("Invalid Input! Artist Name should not be a numeric value!");
                            refresh();
                        }
                        else
                        {

                            Console.WriteLine("Enter the music source:");
                            string? musicSource = Console.ReadLine();
                            if (int.TryParse(musicSource, out int option5))
                            {
                                Console.WriteLine("Invalid Input! Music Source should not be a numeric value!");
                                refresh();
                            }
                            else
                            {


                                playList.Add(new T() { No = number, title = musicTitle, artist = artistName, source = musicSource });

                                DisplayList();

                                Console.WriteLine($"\n{musicTitle} by {artistName} has been added to the PlayList!");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! Id should be a numeric value.");
                    refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OnAdd();
            }
        }

        public void OnRemove()
        {
            Console.WriteLine("Music Removed from the playList!");
        }

        public void OnEdit()
        {
            Console.WriteLine("Music Edited!");
        }

        public void DisplayList()
        {
            Console.WriteLine("\n.........Music PlayList..........");
            
            foreach (var s in playList)
            {
                Console.WriteLine($"\nNo:{s.No}\t Title:{s.title}\t Artist:{s.artist}\t\t Source:{s.source}\t");
            }
        }

        public void refresh()
        {
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            Console.Clear();
            OnAdd();
        }

    }
}
    

