using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No9.Наступне парне

namespace input_output
{
    internal class Class9
    {
        public static void main()
        {
            int N = 0, answer;

            N = Convert.ToInt32(Console.ReadLine());


            answer = (N + 2) - ((N + 2) % 2);

            Console.WriteLine(answer);
        }
    }
}