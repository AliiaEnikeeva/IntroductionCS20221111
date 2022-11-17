// 5.С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a, b, c, max;
System.Console.WriteLine("Введите число a: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Введите число b: ");
string? t=Console.ReadLine();
b=Convert.ToInt32(t);
System.Console.WriteLine("Введите число c: ");
string? r=Console.ReadLine();
c=Convert.ToInt32(r);
max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("max= ");
System.Console.WriteLine(max);