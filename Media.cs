namespace WatchList;

public class Media
{
    // public enum MediaType
    // {
    //     AnimeSeries,
    //     AnimeMovie,
    //     Movie,
    //     Series,
    //     Game,
    //     Book
    // }
    
    public string Title { get; set; }
    public string Type { get; set; }

    public static Media MakeMedia()
    {
        Media newMedia = new Media();
        newMedia.Title = GetTitle(newMedia);
        GetMediaType(newMedia);
        return newMedia;
    }
    

    public static string GetTitle(Media newMedia)
    {
        Console.WriteLine("Please enter the Title of your media");
        string input = Console.ReadLine();
       
        return input;
    }

    public static Media GetMediaType(Media newMedia)
    {
        while(true)
        {
            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("(1) for Anime Series");
            Console.WriteLine("(2) for Anime Movie");
            Console.WriteLine("(3) for Movie");
            Console.WriteLine("(4) for Series");
            Console.WriteLine("(5) for Game");
            Console.WriteLine("(6) for Book");
            int data = Convert.ToInt32(Console.ReadLine());
            switch (data)
            {
                case 1:
                    newMedia.Type = "AnimeSeries";
                    return newMedia;
                case 2:
                    newMedia.Type = "AnimeMovie";
                    return newMedia;
                case 3:
                    newMedia.Type = "Movie";
                    return newMedia;
                case 4:
                    newMedia.Type = "Series";
                    return newMedia;
                case 5:
                    newMedia.Type = "Game";
                    return newMedia;
                case 6:
                    newMedia.Type = "Book";
                    return newMedia;
                default:
                    Console.WriteLine("Please enter valid input, press anykey to continue..");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}