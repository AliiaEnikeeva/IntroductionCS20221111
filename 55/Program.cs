// 55.47 Написать программу масштабирования фигуры
/*
double[] x,y;
x=new double[10];
y=new double[10];
x[0]=0;
y[0]=0;
*/
//Структура

class Program
{
struct Point
{
    public double x,y;
}
//Пример решения найти расстояние между точками. Можно первым способом ,без использования структуры:
static double Distance(double x1,double y1,double x2,double y2)
{
    return Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
}
//Использую структуру
static double Distance(Point A, Point B)
{
    return Math.Sqrt(Math.Pow(A.x-B.x,2)+Math.Pow(A.y-B.y,2));
}
static void Main()
{
    Point a,b;
    a.x=0;
    a.y=0;
    b.x=2;
    b.y=3;
    System.Console.WriteLine(Distance(a,b));

    Point[] figure=new Point[3]; программа масштабирования треугольник
    double k=2; // коэффициент масштабирования
    for(int i=0;i<figure.Length;i++)
    {
    figure[i].x*=k;
    figure[i].y=figure[i].y*k;  
    }
    
}


}