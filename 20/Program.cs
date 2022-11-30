// 20. Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0
/*// Решение домашней задачи
double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int part=0;
if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;
System.Console.WriteLine("Part:" + part);
*/


// тип  имя (аргументы)
int Part(double x, double y)
{
//тело подпрограммы в фигурных скобках
int part=0;
if (x>0 && y>0) part=1;
if (x<0 && y>0) part=2;
if (x<0 && y<0) part=3;
if (x>0 && y<0) part=4;
//System.Console.WriteLine("Part:" + part); - вывод подпрограммы обычно не делают. 
// Подпрограмма обычно решает задачу, но не выводит ответ
return part;
}

double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Part:" + Part(x,y));


/*void Pause() //подпрограмма void ничего не выводит и не возвращает (войд-пустота)
{
    System.Console.WriteLine("Press any key");
Console.ReadKey()
}
*/

/* Другой вариант тела подпрограммы (без указания переменных)
if (x>0 && y>0) return 1;
if (x<0 && y>0) return 2;
if (x<0 && y<0) return 3;
if (x>0 && y<0) renurn 4;
return 0;
*/

// Можно создавать множетво подпрограмм с одинаковым названием, но с разными аргументами
//Это называется перегрузка по параментрам или аргументам

void Pause() //подпрограмма void ничего не выводит и не возвращает (войд-пустота)
{
    System.Console.WriteLine("Press any key");
Console.ReadKey()
}

void Pause(string) 
{
    System.Console.WriteLine(message);
Console.ReadKey()
}
Pause("Нажмите любую клавишу");

void Pause(int i)
{
    
}