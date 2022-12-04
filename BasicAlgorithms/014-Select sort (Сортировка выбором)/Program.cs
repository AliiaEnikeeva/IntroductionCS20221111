//Сортировка выбором
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

void SelectSort(int[] a, out int count) // сюда передаем массив
{
   count=0;
   int im;
   for(int i=0;i<a.Length;i++)
   {
        im=a[i];
        for(int j=i+1;j<a.Length;j++)
            if (a[im]<a[j])
                im=j;
        Swap(ref a[i], ref a[im]);
   }
}

int[] a=RandomIntArray(5,0,10); //создаем массив
PrintArray(a);
int count=0; //счетчик сколько раз провел операций по сортировке
SelectSort(a, out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);

