//32. Задать массив из 8 элементов и вывести их на экран
/*
int t1,t2,t3,t4,t5,t6,t7;
t1=10;
t2=12;
t3=14;
t4=16;
t5=17;
t6=18;
t7=17;
double sr=(t1+t2+t3+t4+t5+t6+t7)/7;
*/
int[] t;//объявление
//инициализация
Init(out t,8,max:100);
//решение задачи
//вывод результатов на экран
Print(t,"t");


void Init(out int[] t, int Length,int min=0,int max=10)
{
  t=new int[Length];
  Random random=new Random();
  for(int i=0;i<t.Length;i++) 
    t[i]=random.Next(min,max+1);
}

void Print(int[] t, string variableName)
{
  for(int i=0;i<t.Length;i++)
  System.Console.Write($"{variableName}[{i}]={t[i]} ");
}

