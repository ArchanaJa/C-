using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Book
    {
        public string title;
        public string author;
        public string ISBN;
        public int price;
     
        public static int numberofBooks;

        public Book(string title, string author, string ISBN, int price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            numberofBooks++;
        }
       
        public static void ListofAllBooks(List<Book> allBooks)
        {
            foreach (Book b in allBooks)
            {
                Console.Write("\n Book details: {0} {1}, ISBN: {2} ,price: £{3:N0}.", b.title, b.author, b.ISBN, b.price);
 
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            string title;
            string author;
            string ISBN;
            int price;

            List<Book> allBooks = new List<Book>();
            Book book1 = new Book("Harry potter", "J. K. Rowling", "234-23-23", 20);
            Book book2 = new Book("Narnia", "C. S. Lewis", "34-343-12", 30);
            allBooks.Add(book1);
            allBooks.Add(book2);
            Book.ListofAllBooks(allBooks);

            do
            {
                Console.WriteLine("\nPlease type A to add a Book, to delete type D, to sort S, to list type L or X to exit:");
                response = Console.ReadLine().ToUpper();

                if (response == "A")
                {
                    Console.WriteLine("Please enter a book title:");
                    title = Console.ReadLine();
                    Console.WriteLine("Please enter a author name:");
                    author = Console.ReadLine();
                    Console.WriteLine("Please enter a ISBN no.:");
                    ISBN = Console.ReadLine();
                    Console.WriteLine("Please enter a price:");
                    price = Convert.ToInt32(Console.ReadLine());

                    Book books = new Book(title, author, ISBN, price);
                    allBooks.Add(books);
                }
                if(response == "D")
                {
                    Console.WriteLine("Please enter a title of book to delete: ");
                    title = Console.ReadLine();
                    for(int i=0; i<allBooks.Count; i++)
                    {
                        if(title == allBooks.ElementAt(i).title)
                        {
                            allBooks.Remove(allBooks.ElementAt(i));
                        }
                    }
                    Console.WriteLine("List of Books: " + allBooks.Count);

                }
                if(response == "L")
                {
                    Book.ListofAllBooks(allBooks);
                    Console.WriteLine();
                 }
                //if(response == "S")
                //{
                //    allBooks.Sort();
                   
                //}
            } while (response != "X");
        }
    }
}
