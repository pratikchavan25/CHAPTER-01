using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_01
{
    internal class ASSIGN_1
    {
        static void Main(string[] args)
        {

            // 1.Swap values of two integer variables using third variable ?

            int a = 10;
            int b = 20;
            int dump;

            Console.WriteLine("before swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


            dump = a;
            a = b;
            b = dump;

            Console.WriteLine("after swapping");
            Console.WriteLine("a = " + a);
            Console.WriteLine("a = " + b);

        }
    }
}
