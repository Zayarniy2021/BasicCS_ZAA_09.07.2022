string s="Hello";
System.String s1;

//System.Console.WriteLine($"{s[0]} {(int)s[0]}");

for(int i=0;i<s.Length;i++)
    System.Console.WriteLine($"{s[i]} {(int)s[i]}");

//s[0]='h';//immutable - строки не изменяемые
char[] cc=s.ToArray();
cc[0]='h';
s=new string(cc);
System.Console.WriteLine(s);
    
System.Console.WriteLine(s.IndexOf("lll"));
//s=s.Remove(2,2);
s=s.Replace('l','p');
System.Console.WriteLine(s);

string s2="bbb";
string s3="BBB";

if (s2==s3) System.Console.WriteLine("Равняются"); else System.Console.WriteLine("Не равняются");

System.Console.WriteLine(s2.CompareTo(s3));
System.Console.WriteLine(String.Compare(s2,2,s3,2,1));

System.Diagnostics.Stopwatch sw=new System.Diagnostics.Stopwatch();
sw.Start();
string s4="";
for(int i=0;i<100000;i++)
  s4=s4+"abcde";
sw.Stop();
System.Console.WriteLine(sw.ElapsedMilliseconds);
sw.Reset();
sw.Start();
System.Text.StringBuilder sb=new System.Text.StringBuilder();
for(int i=0;i<100000;i++)
  sb.Append("abcde");
sw.Stop();
System.Console.WriteLine(sw.ElapsedMilliseconds);

