// 71. Показать натуральные числа от N до 1, N задано
int N=10;

Loop(N);


void Loop(int N)
 {
        if (N>= 1)
        {
            System.Console.WriteLine(N);
            N = N - 1;
            Loop(N);
        }
 }
 