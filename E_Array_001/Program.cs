//Вводится сначала число N, а затем N чисел. Выведите эти N чисел в обратном порядке.

using System;

namespace Zayarniy
{
    class Program
    {
        static void Main()
        {
           int N=int.Parse(Console.ReadLine());
           //int[] a=new int[N];
           string? s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int[] a = new int[ss.Length];
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(ss[i]);            
            Array.Reverse(a);

            for (int i = 0; i < a.Length; i++)
                System.Console.Write($"{a[i]} ");
        }
    }
}
