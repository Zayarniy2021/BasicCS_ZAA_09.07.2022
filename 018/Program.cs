bool Check(int a,int b)
{    
    return a*a==b;
}

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
//==,!=,>,<,>=,<=
if (Check(a,b))
{
    System.Console.WriteLine("b является квадратом a");
}
else
{
    if (Check(b,a))
    {
        System.Console.WriteLine("a является квадратом b");
    }
    else
    {
        System.Console.WriteLine("Числа не являются квадратами друг друга");
    }
}
