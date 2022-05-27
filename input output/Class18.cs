using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No18. Равлик


namespace input_output
{
    internal class Class18
    {
        public static void main()
        {
            double a = 0, b = 0, h = 0;
            int Answer = 0;

            h = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());


            Answer = (int)Math.Ceiling((h - 2 * b + a - 1) / (a - b));

            Console.WriteLine(Answer);
        }
    }
}
