using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            swap(ref a,ref b);
            Console.WriteLine(a+" "+b);
        }

        static void swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}