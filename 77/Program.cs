// 77. Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности 0 и 1 

int Fibanache(int N)
{
    if (N==0) return 1;
        else
            if (N>0) return Fibanache(N-1)*N;
                 else return 1;
}
System.Console.WriteLine(Fibanache(2));