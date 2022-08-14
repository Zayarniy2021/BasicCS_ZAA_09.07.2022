using System.Drawing;
using System.Windows.Forms;
namespace Recursy_Draw;
 
public partial class Form1 : Form
{
    Graphics g;
    public Form1()
    {
        InitializeComponent();
        this.Width=1200;
        this.Height=1200;
        this.Paint+=new  PaintEventHandler(MyPaintHandler);
        g=this.CreateGraphics();
       
    }
 
    static void MyPaintHandler(object sender, PaintEventArgs pea)
    {
        Graphics g=pea.Graphics;
        g.Clear(Color.Black);        
        //g.DrawEllipse(Pens.Black,100,100,50,50);
        RecCircle(g,400,400,300);
    }
 
    static void RecCircle(Graphics g, int x, int y, int r)
    {
 
        DrawCircle(g, x,y,r);
        //System.Threading.Thread.Sleep(10);
        if (r>10)
        {
            RecCircle(g,x-r/2,y,r/2);
            RecCircle(g,x+r/2,y,r/2);
            RecCircle(g,x,y-r/2,r/2);
            RecCircle(g,x,y+r/2,r/2);
        }
    }
 
    static void DrawCircle(Graphics g,int x, int y, int r)
    {
        g.DrawEllipse(Pens.White,x-r/2,y-r/2,r,r);
    }
 
}
