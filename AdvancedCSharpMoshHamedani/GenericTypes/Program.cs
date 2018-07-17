using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One
            var number = new GenericList<int>();
            number.Add(10);

            var books = new GenericList<string>();
            books.Add("Moby Dick");

            var dictionary = new GenericDictionary<string, int>();
            dictionary.Add("MobyDick", 10);
            #endregion

            #region Two
            var product = new Product { Title = "Product1", Price = 10M };

            var book = new Book { Title = "Moby Dick", Price = 20M, Isbn = "kfnajnfj" };

            var productDiscount = new DiscountCalculator<Product>();

            Console.WriteLine(productDiscount.CalculateDiscount(product));
            Console.WriteLine(productDiscount.CalculateDiscount(book));
            #endregion

            #region Three

            var nullNumber = new Nullable<int>();
            Console.WriteLine($"Has value? {nullNumber.HasValue}");
            Console.WriteLine($"Value: {nullNumber.GetValueOrDefault()}");

            #endregion

            Console.ReadLine();
        }
    }
}
