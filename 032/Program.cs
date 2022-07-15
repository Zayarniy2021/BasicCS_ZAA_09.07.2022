//Задать массив из 8 элементов и вывести их на экран
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
t=new int[8];
t[0]=10;
t[1]=12;
for(int i=0;i<t.Length;i++) 
  t[i]=i*10;
for(int i=0;i<t.Length;i++)
  System.Console.Write($"a[{i}]={t[i]} ");
  


