// 89. Подсчитать сумму цифр, встречающихся в строке

//string s="12345";
//int sum=s.ToCharArray().SelectAnyCast<int>().Sum();
//System.Console.WriteLine(sum);

// Делегаты

int CountDigits(string s)
{
    int count=0;
    foreach(char c in s)
    if (char.IsDigit(c))
    count++;
    return count;
}