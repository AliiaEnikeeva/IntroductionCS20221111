// Массив из случайных чисел
/*
int[] a;
a=new int[10];
*/

//Создаем подпрограмму
/*
int[] RandomIntArray(int size)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0; i<size; i++)
        a[i]=random.Next(0,100);
    return a;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] m=RandomIntArray(10);
Print(m);
*/

// Возврат массива через аргумент
void RandomIntArray(out int[] a, int size=10, int min=0, int max=100)
{
    a=new int[size];
    Random random=new Random();
    for(int i=0; i<size; i++)
        a[i]=random.Next(min,max);
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] m;
RandomIntArray(out m);
Print(m);