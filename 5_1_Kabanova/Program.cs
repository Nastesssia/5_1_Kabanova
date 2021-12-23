using System;

namespace Kabanova5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0, a = 1;
                Console.WriteLine("Введите шестизначные числа после стрелки, для завершения ввода введите 0.");
                do
                {
                    Console.Write("->");
                    a = int.Parse(Console.ReadLine());
                    if (a > 99999 && a < 1000000)
                    {
                        if (Lucky(a) == true && a != 0) Console.WriteLine("Число счастливое");
                        if (Lucky(a) == false) Console.WriteLine("Число не счастливое");
                    }
                    else Console.WriteLine("Число не шестизначное");
                    n++;
                }
                while (a != 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static bool Lucky(int t)
        {
            return t / 100000 + (t / 10000) % 10 + (t / 1000) % 10 == (t / 100) % 10 + (t / 10) % 10 + t % 10;
        }

    }
}