using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";
            Console.WriteLine(obj.GetHashCode());

            Console.WriteLine(obj.GetType().GetMethod("GetHashCode"));

            dynamic excelObject = "mosh";
            //excelObject.Optimize();

            dynamic name = "Bogdan";
            name = 10;

            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; // because a & b are dynamic, so is c

            int i = 5;
            dynamic d = i;
            long l = d;

            Console.ReadLine();
        }
    }
}
