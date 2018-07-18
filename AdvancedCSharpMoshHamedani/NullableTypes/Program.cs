using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2018, 7, 18); // Equivalent to Nullable<DateTime> date = null
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            if (date.HasValue)
            {
                Console.WriteLine(date.Value);
            }

            Console.WriteLine("****************");

            DateTime date2 = date.GetValueOrDefault();
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            if (date.HasValue)
            {
                Console.WriteLine(date.Value);
            }
            Console.WriteLine("****************");

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());

            DateTime date4 = date ?? DateTime.Now; //if date has value then date else DateTime.Now

            Console.ReadLine();
        }
    }
}
