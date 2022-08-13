Random random=new Random();//Создали объект типа Random
int N=3;
int[,] a;//описываем массив
int[,] b;//описываем массив
int[,] c;//описываем массив
a=InitA(N,N);
b=InitA(N,N);

int[,] InitA(int N,int M)
{
    int[,] t;
    t=new int[N,M];//создаем массив
    for(int i=0;i<t.GetLength(0);i++)
    {
        for(int j=0;j<t.GetLength(1);j++) 
        {
            t[i,j]=random.Next(1,100);
        }
    }
    return t;
}







//Вывод массива на экран
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],5} ");
            System.Console.WriteLine();
    }
}

