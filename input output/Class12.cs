using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No12. Обмін значень


namespace input_output
{
    internal class Class12
    {
        public static void main()
        {
            int a=0,b=0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());


            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine( a  +"  "+ b);

        }
    }
}