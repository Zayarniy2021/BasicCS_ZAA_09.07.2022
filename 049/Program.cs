//Показать двумерный массив размером m×n заполненный вещественными случайными числами

int N=3;
int M=2;

double[,] a;//описываем массив

a=new double[N,M];//создаем массив
//Инициализация случайными числами
Random random=new Random();//Создали объект типа Random

for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) 
    {
        a[i,j]=random.NextDouble()*20;
    }
}


//Вывод массива на экран
for(int i=0;i<a.GetLength(0);i++)
{
    for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]:F2} ");
         System.Console.WriteLine();
}