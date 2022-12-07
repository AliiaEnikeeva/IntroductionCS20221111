// 66. Написать подпрограмму,
// которая в квадратной матрице чисел находит сумму элементов главной диагонали

int m = 3;
int n = 3;

int[,] arr = new int[n,m];

Random random = new Random();

for(int i = 0; i < n; i++){
    for(int j =0; j < m; j++){
        arr[i,j] = random.Next(10,100);
    }
}

// 00 01 02 03
// 10 11 12 13
// 20 21 22 23
// 30 31 32 33
//  Диагональ 00,11,22,33

Print(arr);

System.Console.WriteLine(Calc(arr));

int Calc(int[,] arr){
    int sum = 0;
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            if( i == j) sum = sum + arr[i,j];
        }
    }
    return sum;
}



void Print(int[,] a){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            System.Console.Write(arr[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}