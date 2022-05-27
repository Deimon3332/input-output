using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Завдання No1. Гіпотенуза


namespace input_output
{
    internal class Class1
    {
        public static void main()
        {
            double a, b, c;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c=Math.Sqrt(a*a + b*b);

            Console.WriteLine(c);
        }
    }
}
