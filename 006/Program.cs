// See https://aka.ms/new-console-template for more information
/*double x,y;
x=Math.PI;
y=Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");

double r=1.0/3+1.0/3;
System.Console.WriteLine(r);
*/


double y=Sin(3.14);
System.Console.WriteLine(y);
Pause();
//System.Console.WriteLine(Pause());

//тип возвращаемого значения Имя_функции(аргументы функции)
double Sin(double x)//метод
{
    return Math.Sin(x);
}

double Sum(double a, double b)
{
    return a+b;
}


void Pause()//метод
{
    return;
    System.Console.WriteLine("Press any key");
}

