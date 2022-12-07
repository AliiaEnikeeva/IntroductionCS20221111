// Бинарный поиск в массиве
int[] RandomIntArray(int N,int min, int max)
{
    int[] a=new int[N]; // описываем массив и вставляем переменную N
Random random=new Random(); // заполняем массив через генерацию случайных чисел
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,max+1);
    return a; // возвращаем результат
}

//вывод массива на экран
void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}
int BinSearch(int[] a, int find) //передаем некоторый массив и что мы ищем
{
    int i;
    int left=0; // граница левая 0
    int right=a.Length-1; // граница правая равна Длине массива минус 1
    i=left+(right-left)/2; // средний элемент
// начинаем поиск: до тех пор пока a[i] не равняется find или 
    while(a[i]!=find && left<right )
    {
            if (find>a[i])
                left=i+1; // добавили +1 чтоб не было ошибки
            else
                right=i;
            i=left+(right-left)/2; 
    }
    if(a[i]!=find)
        return -1;
    else
        return i;
}
//Console.ReadLine();
int find=20;
int[] a=RandomIntArray(10,15,25);
a[6]=find;
Array.Sort(a); //отсортировать массив
PrintArray(a);
System.Console.WriteLine("\n"+BinSearch(a,find));
