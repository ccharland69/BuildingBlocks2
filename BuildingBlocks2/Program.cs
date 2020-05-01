using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks2
{
    class Program
    {
        static void Main()
        {
            var myString = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(myString);
            Console.WriteLine(23 + 45.79);
            Console.WriteLine(442 - 208);
            Console.WriteLine(48 / 4);
            Console.WriteLine(3 * 102);
            Console.WriteLine(10 % -8);
            try
            {
                int result = 500 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }

}
