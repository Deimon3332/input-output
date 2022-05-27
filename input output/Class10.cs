using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання No10. Електронний годинник - 1


namespace input_output
{
    internal class Class10
    {
        public static void main()
        {
            int N = 0;

            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hour" + (N  /60) + "\nMinut" + (N % 60));


        }
    }
}