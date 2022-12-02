
namespace MusicPlayerApp
{
    
    public partial class App
    {
        List<T> newPlaylist = new List<T>
            {
                
                
            };
        public void createPlaylist()
        {

            try
            {
                Console.WriteLine("Enter playlist name: ");

                string? playlistName = Console.ReadLine();
                if (int.TryParse(playlistName, out int option11))
                {
                    Console.WriteLine("Invalid Input! PlayList name should not be a numeric value!");
                    createPlaylist();
                }
                else
                {
                    Console.WriteLine($"{playlistName} has been created successfully!\n");
                    bool addAgain = true;
                    while (addAgain)
                    {
                        Console.WriteLine($"Enter Music No of the music you want to add to {playlistName} playlist: ");
                        var option12 = Console.ReadLine();

                        if (int.TryParse(option12, out int playListNo) && playListNo <= num && playListNo != 0)
                        {

                            foreach (var m in SongList)
                            {
                                if (playListNo == m.No)
                                {
                                    newPlaylist.Add(m);
                                    Console.WriteLine($"\n.........List of Songs in {playlistName} playlist..........");
                                    newPlaylist.ForEach(n => Console.WriteLine($"\nNo:{n.No}\t Title:{n.title}\t Artist:{n.artist}\t\t Source:{n.source}\t"));
                                }
                            }

                            Console.WriteLine("\nEnter \"1\" to add more songs to the Playlist\nEnter \"2\" to go back to List of Songs\nEnter \"3\" to Exit");
                            var option13 = Console.ReadLine();
                            if (int.TryParse(option13, out int addSong))
                            {
                                switch (addSong)
                                {
                                    case 1:
                                        addAgain = true;
                                        break;
                                    case 2:
                                        entry.starter();
                                        break;
                                    case 3:
                                        Console.WriteLine("Exit Successful!");
                                        addAgain = false;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter 1, 2, or 3!");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input! Enter 1, 2 or 3!");
                            }
                                
                        }

                        else
                        {
                            Console.WriteLine("Invalid input! Music No is not in the existing playlist!");
                            createPlaylist();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                createPlaylist();
            }

        }
    }
    
}
