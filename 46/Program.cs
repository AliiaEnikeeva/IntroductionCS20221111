// 46. В одномерном массиве из 123 чисел
// найти количество элементов из отрезка [10,99]

int N=5; //кол-во чисел в массиве - заводим переменную N
int[] a=new int[N]; // описываем массив и вставляем переменную N
Random random=new Random(); // заполняем массив через генерацию случайных чисел
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,200);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
    //Обработка массива
int count=0;
for(int i=0;i<a.Length;i++)
    if (a[i]>=10 && a[i]<=99) //если i элемент масива больше и равен 10 и одновременно меньше или равен 99 то коунт увеличивается на 1
    count++;
System.Console.WriteLine();
System.Console.WriteLine(count);
// Для перехода на след.строчку можно сократить команды и написать
// System.Console.WriteLine($"\n{count}");

//Другой вариант с использованием оператора foreach
    //Обработка массива
count=0;
foreach(int el in a)
    if (el>=10 && el<=99) 
    count++;
System.Console.WriteLine($"\n{count}");