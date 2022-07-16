//4. По заданному с клавиатуры номеру дня недели вывести его название

int dayOfWeek=Convert.ToInt32(Console.ReadLine());//camelCase
//int DayOfWeek;//PascalCase


if (dayOfWeek==1) System.Console.WriteLine("Monday");
else
    if (dayOfWeek==2) System.Console.WriteLine("Tuesday");
    
     

switch(dayOfWeek)
{
    case 1://метка
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;
    case 3:
        System.Console.WriteLine("Wednesday");
        break;
    default:
        System.Console.WriteLine("Wrong!");
        break;

}
