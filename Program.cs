namespace WatchList;

class Program
{
    static void Main()
    {
        bool flag = false;
        while(!flag)
        {
            Console.WriteLine("Welcome to WatchList!");
            Console.WriteLine("To Add media press (a)");
            Console.WriteLine("To View media press (v)");
            Console.WriteLine("Any other key to exit");
            string input = Console.ReadLine();
            Console.Clear();
            if (input.ToLower() == "a")
            {
                Media newMedia = Media.MakeMedia();
                FileWriter.WriteMedia(newMedia);
                Console.WriteLine("ADDED!");
                Console.Clear();
            }
            else if (input.ToLower() == "v")
            {
                FileWriter.ReadMedia();
                Console.ReadKey();
            }
            else
            {
                flag = true;
            }
        }
        System.Environment.Exit(0);
    }
}