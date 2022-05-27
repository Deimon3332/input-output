using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No16. Автопробіг


namespace input_output
{
    internal class Class16
    {
        public static void main()
        {
            float n = 0, m = 0;

            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Math.Ceiling(m / n));
        }
    }
}
