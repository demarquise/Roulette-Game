using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rorlette
{
    class Program : Bets
    {


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Roulette");
            Console.WriteLine("");

            do
            {
                Bets mybet = new Bets();
                mybet.betmethod();
                Console.ReadLine();
                Console.Clear();

                

            } while (chips > 0);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorry you out of Chips go get some more then we can talk");
            Console.ReadLine();
        }

    }
}
