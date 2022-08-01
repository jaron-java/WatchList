namespace WatchList;

public class FileWriter
{
    public static void WriteMedia(Media media)
    {
        string path = $"{media.Type}.txt";
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine(media.Type);
            sw.WriteLine("==============");
            sw.WriteLine(media.Title);
            sw.WriteLine("");
            sw.WriteLine("##############");
        }
        
    }

    public static void ReadMedia()
    {
        Console.WriteLine("Enter the type of media you want to view");
        Console.WriteLine("AnimeSeries, AnimeMovie, Series, Movie, Game, Book");
        string newPath = Console.ReadLine();
        string path = $"{newPath}.txt";

        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
    
    
}