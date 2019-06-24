using System;

namespace Fork_Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fork Bomb V1.0");
            Console.WriteLine("Fork bomb with a variable start");
            Console.WriteLine("Enter this programs exe file path ");
            String filePath = Console.ReadLine();


            System.Diagnostics.Process.Start(filePath);

        }
    }
}
