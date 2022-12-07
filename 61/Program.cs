// 61. Показать двумерный массив размером m×n 
//заполненный вещественными случайными числами

int m = 7;
int n = 5;

double[,] arr = new double[n,m];

Random random = new Random();

for(int i = 0; i < n; i++){
    for(int j =0; j < m; j++){
        arr[i,j] = (double)random.Next(11,100) / 10;
    }
}

Print(arr);

void Print(double[,] a){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            System.Console.Write(arr[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}