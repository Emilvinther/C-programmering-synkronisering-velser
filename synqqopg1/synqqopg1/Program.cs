public class Program
{
    // number being counted
    static int numb = 5;

    // Lock opject
    static object _lock = new object();

    static void Main(String[] args)
    {

        // Makes threads
        Thread countup = new Thread(UpCount);
        Thread countdown = new Thread(DownCount);

        // Starts threads
        countup.Start();
        countdown.Start();
        



        

    }

    // Method that counts up 2 with a monitor lock
    public static void UpCount()
    {
        while (true)
        {
            Monitor.Enter(_lock);

            try
            {
                numb += 2;
                Console.WriteLine(numb);
                Thread.Sleep(500);
            }
            finally
            {
                Console.WriteLine("locked");
                Monitor.Exit(_lock);
                
            }
        }
    }


    // Method that counts down 1 with a monitor lock
    public static void DownCount()
    {
        while (true)
        {
            Monitor.Enter(_lock);
            
            try
            {
                numb -= 1;
                Console.WriteLine(numb);
                Thread.Sleep(500);
            }
            finally
            { 
            
                Console.WriteLine("locked");
                Monitor.Exit(_lock);
                
            }
        }
    }
}