using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            #region One
            //LINQ Query operators
            var expensiveBooks = from b in books
                               where b.Price > 10
                               orderby b.Title
                               select b.Title;

            expensiveBooks.ToList().ForEach(bt => Console.WriteLine(bt));
            Console.WriteLine("**********************");

            //LINQ extension methods
            var cheapBooks = books.Where(b => b.Price <= 10)
                .OrderByDescending(b => b.Title)
                .Select(b => b.Title)
                .ToList();

            cheapBooks.ForEach(bt => Console.WriteLine(bt));
            Console.WriteLine("**********************");

            var orderedBooks = books.OrderBy(b => b.Price).ToList();
            orderedBooks.ForEach(b => Console.WriteLine($"{b.Title} - {b.Price}"));
            #endregion

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("**********************");

            #region Two
            var book = books.SingleOrDefault(b => b.Title == "Title 3++");
            if (book != null)
            {
                Console.WriteLine(book.Title);
            }

            book = books.FirstOrDefault(b => b.Title.Contains("Title"));
            if (book != null)
            {
                Console.WriteLine(book.Title + " - " + book.Price);
            }

            book = books.LastOrDefault(b => b.Title.Contains("Title"));
            if (book != null)
            {
                Console.WriteLine(book.Title + " - " + book.Price);
            }

            var pagedBooks = books.Skip(1).Take(1).ToList();
            pagedBooks.ForEach(b => Console.WriteLine($"{b.Title} - {b.Price}"));

            #endregion

            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("**********************");

            #region Three

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);

            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice);

            #endregion

            Console.ReadLine();
        }
    }
}
