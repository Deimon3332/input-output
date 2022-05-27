using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No13. Кінець уроків


namespace input_output
{
    internal class Class13
    {
        public static void main()
        {
            var time = new DateTime(2022, 1, 1, 9, 0, 0);
            int n = 0, mm = 0;


            n = Convert.ToInt32(Console.ReadLine());

            mm = n * 45 + (n / 2) * 5 + ((n + 1) / 2 - 1) * 15;

            Console.WriteLine($"{time.AddMinutes(mm):t}");
        }
    }
}
