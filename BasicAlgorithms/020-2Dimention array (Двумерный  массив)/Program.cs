// Ввод-вывод двумерного массива, поиск в двумерном массиве, 
//сортировка двумерного массива(по колонкам, так как в дз есть 
//задание на сортировку по строкам)
//Вариант 1
/*int[,] a=new int[3,4];
//int[,] a1=new int[3,4] {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
//int[,] a2= {{1,2,3,4},{1,2,3,4},{1,2,3,4}};
Random random=new Random();
for(int i=0; i<3;i++)
    for(int j=0;j<4;j++)
        a[i,j]=random.Next(0,10);

for(int i=0;i<3;i++)
{
    for(int j=0;j<4;j++)
        System.Console.Write($"{a[i,j],4}");
        System.Console.WriteLine();
}        
*//*
//Вариант 2
int n=5;
int m=6;

int[,] a=new int[n,m];

Random random=new Random();
for(int i=0; i<n;i++)
    for(int j=0;j<m;j++)
        a[i,j]=random.Next(0,10); //(min, max+1)

for(int i=0;i<n;i++)
{
    for(int j=0;j<m;j++)
        System.Console.Write($"{a[i,j],4}");
        System.Console.WriteLine();
}        
*/
// Вариант 3 с подпрограммой

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0; i<n;i++)
        for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
            {
        for(int j=0;j<a.GetLength(1);j++)
            System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
            }        
}
int[,] a=Random2DArray(5,5);
Print2DArray(a);

