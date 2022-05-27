using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No8. Сума цифр



namespace input_output
{
    internal class Class8
    {
        public static void main()
        {
            int N = 0, answer;

            N = Convert.ToInt32(Console.ReadLine());
            for(answer = 0; N > 0; )
            {
                answer += N % 10;
                N = N / 10;
            }
            Console.WriteLine(answer);
        }
    }
}
