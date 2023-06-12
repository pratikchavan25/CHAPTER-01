using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_01
{
    internal class CHAPTER_02
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 150;

            Console.WriteLine("Before Swapping");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + b);

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("After Swapping");
            Console.WriteLine("a = " + b);
            Console.WriteLine("b = " + b);
        }
    }
}
