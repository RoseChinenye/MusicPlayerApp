namespace MusicPlayerApp
{
    public partial class App
    {
        public void OnRemove()
        {
            try
            {
                Console.WriteLine("Enter music No: ");
                var option6 = Console.ReadLine();

                if (int.TryParse(option6, out int deleteNo))
                {
                    
                    var del = SongList.First(s => s.No == deleteNo);

                    SongList.Remove(del);

                    DisplayList();

                    Console.WriteLine($"\nDelete Successfully!\n");
                }
                else
                {

                    Console.WriteLine("Invalid input! Id must be a number.");
                    

                }
                         
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OnRemove();
            }
        }

    }
}
