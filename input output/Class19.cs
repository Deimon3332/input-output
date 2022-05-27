using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No19. Симетричне число


namespace input_output
{
    internal class Class19
    {
        public static void main()
        {
            double N = 0;
           
                N = Convert.ToInt32(Console.ReadLine());

            

            int a, b, c, d;
            a = (int)(N / 1000);
            b = (int)((N / 100) % 10);
            c = (int)((N / 10) % 10);
            d = (int)(N % 10);

            Console.WriteLine((((a - d) + (b - c)) + 1));
        }
    }
}