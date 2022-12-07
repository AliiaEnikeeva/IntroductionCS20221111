// 64. В двумерном массиве заменить элементы,
// у которых оба индекса чётные на их квадраты по значению.


int m = 7;
int n = 5;

int[,] arr = new int[n,m];

Random random = new Random();

for(int i = 0; i < n; i++){
    for(int j =0; j < m; j++){
        arr[i,j] = random.Next(10,100);
    }
}

Print(arr); // 1

int [,] arr2 = Calc2(arr);

System.Console.WriteLine();

Print(arr2); // 2
// Print(Calc(arr));
int[,] Calc(int[,] arr){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            if(i % 2 == 0 && j%2==0)
                arr[i,j] = arr[i,j]*arr[i,j]; //arr[i,j]=Math.Pow(arr[i,j],2)
        }
    }
    return arr;
}

int[,] Calc2(int[,] arr){
    for(int i = 0; i < n; i = i + 2){
        for(int j =0; j < m; j = j + 2){
            arr[i,j] = arr[i,j]*arr[i,j];
        }
    }
    return arr;
}

void Print(int[,] a){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            System.Console.Write(arr[i,j] + "   ");
        }
        System.Console.WriteLine();
    }
}