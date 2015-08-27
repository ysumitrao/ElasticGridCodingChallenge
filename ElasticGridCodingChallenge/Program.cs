using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace ElasticGridCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("IsNullOrEmpty: " + Helper.IsNullOrEmpty("null"));
                Console.WriteLine("Positive Divisors are: " + Helper.PositiveDivisors(42));
                Console.WriteLine("Area of triangle is: " + Helper.AreaOfTriangle(3, 4, 7));
                Console.WriteLine("Commonly used integers are: " + string.Join(",", Helper.MostCommonIntegers(new int[] { 1, 2, 3, 4, 5, 6, 7 })));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
