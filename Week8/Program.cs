namespace Week8;



public class Program
{
    public static void Main()
    {
       
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        p2.X = 2;
        p2.Y = 1;
        p1.Print();
        p2.Print();

        PointRef r1 = new PointRef( 1, 2);
        PointRef r2 = r1;

        r2.X = 2; // тут не зміниться, бо клон
        r2.Y = 1;
        r1.Print(); 
        r2.Print();

        BoxingTester boxingTester = new BoxingTester();
        BoxingTester.Test();
    }
}