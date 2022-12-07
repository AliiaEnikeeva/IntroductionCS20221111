// // 50.42 Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a, int b, int c)
{
      //  if (a+b>c && a+c>b && b+c>a) return true
      return a+b>c && a+c>b && b+c>a;
}
int a=1,b=1,c=50;

if (CheckTriangle(a,b,c)) System.Console.WriteLine("YES");
else System.Console.WriteLine("NO");
