/* 
void Swap(int a, int b) // Передача по значению (Либо значения копируются и выводятся)
{
    int t=a;
    a=b;
    b=t;
}

int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(a,b);
System.Console.WriteLine($"a={a} b={b}");
*/

/*
void Swap(ref int a, ref int b) // reference - ссылка Передача по ссылке
//(Либо передаются ссылки этих переменных )
{
    int t=a;
    a=b;
    b=t;
}

int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a} b={b}");
*/

//Где еще можно использовать...
void Swap(ref int a, ref int b) // reference - ссылка Передача по ссылке
//(Либо передаются ссылки этих переменных )
{
    int t=a;
    a=b;
    b=t;
}


void Calculator(int a, int b, ref int sum,ref int multi)
{
    sum=a+b;
    multi=a*b;
}

int a=3, b=5;

System.Console.WriteLine($"a={a} b={b}");
Swap(ref a, ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum=0, multi=0;
Calculator(a, b, ref sum, ref multi);


bool flag;
int x;
do
{
    flag=int.TryParse(Console.ReadLine(), out x);
    if (flag==false) System.Console.WriteLine("Введите целое число! ");
}
while(flag==false);