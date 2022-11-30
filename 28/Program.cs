// 28. Определить количество цифр в числе. Сделать подпрограмму.
// Вариант 1 - без использования подпрограммы
/*int N=Convert.ToInt32(Console.ReadLine());
N=Math.Abs(N); // Чтобы не было ошибки при N<0 или отрицальном числе, берем N по модулю
int count=0;
if (N==0) count=1; // при N=0 задать сразу кол-во
while (N>0)  // пока N больше нуля, мы N присваиваем N деленное на 10 а каунт увеличиваем на 1
{
    N=N/10;
    count++;
}
System.Console.WriteLine(count);
*/


// Вариант 2 - с использованием подпрограммы 
//Подпрограмма будет возвращать кол-во цифр.

//Подпрограмма
int CountDigits(int Number)
{
    Number=Math.Abs(Number); 
    int count=0;
    if (Number==0) count=1; 
    while (Number>0) 
    {
        Number=Number/10;
        count++;
    }    
    return count;
}
//Основная программа
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));