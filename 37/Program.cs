// 37.Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int size=Convert.ToInt32(Console.ReadLine());
int[] a=new int[size];

Random random=new();

for(int i=0;i<size;i++)
{
    a[i]=random.Next(100,999);
}

Print(a);
System.Console.WriteLine();
System.Console.WriteLine("Четные: " + Counter(a)[0]);
System.Console.WriteLine("Нечетные: " + Counter(a)[1]);

// выходит имя(принимает) 
//тип_выходных_данных название_подпрограммы(тип_входных данных название_входных_данных)
int[] Counter(int[] arr)
{
    int[] counter = new int[2]; // [0] - кол-во четных, [1] - нечетные

    for(int i=0;i<arr.Count();i++)
    {
        if(arr[i]%2 ==0) counter[0]++;
        else counter[1]++;
    }
    return counter;
}

void Print(int[] a, string separator = " ")
{
    for(int i=0;i<size;i++)
    {
        System.Console.Write(a[i] + separator);
    }
}
