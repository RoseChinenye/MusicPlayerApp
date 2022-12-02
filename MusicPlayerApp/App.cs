namespace MusicPlayerApp
{
    class T
    {
        public int No { get; set; }
        public string? title { get; set; }
        public string? artist { get; set; }
        public string? source { get; set; }

    }
    public partial class App
    {
        public int addNum = 0;
        public const int num = 5;

        List<T> playList = new List<T>
            {
                new T {No = 1, title = "You are the One", artist = "Shania Twain", source = "i-net.com"},
                new T {No = 2, title = "Breakfast", artist = "Ugoccie & Phyno", source = "TrendyBeatz.com"},
                new T {No = 3, title = "Everything", artist = "Timi Dakolo", source = "Topnaija.com"},
                new T {No = 4, title = "Onulu Ube", artist = "Jennifer Eliogu", source = "Xclusiveloaded.com"},
                new T {No = 5, title = "Hard-To-Find", artist = "Chike & Flavour", source = "TrendyBeatz.com"},
            };

        public void DisplayList()
        {
            Console.WriteLine("\n.........Music PlayList..........");

            foreach (var s in playList)
            {
                Console.WriteLine($"\nNo:{s.No}\t Title:{s.title}\t Artist:{s.artist}\t\t Source:{s.source}\t");
            }
        }

    }
}
    

