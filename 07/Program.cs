// 7. Выяснить является ли число чётным.
int a;
System.Console.WriteLine("Введите число:");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a%2==0)
{
    System.Console.WriteLine("Число четное");
}
else 
{
    System.Console.WriteLine("Число нечетное");
}