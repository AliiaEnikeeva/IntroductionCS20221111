// 16. Дано число. Проверить кратно ли оно 7 и 23
int n=Convert.ToInt32(Console.ReadLine());
if (n%7==0 && n%23==0) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");
// если число делится на 7 (кратное 7) и одновременно делится на 23 (кратное 23)

//Второй вариант, разбить на 2 условия
/*
int n=Convert.ToInt32(Console.ReadLine());
bool d1=n%7==0; //первое условие
bool d2=n%23==0; //второе условие
if (d1 && d2) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");