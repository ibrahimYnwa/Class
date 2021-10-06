using System;

namespace Ierarxiya
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey Turkey = new Turkey("Istanbul", "Turkish", 84000000);
            Azerbaijan Azerbaijan = new Azerbaijan("Baku", "Azeri", 10100000);
            Console.WriteLine(Turkey.Detail());
            Console.WriteLine(Azerbaijan.Detail());
            

        }
    }
}
