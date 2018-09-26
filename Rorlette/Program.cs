using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rorlette
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Roulette");
            Console.WriteLine("");
            do
            {
                Bets mybet = new Bets();
                mybet.betmethod();
                Console.ReadLine();
                Console.Clear();

            } while (true);
            
        }

    }
}
