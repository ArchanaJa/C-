using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> langDictionary = new Dictionary<string, string>();
            langDictionary.Add("c#", "The best programming language in the world.");
            langDictionary.Add("Java", "Named after its inventor's favourite coffee");
            langDictionary.Add("Scratch", "Cool for kids");

            string answer = "";
            string response = "";

            do
            {
                Console.WriteLine("\nTo delete, press D; check key in dictionary K; check value in dictionary, press V; Use a key to lookup, press L; to count list, press C; to exit press X: ");
                response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "D":
                        Console.WriteLine("please enter to delete");
                        answer = Console.ReadLine();
                        langDictionary.Remove(answer);
                        break;
                    case "K":
                        Console.WriteLine("please enter a key");
                        answer = Console.ReadLine();
                        if (langDictionary.ContainsKey(answer))
                        {
                            Console.WriteLine(answer + " is in a dictionary");
                        }
                        else
                        {
                            Console.WriteLine(answer + " is not in a dictionary");
                        }
                        break;
                    case "L":
                        string result;
                        bool found;
                        Console.WriteLine("please enter key for look up");
                        answer = Console.ReadLine();
                        found = langDictionary.TryGetValue(answer, out result);
                        Console.WriteLine(result);
                        break;
                    case "V":
                        Console.WriteLine("please enter value for look up");
                        answer = Console.ReadLine();
                        if (langDictionary.ContainsValue(answer))
                        {
                            Console.WriteLine(answer + " is in a dictionary");
                        }
                       break;
                    case "C":
                        int countL = langDictionary.Count();
                        Console.WriteLine("count the list " + countL);
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("not valid");
                        break;

                }
            } while (answer != "X");
        }
    }
}
