namespace MusicPlayerApp
{
    public partial class App
    {
        public void OnAdd()
        {

            foreach (var music in playList)
            {
                if (music.No != addNum)
                {
                    addNum += 1;

                }
            }
            try
            {
                Console.WriteLine("Enter Music title: ");
                string? musicTitle = Console.ReadLine();
                if (int.TryParse(musicTitle, out int option3))
                {
                    Console.WriteLine("Invalid Input! Music Title should not be a numeric value!");
                    Refresh.refreshAdd();
                }
                else
                {
                    Console.WriteLine("Enter the Artist name: ");
                    string? artistName = Console.ReadLine();
                    if (int.TryParse(artistName, out int option4))
                    {
                        Console.WriteLine("Invalid Input! Artist Name should not be a numeric value!");
                        Refresh.refreshAdd();
                    }
                    else
                    {

                        Console.WriteLine("Enter the music source:");
                        string? musicSource = Console.ReadLine();
                        if (int.TryParse(musicSource, out int option5))
                        {
                            Console.WriteLine("Invalid Input! Music Source should not be a numeric value!");
                            Refresh.refreshAdd();
                        }
                        else
                        {

                            playList.Add(new T { No = addNum += 1, title = musicTitle, artist = artistName, source = musicSource });

                            DisplayList();

                            Console.WriteLine($"\n{musicTitle} by {artistName} has been added to the PlayList!\n");

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OnAdd();
            }
        }
    }
}
