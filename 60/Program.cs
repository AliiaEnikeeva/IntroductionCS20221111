// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами
int m = 7;
int n = 5;

int[,] arr = new int[n,m];

Random random = new Random();

for(int i = 0; i < n; i++){
    for(int j =0; j < m; j++){
        arr[i,j] = random.Next(10,100);
    }
}

Print(arr);

void Print(int[,] a){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            System.Console.Write(arr[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}