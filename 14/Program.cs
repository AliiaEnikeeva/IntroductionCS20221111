// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.
int a;
int b;
int n=0;

System.Console.WriteLine("введите число a= ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите число b= ");
b=Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    System.Console.WriteLine("Число a кратно числу b");
} 
else n = a % b;
System.Console.WriteLine(n);