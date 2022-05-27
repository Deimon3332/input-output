using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання No17. Поділ яблук - 3


namespace input_output
{
    internal class Class17
    {
        public static void main()
        {
            float N = 0, K = 0;
            int Answer = 0;

            N = Convert.ToInt32(Console.ReadLine());
            K = Convert.ToInt32(Console.ReadLine());


            if ((int)(N - ((int)(K % N))) != N) Answer = (int)(N - ((int)(K % N)));

            Console.WriteLine(Answer);
        }
    }
}