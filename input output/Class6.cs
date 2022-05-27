using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No6. Число десятків двозначного числа


namespace input_output
{
    internal class Class6
    {
        public static void main()
        {
            int N = 0, answer;
            N = Convert.ToInt32(Console.ReadLine());
            answer = N % 10;
            Console.WriteLine(answer);

            if (N > 00) N = 99;
            if(N<10) N = 10; 
            answer = N / 10;
            Console.WriteLine(answer);

        }
    }
}
