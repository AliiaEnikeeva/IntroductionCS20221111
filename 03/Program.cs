// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.
int a;
int b;
int max;

System.Console.WriteLine("введите число a= ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число b= ");
b=Convert.ToInt32(Console.ReadLine());

if (a>b) max=a; else max=b;
System.Console.WriteLine($"Максимальное число {max}");