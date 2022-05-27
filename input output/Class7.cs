using System;


//Завдання No7.Число десятків


namespace input_output
{
    internal class Class7
    {
        public static void main()
        {
            int N = 0, answer;

            N = Convert.ToInt32(Console.ReadLine());
            answer = (N / 10) % 10;

            Console.WriteLine(answer);

        }
    }
}
