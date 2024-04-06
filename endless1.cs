using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        NaturalNumbers(m, n);

        Console.ReadLine();
    }

    static void NaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            NaturalNumbers(m + 1, n);
        }
    }
}
