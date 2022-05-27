using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No20. Перевірте подільність


namespace input_output
{
    internal class Class20
    {
        public static void main()
        {
            double n = 0, m = 0;
           
                n = Convert.ToInt32(Console.ReadLine()); 
                m = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(((n % m) * (m % n)) + 1);
        }
    }
}