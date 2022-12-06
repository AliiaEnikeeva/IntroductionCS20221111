// 46.38 В одномерном массиве из 123 чисел
// найти количество элементов из отрезка [10,99]
//С использованием подпрограммы

int[] RandomIntArray(int N,int min, int max)
{
    int[] a=new int[N]; // описываем массив и вставляем переменную N
Random random=new Random(); // заполняем массив через генерацию случайных чисел
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,200);
    return a; // возвращаем результат
}

//вывод массива на экран
void PrintArray(int[] a)
{
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}


int Solve(int[] a)
{
    int count=0;
foreach(int el in a)
{    
    if (el>=10 && el<=99) 
    count++;
}
return count;
}



//Создали массив
int M=5; 
int[] a=RandomIntArray(M,0,200); 
PrintArray(a); // распечатали массив
    //Обработка массива
System.Console.WriteLine($"\n{Solve(a)}");
