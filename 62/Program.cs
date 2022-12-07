// 62. В двумерном массиве n×k заменить четные элементы
// на противоположные по значению (a[i,j]=-a[i,j]).
// Написать отдельную подпрограмму на вход которой подается массив,
// а на выходе измененный массив.


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

int [,] arr2 = Calc(arr);

System.Console.WriteLine();
Print(arr2);
// Print(Calc(arr));
int[,] Calc(int[,] arr){
    for(int i = 0; i < n; i++){
        for(int j =0; j < m; j++){
            if(arr[i,j] % 2 == 0)
                arr[i,j] = -arr[i,j];
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