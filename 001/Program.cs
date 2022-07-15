// See https://aka.ms/new-console-template for more information
//комментари

/*
Console.WriteLine("Hello, World!");
System.Console.WriteLine(11%3);

int MaxFromToNumbers=0;
double d=3.14;
System.Console.WriteLine(int.MaxValue);
Console.WriteLine(double.MaxValue);
string s="Hello"+"asd";//конкатенация строк (склеивание)
char c='a';
*/


//С клавиатуры вводится целое число. Вывести квадрат числа 
double a;
double b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToDouble(s);
b=a*a;//обработка данных
//вывод результата
System.Console.WriteLine("{0}^2={1}",a,b);//строка форматирования
System.Console.WriteLine($"{a}^2={b}");//строка интерполяции


/*string? s;//объявили
s=Console.ReadLine();//присвоили

System.Console.WriteLine(s);
*/

