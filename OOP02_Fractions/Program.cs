class Program
{

    struct Fraction
    {
        private int numerator,denumerator;
        public Fraction(int numerator, int denumerator)
        {
            if (denumerator==0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            this.numerator=numerator;
            this.denumerator=denumerator;
        }

        public static Fraction Plus(Fraction a, Fraction b)
        {
            Fraction c=new Fraction(a.numerator*b.denumerator+b.numerator*a.denumerator ,a.denumerator*b.denumerator);
            return c;
        }

        public  static  Fraction Minus(Fraction a, Fraction b)
        {
            Fraction c=new Fraction(a.numerator*b.denumerator-b.numerator*a.denumerator ,a.denumerator*b.denumerator);
            return c;
        }

        public static  Fraction Multi(Fraction a, Fraction b)
        {
            Fraction c=new Fraction(a.numerator*b.numerator,a.denumerator*b.denumerator);
            return c;
        }

        public static Fraction Divide(Fraction a, Fraction b)
        {
            Fraction c=new Fraction(a.numerator*b.denumerator,a.denumerator*b.numerator);
            return c;
        }

        public void Print()
        {
            System.Console.WriteLine($"{numerator}/{denumerator}");
        }


    }

    static void Main()
    {
        Fraction a=new Fraction(1,2);
        Fraction b=new Fraction(1,3);
        Fraction c=Fraction.Plus(a,b);
        c.Print();
        c=Fraction.Minus(a,b);
        c.Print();
        c=Fraction.Multi(a,b);
        c.Print();
        c=Fraction.Divide(a,b);
        c.Print();
        
        //DateTime date=new DateTime(01,8,2022);

    }

}