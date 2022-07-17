//ReadLn(a,b,c,d);//4 5 6 7 
string? s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] a=new int[ss.Length];
for(int i=0;i<a.Length;i++)
    a[i]=int.Parse(ss[i]);

for(int i=0;i<a.Length;i++)
    System.Console.WriteLine(a[i]);