﻿// 74.Найти сумму цифр числа

int SumDigit(int N)
{
    if (N==0) return 0;
    else
        return SumDigit(N/10)+N%10;
}

System.Console.WriteLine(SumDigit(333));
