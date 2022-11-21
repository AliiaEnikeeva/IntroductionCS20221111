// Алгоритм Евклида - опредеоение наибольшего общего делителя
/* // Вариант 1 - Без подпрограммы
int a=10;
int b=15;

while(a!=b) //пока а не равняется б
    if (a>b)
    a=a-b;
    else b=b-a;
    System.Console.WriteLine(a);
*/
/*
// Вариант 2 - с подпрограммой

int GCD(int a, int b)
{
    while(a!=b) //пока а не равняется б
    if (a>b)
    a=a-b;
    else 
    b=b-a;
    return a;
}
System.Console.WriteLine(GCD(1,5000));
*/
// Ускоренный алгоритм Евклида
int k=0;
int QuickGCD(int a, int b)
{
    while(a!=0 && b!=0) // пока а не равняется 0 и б не равняется 0
    {
        k++; // кол во итераций
        if (a>b)
        a=a%b; // то мы а делаем остаток от деления на б
    else 
    b=b%a;// остаток от деления на А
    }
    return a+b;
}
System.Console.WriteLine(QuickGCD(1,5000));
System.Console.WriteLine(k);