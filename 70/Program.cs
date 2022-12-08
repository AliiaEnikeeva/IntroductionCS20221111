// 70. Показать натуральные числа от 1 до N, N задано
int N=10;
int i=1;
void Loop(int N,int i)
 {
        if (i<=N)
        {
            System.Console.WriteLine(i);
            Loop(N,i+1);
        }
 }
 Loop(N,i);