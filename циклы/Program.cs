int N=10;
int i=0;
while(i<N)//пока - универсальный
{
    i=i+1;
    System.Console.Write($"{i} ");
}
//for
for(i=0;i<N;i=i+1)
{
    System.Console.Write($"{i} ");
}
//do
int a;
do
{
    System.Console.WriteLine("Введите положительное число:");
    a=Convert.ToInt32(Console.ReadLine());
}
while(a<=0);
