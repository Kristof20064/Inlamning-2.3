using System;

namespace inlamning_2._3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många dagar till vill du hyra bilen efter den fösta dagen?");
            int x = int.Parse(Console.ReadLine());
            int AntalDagar = x * 500;
            int dagsum = 300 + AntalDagar;

            Console.WriteLine("Hur många km ska du köra?");
            int km = int.Parse(Console.ReadLine());
            int kilometer = km * 1;
            int sum = dagsum + kilometer;

            Console.WriteLine("Summan är: " + sum + " kronor.");
        }
    }
}