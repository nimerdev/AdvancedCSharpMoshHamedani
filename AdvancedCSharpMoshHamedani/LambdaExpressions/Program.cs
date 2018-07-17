﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp.Library;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region One
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            Console.WriteLine(multiplier(10));
            #endregion

            #region Two

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            #endregion

            Console.ReadLine();
        }
    }
}
