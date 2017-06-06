using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string> { "War and Peace", "The Girl on the train", "Harry Potter" };

            string val = "";
            string response = "";

            do
            {
                Console.WriteLine("\n To add a book, press A; To exit, press X; To delete, press D; for list books, press L and to sort, press S; to search, press E: ");
                 response = Console.ReadLine().ToLower();

                switch (response)
                {
                    case "a":
                        Console.WriteLine("please enter a book title to add");
                        val = Console.ReadLine();
                        
                        books.Add(val);
                        break;
                    case "x":
                        displayBooks(books);
                        break;
                    case "d":
                        Console.WriteLine("please enter a book title to delete");
                        val = Console.ReadLine();
                        books.Remove(val);
                        break;
                    case "l":
                        displayBooks(books);
                        break;
                    case "s":
                        books.Sort();
                        displayBooks(books);
                        break;
                    case "e":
                        Console.WriteLine("Enter a word to search");
                        val = Console.ReadLine();
                        searchBooks(val,books);
                        break;
                    default:
                        Console.WriteLine("Enter valid answer");
                        break;
                }
            } while (response != "x");

           
        }

        static void displayBooks(List<string> newBook)
        {
            for(int i =0; i<newBook.Count; i++)
            {
                Console.WriteLine(newBook.ElementAt(i));
            }

         /// or we can use this code:---  newBook.ForEach(Console.WriteLine);
        }
        static void searchBooks(StringComparer searchAns, List<string> search)
        {
            //searchAns = StringComparer.OrdinalIgnoreCase{ };
            //Console.WriteLine(search.Contains(searchAns));
        }
    }
}
