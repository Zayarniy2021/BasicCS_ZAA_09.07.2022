//Написать программу копирования массива

//инициализация массива
int[] a;
Init(out a,12,-9,9);
//вывод массива (до обработки)
Print(a);
//решение задачи
int[] b;
Clone(a,out b);
//Вывод результатов
System.Console.WriteLine();
Print(b);


void Clone(int[] a,out int[] b)
{
    
//b=(int[])a.Clone();//Profi
    b=new int[a.Length];
    for(int i=0;i<a.Length;i++)
        b[i]=a[i];
}

void Init(out int[] t, int Length,int min=0,int max=10)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{t[i],4} ");
}

