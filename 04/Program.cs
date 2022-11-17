// 4.По заданному с клавиатуры номеру дня недели вывести его название
int n;
System.Console.WriteLine("Введите число от 1 до 7");
string? s=Console.ReadLine();
n=Convert.ToInt32(s);

if (n==1)
{
    System.Console.WriteLine("Понедельник");
}
if (n==2)
{
    System.Console.WriteLine("Вторник");
}
if (n==3)
{
    System.Console.WriteLine("Среда");
}
if (n==4)
{
    System.Console.WriteLine("Четверг");
}
if (n==5)
{
    System.Console.WriteLine("Пятница");
}
if (n==6)
{
    System.Console.WriteLine("Суббота");
}
if (n==7)
{
    System.Console.WriteLine("Воскресенье");
}