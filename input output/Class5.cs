using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання No5. Остання цифра


namespace input_output
{
    internal class Class5
    {
        public static void main()
        {
            int N = 0, answer;
            N = Convert.ToInt32(Console.ReadLine());
            answer = N % 10;
            Console.WriteLine( answer);
        }
    }
}
