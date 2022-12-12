// Задача 93: Задайте две матрицы./
// Напишите программу, которая будет находить произведение двух матриц.
/*Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
Random random = new Random();
int n = 4;
int m = 3;

int[,] arr1 = CreateArray(n,m);
int[,] arr2 = CreateArray(n,m);
int[,] res = Multi(arr1, arr2);

Print(arr1);
Print(arr2);
Print(res);

int[,] Multi(int[,] arr1, int[,] arr2){
    int[,] result = new int[n,m];
    for(int i = 0; i<n; i++){
        for(int j=0; j <m;j++){
            result[i,j] = arr1[i,j]*arr2[i,j];
        }
    }
    return result;
}

int[,] CreateArray(int n = 3, int m= 3){
    int[,] arr = new int[n,m];
    for(int i = 0; i<n; i++){
        for(int j=0; j <m;j++){
            arr[i,j] = random.Next(1,10);
        }
    }
        
    return arr;
}

void Print(int[,] arr){
    for(int i = 0; i<n; i++){
        for(int j=0; j <m;j++){
            System.Console.Write(arr[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("-------------");
}