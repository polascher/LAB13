using System;

namespace LAB13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string n1 = Console.ReadLine();
            double a = Convert.ToDouble(n1);
            Console.WriteLine("Введите второе число:");
            string n2 = Console.ReadLine();
            double b = Convert.ToDouble(n2);
            double x = a;
            a = b;
            b = x;
            Console.WriteLine("Первое число = {0}, Второе число = {1}", a, b);
        }
    }
}