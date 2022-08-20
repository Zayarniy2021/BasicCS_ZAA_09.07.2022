namespace Zayarniy
{
    delegate void FLAGUP();//void()
    class A 
    {
        public void DoIt()
        {
            System.Console.WriteLine("Flag is Up!");
        }

    }

    class B
    {
        private int flag=0;
        
        public FLAGUP FlagUp=null;

        public void Work()
        {
            Random random=new Random();
            for(int i=0;i<1000;i++)
                if (random.Next(1,1000)==500)
                {
                    flag=1;
                    if (FlagUp!=null) FlagUp();

                }
        }
    }


    class Program
    {

        static void Main()
        {
            A a=new A();
            B b=new B();
            b.FlagUp=new FLAGUP(a.DoIt);
            b.FlagUp+=a.DoIt;
            b.Work();
        }
    }
}