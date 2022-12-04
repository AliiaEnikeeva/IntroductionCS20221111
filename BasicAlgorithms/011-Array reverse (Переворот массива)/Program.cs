//46. В одномерном массиве из 123 чисел найти
// количество элементов из отрезка [10,99]


int[] RandomIntArray(int N,int min, int max)
{
    int[] a=new int[N]; // описываем массив и вставляем переменную N
Random random=new Random(); // заполняем массив через генерацию случайных чисел
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,200);
    return a; // возвращаем результат
}

//вывод массива на экран
void PrintArray(int[] a,int tab=5)
{
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}


void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a) //Переворот массива
{
    int t;
    for(int i=0;i<a.Length/2;i++)
   /* {//если не использовать SWAP то можно через временную переменную
        t=a[i];
        a[i]=a[a.Length-1-i];
        a[a.Length-1-i]=t;
    }*/
    Swap(ref a[i],ref a[a.Length-1-i]);
}

//Создали массив
int M=10; 
int[] a=RandomIntArray(M,0,200); 
PrintArray(a,5); // распечатали массив
    //Обработка массива
Reverse(a);// подпрограмма меняет массив внутри массива не использую дополнительной памяти
//a=a.Reverse().ToArray(); //использование метода программы, но использует больше памяти так как копирует массив
System.Console.WriteLine();
PrintArray(a,5);
