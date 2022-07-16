//40. Задан массив a из N элементов.
// Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//инициализация массива

int N=11;
int[] a=new int[N];
Random random=new Random();//псевдослучайные числа
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(1,11);

//вывод массива (до обработки)
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");


//решение задачи
int[] b=new int[a.Length/2];
for(int i=0;i<a.Length/2;i++)
     b[i]=a[i]*a[a.Length-i-1];
//вывод массива 
System.Console.WriteLine();
for(int i=0;i<b.Length;i++)
    System.Console.Write($"{b[i],4}");
