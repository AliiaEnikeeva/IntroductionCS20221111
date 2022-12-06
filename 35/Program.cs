// 35. Написать подпрограмму замены элементов целочисленного массива типа int на противоположные по значению.
// Подпрограмма принимает на вход массив и в нем же и меняет значения.

int size=Convert.ToInt32(Console.ReadLine());
int[] positiveArray=new int[size];

Random random=new();

for(int i=0;i<size;i++)
{
    positiveArray[i]=random.Next(0,100);
}

//Массив с положительными элементами
Show(positiveArray);

System.Console.WriteLine();
int[] negativeArray = Negative(positiveArray);


//Массив с отрицательнми элементами
Show(negativeArray, "|");


// выходит имя(принимает) 
//тип_выходных_данных название_подпрограммы(тип_входных данных название_входных_данных)
int[] Negative(int[] arr)
{
    for(int i=0;i<arr.Count();i++)
    {
        arr[i]=-arr[i];
    }
    return arr;
}


// На вход подается параметр string - это разделитель, separator
void Show(int[] arrayForShow, string separator = " ")
{
    for(int i=0;i<size;i++)
    {
        System.Console.Write(arrayForShow[i] + separator);
    }
}
