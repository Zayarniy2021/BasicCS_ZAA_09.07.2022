//Вводятся координаты двух точе x1,y1 и x2,y2
//Нужно написать подпрограмму Distance, которая находит растояние между точками

class Program
{
struct Point
{
    private double x,y;

    //конструктор
    public Point()
    {
        x=0;y=0;
    }

    public Point(double value)
    {
        if (value>10000) throw new ArgumentOutOfRangeException("Значение не может привышать 10000");
        x=value;y=value;
    }

    public Point(double _x,double y)
    {
        x=_x;this.y=y;
    }

    //публичные методы (альтернативный вариант)
    public double GetX()
    {
        return x;
    }

    public double GetY()
    {
        return y;
    }

    public void SetX(double value)
    {
        x=value;
    }

    public void SetY(double value)
    {
        y=value;
    }

    //свойства
    public double X
    {
        //акцессоры доступа
        get
        {
            return x;
        }
        set
        {
            x=value;
        }
    }

    public double Y
    {
        //акцессоры доступа
        get
        {
            return y;
        }
        set
        {
            y=value;
        }
    }




    static public double Distance(double x1, double y1,double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)); //c=sqrt(a^2+b^2);
    }

    static public double Distance(Point A, Point B)
    {
    return Math.Sqrt(Math.Pow(A.x-B.x,2)+Math.Pow(A.y-B.y,2));
    }

    
}

static void Main()
{
    Point A,B;
    A=new Point(0,0);//инициализация A
    B=new Point(1000000);
    //A.SetX(5);
    A.X=5;
    //System.Console.WriteLine(A.X);
    //double x1=0,y1=0,x2=4,y2=4;
    //double distance=Distance(x1,y1,x2,y2);
    double distance=Point.Distance(A,B);
    System.Console.WriteLine(distance);
}
}