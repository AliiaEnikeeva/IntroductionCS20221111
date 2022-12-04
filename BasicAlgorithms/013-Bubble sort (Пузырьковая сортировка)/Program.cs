//Пузырьковая сортировка
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

void BubbleSort(int[] a, out int count) // сюда передаем массив
{
    count=0;
    for(int i=0;i<a.Length;i++)
        for(int j=0;j<a.Length-1;j++)
        {
            if (a[j]>a[j+1]) //для обратно сортировки меняем знак > на <
                Swap(ref a[j], ref a[j+1]); //меняем местами
            count++;
        }
}

int[] a=RandomIntArray(10,0,10); //создаем массив
PrintArray(a);
int count=0; //счетчик сколько раз провел операций по сортировке
BubbleSort(a, out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);
