using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання No2. Наступне та попереднє


namespace input_output
{
    internal class Class2
    {
        public static void main()
        {
            int a= 0;

            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "The next number for the number"+ a + " is "+ (a +1)+ ".\n" + "the previous number for the number"+ a+" is "+ (a-1)+'.');
        }
    }
}
