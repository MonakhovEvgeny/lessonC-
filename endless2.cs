using System;

class Program
{
    static void Main(string[] args)
    {
        int m, n;

        
        Console.WriteLine("Введите значение m:");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение n:");
        n = int.Parse(Console.ReadLine());

        
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");
    }

    
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
