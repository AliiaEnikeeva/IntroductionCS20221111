// 15. Вариант 1 - С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
n=Math.Abs(n);
//Вариант 1 - простой
if (n<100) System.Console.WriteLine("No");
else System.Console.WriteLine(n/100%10);
