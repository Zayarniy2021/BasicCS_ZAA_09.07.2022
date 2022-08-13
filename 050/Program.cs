//В двумерном массиве n×k заменить четные элементы на противоположные по значению 
//(a[i,j]=-a[i,j])

int[,] a;//описываем массив
//a=Init(3,2);
Init2(3,2,out a);
Print(a);
Solution(a);
System.Console.WriteLine();
Print(a);

//Вывод массива на экран
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],4} ");
            System.Console.WriteLine();
    }
}

void Init2(int N, int M,out int[,] a)
{
   a=new int[N,M];//создаем массив
    //Инициализация случайными числами
    Random random=new Random();//Создали объект типа Random

    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        {
            a[i,j]=random.Next(1,11);
        }
    } 
}

int[,] Init(int N,int M)
{
    a=new int[N,M];//создаем массив
    //Инициализация случайными числами
    Random random=new Random();//Создали объект типа Random

    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        {
            a[i,j]=random.Next(1,11);
        }
    }
    return a;
}

//Решить задачу
void Solution(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) 
        if (a[i,j]%2==0)
            a[i,j]=-a[i,j];
    }
}
