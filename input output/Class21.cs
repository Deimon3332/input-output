using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No21. Максимум

namespace input_output
{
    internal class Class21
    {
        public static void main()
        {
            double a = 0, b = 0;


            a = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine((a + b + Math.Abs(a - b)) / 2);
        }
    }
}