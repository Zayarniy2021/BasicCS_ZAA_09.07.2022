//Написать программу преобразования десятичного числа в двоичное

int n=16;//1111

for(int i=0;i<20;i++)
    System.Console.WriteLine($"{i} {DecToAny(i,15)}");


string DecToBin(int n)
{
    if (n==0) return "0";
    string s="";
    while (n!=0)
    {
        s=(n%2).ToString()+s;    
        n/=2;//n=n/2
    }
    return s;
}

string DecToAny(int n,int @base)
{
    if (@base>10) {
        //System.Console.WriteLine("Основание должно быть не больше 10");
        throw new ArgumentOutOfRangeException("Основание должно быть не больше 10");        
    }
    if (n==0) return "0";
    string s="";
    while (n!=0)
    {
        s=(n%@base).ToString()+s;    
        n/=@base;//n=n/2
    }
    return s;
}