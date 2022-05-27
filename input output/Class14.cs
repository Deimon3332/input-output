using System;


//Завдання No14. Вартість покупки


namespace input_output
{
    internal class Class14
    {
        public static void main()
        {
            int a = 0, b=0, n = 0;


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());


            a *= n;
            b *= n;
            for (int s=0; b > 99;)
            {
                a += 1;
                b -= 100;
            }


            Console.WriteLine(a + " " + b);
        }
    }
}
