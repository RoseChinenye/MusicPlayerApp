
namespace MusicPlayerApp
{
    public partial class App
    {
        public void OnEdit()
        {
            try
            {
                Console.WriteLine("Enter Music No of the music you want to edit: ");
                var option7 = Console.ReadLine();
                

                if ((int.TryParse(option7, out int editNo) && editNo <= num) && editNo != 0)
                {
                    Console.WriteLine("Enter the new Music title: ");

                    string? editTitle = Console.ReadLine();
                    if (int.TryParse(editTitle, out int option8))
                    {
                        Console.WriteLine("Invalid Input! Music Title should not be a numeric value!");
                        OnEdit();
                    }
                    else
                    {
                        Console.WriteLine("Enter the new Artist name: ");
                        string? editArtist = Console.ReadLine();
                        if (int.TryParse(editArtist, out int option9))
                        {
                            Console.WriteLine("Invalid Input! Artist Name should not be a numeric value!");
                            OnEdit();
                        }
                        else
                        {

                            Console.WriteLine("Enter the new music source:");
                            string? editSource = Console.ReadLine();
                            if (int.TryParse(editSource, out int option10))
                            {
                                Console.WriteLine("Invalid Input! Music Source should not be a numeric value!");
                                OnEdit();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
                            }
                            else
                            { 

                                var edit = playList.FirstOrDefault(s => s.No == editNo);
                                edit.title = editTitle;
                                edit.artist = editArtist;
                                edit.source = editSource;

                                Console.Clear();
                                DisplayList();

                                Console.WriteLine($"\nChanges has been made to the PlayList!\n");

                            }
                        }
                    }

                }
            
            else
            {
                Console.WriteLine("Invalid input! Music No is not in the playlist!");
                OnEdit();
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
