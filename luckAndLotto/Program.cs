namespace luckAndLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is the user interface, where the user can press a key if he wants to run the code
            Console.WriteLine("Tryk på enter for at trække dine numre");
            Console.Read();

            //Here i generate the random numbers
            Random rand = new Random();
            
            //I made a loop that runs 7 times so we generate 7 numbers
            for (int i = 0; i < 8; i++)
            {
                //This code makes the last number red
                if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                //Here i generate the numbers, write them in console, and pause the code for 2 seconds
                int number = rand.Next(1, 37);
                Console.Write(number + " ");
                Thread.Sleep(2000);        
            }
            Console.Read();
        }
    }
}