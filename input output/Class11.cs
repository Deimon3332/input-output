using System;


//Завдання No11. Електронний годинник - 2 


namespace input_output
{
    internal class Class11
    {
        public static void main()
        {
            int N, h, min_m, min_d, min_e, sec_d, sec_e, sec, hv, sep;

            N = Convert.ToInt32(Console.ReadLine());




            h = N / 3600;
            h = h % 24;
            N = N % 3600;
            min_m = N % 3600;
            hv = min_m / 60;
            min_d = hv / 10;
            min_e = hv % 10;
            sec = N % 60;
            sec_d = sec / 10;
            sec_e = sec % 10;


            Console.WriteLine(h + ":" + min_d + min_e + ":" + sec_d + sec_e);
        }
    }
}