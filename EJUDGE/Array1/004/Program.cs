/*
Вводится число N, а затем - N чисел.
Определить, сколько среди них пар одинаковых чисел.
100>=N>=2

Пример входного файла:
5
1 3 2 2 3
*/

using System;

int n=int.Parse(Console.ReadLine());
string s=Console.ReadLine();
//s=s.Trim();//удалить пробелы в начале и конце строки
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);
int k=0;
for(int i=0;i<a.Length;i++)
    for(int j=i+1;j<a.Length;j++)   
        if (a[i]==a[j])
            k++;

System.Console.WriteLine(k);

