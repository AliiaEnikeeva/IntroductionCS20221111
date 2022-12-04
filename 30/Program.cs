// 30. Написать программу вычисления произведения чисел от 1 до N
// 1*2*3*4*5*6*7* ... * N
int Multi(int N)
{
    int Resalt=1;
    for(int i=1; i<=N; i++)
    {
        Resalt=Resalt*i;
    }
    return Resalt;
}

int N=Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine(Multi(N));