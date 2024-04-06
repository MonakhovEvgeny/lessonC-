using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] array = { 1, 2, 3, 4, 5 };

        
        Console.Write("[");
        PrintArrayReverse(array, array.Length - 1);
        Console.Write("]");
    }

    
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            if (index != arr.Length - 1)
            {
                Console.Write(", "); 
            }
            Console.Write(arr[index]); 
            PrintArrayReverse(arr, index - 1); 
        }
    }
}
