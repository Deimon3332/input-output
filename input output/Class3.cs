using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Завдання No3. Поділ яблук - 1

namespace input_output
{
    internal class Class3 { 
    public static void main()
    {
        float N = 0, K = 0;
        int Answer;


        N = Convert.ToInt32(Console.ReadLine());

        K = Convert.ToInt32(Console.ReadLine());


        Answer = (int)(K / N);

        Console.WriteLine(Answer);
    }
}
}