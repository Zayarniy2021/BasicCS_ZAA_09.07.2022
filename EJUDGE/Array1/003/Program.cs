/*
Вводится сначала число N, а затем N чисел. Выведите эти N чисел в следующем порядке: сначала
 выводятся числа, стоящие на нечетных местах, а затем - стоящие на четных местах.
Нумерация элементов начинается с 0. Входные данные
Вводится число N (100>N>0), а затем N чисел из диапазона Integer.
5
1 2 3 4 5

2 4 1 3 5
*/

using System;
int n=Convert.ToInt32(Console.ReadLine());
string? s=Console.ReadLine();
//s=s.Trim();//удалить пробелы в начале и конце строки
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, Convert.ToInt32);

for(int i=0;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");    
for(int i=1;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");
