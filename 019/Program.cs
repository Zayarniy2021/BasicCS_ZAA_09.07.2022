//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//!(X || Y)==!X && !Y

int N=5;
System.Console.WriteLine($"N={N}");
bool x,y,f1,f2,f;
x=true;
y=true;
f1=!(x || y);
f2=!x && !y;
System.Console.WriteLine($"{x} {y} {f1} {f2}");