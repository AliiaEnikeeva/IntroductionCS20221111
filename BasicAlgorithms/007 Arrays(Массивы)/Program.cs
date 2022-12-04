// Рассчитать среднюю температуру за неделю Вариант без массива
/*
int t1, t2, t3, t4, t5, t6, t7;
double s=0;
t1=Convert.ToInt32(Console.ReadLine());
t2=Convert.ToInt32(Console.ReadLine());
t3=Convert.ToInt32(Console.ReadLine());
t4=Convert.ToInt32(Console.ReadLine());
t5=Convert.ToInt32(Console.ReadLine());
t6=Convert.ToInt32(Console.ReadLine());
t7=Convert.ToInt32(Console.ReadLine());
s=(t1+t2+t3+t4+t5+t6+t7)/7;
System.Console.WriteLine(s);
*/
/*
//Вариант с массивом
int[] t; //массив не присвоенное (null)
t=new int[7]; // cоздаем массив, т.е. в t помещаем адрес будущего массива
double s=0;
for(int i=0;i<7;i++)
t[i]=Convert.ToInt32(Console.ReadLine());
*/
//МАССИВЫ - ЭТО ОБЬЕКТЫ
// Когда не знаем кол-во N
int N=7;
int[] t; //массив не присвоенное (null)
t=new int[N]; // cоздаем массив, т.е. в t помещаем адрес будущего массива
// int[] t=new int[N] - создаем массив одной строчкой
double s=0;
//заполнить массив
for(int i=0;i<N;i++)
    t[i]=Convert.ToInt32(Console.ReadLine());  
//обработать массив
for(int i=0;i<N;i++) 
    s=s+t[i];
// вывод резкльтата
 System.Console.WriteLine(s/N);