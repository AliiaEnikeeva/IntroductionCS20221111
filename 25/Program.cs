// 25. Вывести на экран кубы чисел от 1 до N
int N;
N=Convert.ToInt32(System.Console.ReadLine());

GetCube(N);

void GetCube(int N){
    for( int i = 1; i <= N; i++){
        System.Console.WriteLine(Math.Pow(i,3));
    }
}