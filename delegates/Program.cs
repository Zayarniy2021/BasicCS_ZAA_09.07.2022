namespace Zayarniy
{
    class Program
    {

        delegate bool IsChar(char c);//IsChar - bool(char)

        //Подсчитать количество больших латинских символов
        //Подсчитать количество маленьких латинских символов
        //Подсчитать количество цифр


        static int CountChar(string s,IsChar isChar)
        {
            int k=0;
            for(int i=0;i<s.Length;i++)
                if (isChar(s[i])) k++;
            return k;

        }

        static int CountCharBigLatin(string s)
        {
            int k=0;
            for(int i=0;i<s.Length;i++)
                if (s[i]>='A' && s[i]<='Z') k++;
            return k;
        }

        static int CountCharSmallLatin(string s)
        {
            int k=0;
            for(int i=0;i<s.Length;i++)
                if (s[i]>='a' && s[i]<='z') k++;
            return k;
        }

        static int CountCharDigits(string s)
        {
            int k=0;
            for(int i=0;i<s.Length;i++)
                if (char.IsDigit(s[i])) k++;
            return k;
        }


        static bool IsBigLatin(char c)
        {
            return c>='A' && c<='Z';
        }

        static bool IsSmallLatin(char c)
        {
            return c>='a' && c<='z';
        }

        static void Main()
        {
            string s="This string contains BIG LATIN CHARS and digits(0123456789)";
            //IsChar isChar=new IsChar(IsSmallLatin);
            IsChar isChar=IsSmallLatin;
            isChar+=IsBigLatin;
            isChar-=IsSmallLatin;
            
            //System.Console.WriteLine(CountChar(s,isChar));
            System.Console.WriteLine(CountChar(s,new IsChar(IsSmallLatin)));

            System.Console.WriteLine(CountChar(s,
            delegate(char c)//анонимный делегат
            {
                return c>='a' && c<='z';
            }));

            System.Console.WriteLine(CountChar(s,
            (char c)=>//лямбда-выражение многостроковое
            {
                return c>='a' && c<='z';
            }));

            System.Console.WriteLine(CountChar(s,
            (c)=>c>='a' && c<='z'//лямбда-выражение однострочным            
            ));


            
            //string[] ss=Console.ReadLine().Split(' ');
            //int[] a=Array.ConvertAll<string,int>(ss,new Converter<string, int>(Convert.ToInt32));

            //System.Console.WriteLine(isChar('A'));
        }
    }
}