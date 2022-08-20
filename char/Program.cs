char c;
System.Char c1;

c='a';
System.Console.WriteLine($"{c} {(int)c}");
for(char c2='a';c2<='z';c2++)
    System.Console.Write(c2);

if (c>='A' && c<='Z') 
    System.Console.WriteLine("Big latin char");
if (c>='0' && c<='9') 
    System.Console.WriteLine("char is digit");
if (char.IsDigit(c)) 
    System.Console.WriteLine("char is digit");
