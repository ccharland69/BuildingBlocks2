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

            var x = 500;
            var y = 0;
            try
            {
                Console.WriteLine("{0} / {1} = {2}", y, x, IntResult (y, x) / IntResult (y, x));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
                    }

        private static int IntResult(int y, int x)
        {
            throw new NotImplementedException();
        }
    }
    
}
