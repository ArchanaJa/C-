using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            //foreach (string dwarf in sevenDwarves)
            //{
            //    Console.WriteLine("Here's your dinner, " + dwarf);
            //    Console.WriteLine("And here's a nice warm drink, " + dwarf);
            //}

            string choice = "";
            Console.WriteLine("What you want for dinner: ");

            choice = Console.ReadLine();
            
            for (int i =0; i < sevenDwarves.Length; i++)
            {
                
                Console.WriteLine(sevenDwarves[i] + " your " + choice + " food is ready");
            }

            Console.WriteLine("What you want for drink: ");
            choice = Console.ReadLine();

            foreach ( string drawf in sevenDwarves)
            {
                Console.WriteLine(drawf + " your " + choice + " drink is ready");
            }

        }
    }
}
