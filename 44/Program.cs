// 52.44 Написать программу преобразования десятичного числа в двоичное

string DecimalToBin(int n)
{
    string s="";
    if (n==0) return "0";
    while(n!=0)
    {
       // System.Console.Write(n%2);//вывод на экран остаток от деления на 2
        s=Convert.ToString(n%2)+s;
        n/=2;
    }
    return s;
}

System.Console.WriteLine();
System.Console.WriteLine(DecimalToBin(5));
