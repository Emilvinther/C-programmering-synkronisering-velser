public class Program
{

    // Making new lock object
    static object _lock = new object();
    // Counter that count how many chars are made
    static int counter = 0;
    static void Main(string[] args)
    {


        Thread stars = new Thread(Stjerner);
        Thread hashtags = new Thread(Havelåger);
        stars.Start();
        hashtags.Start();




    }


    // Method that makes the star char, and runs the loop that writes the star char in a monitor lock
    public static void Stjerner()
    {
        char star = '*';

        while (true)
        {

            Monitor.Enter(_lock);
            try
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write(star);
                    counter++;
                    
                }
                Console.Write(counter);
                Console.WriteLine("\n");
                Thread.Sleep(500);
            }
            finally
            {

                Monitor.Exit(_lock);
            }

        }

        
    }

    // Method that makes the hashtag char, and runs the loop that writes the hashtag char in a monitor lock
    public static void Havelåger()
    {
        char hashtag = '#';

        while (true)
        {

            Monitor.Enter(_lock);
            try
            {
                for (int i = 0; i < 60; i++)
                {
                    Console.Write(hashtag);
                    counter++;
                    
                }
                Console.Write(counter);
                Console.WriteLine("\n");
                Thread.Sleep(500);
            }
            finally
            {

                Monitor.Exit(_lock);
            }

        }
    }

    
}
