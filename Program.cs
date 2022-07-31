namespace WatchList;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to WatchList!");
        Media newMedia = Media.MakeMedia();
        FileWriter.WriteMedia(newMedia);
        Console.WriteLine("ADDED!");
        FileWriter.ReadMedia();
        Console.ReadKey();
        System.Environment.Exit(0);
    }
}