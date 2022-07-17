//34. Задать массив из 12 элементов, заполненных числами из
// [-9, 9]. Найти сумму положительных/отрицательных 
//элементов массива

//инициализация массива
int[] a;
Init(out a,12,-9,9);
//вывод массива (до обработки)
Print(a);
//решение задачи
int sumPositive;  
int sumNegative;
Solve(a,out sumPositive, out sumNegative);
//Вывод результатов
System.Console.WriteLine(sumPositive);          
System.Console.WriteLine(sumNegative);    



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

void Solve(int[] a,out int sumPositive, out int sumNegative)
{
    sumPositive=0;
    sumNegative=0;
    for(int i=0;i<a.Length;i++)
        if (a[i]>0)
            sumPositive=sumPositive+a[i];
    for(int i=0;i<a.Length;i++)
        if (a[i]<0)
            sumNegative+=a[i];
}
