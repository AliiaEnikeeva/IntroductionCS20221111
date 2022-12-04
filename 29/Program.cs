// 29. Подсчитать сумму цифр в числе. Сделать подпрограмму.
// 'a', 'a', 'w', - массив символов
// "fsdf", "hello", ... - массив строк

//"54756" - '5' '4' '7' '5 '6' ...... '10'

string n = Console.ReadLine();
//string[] strings = {"fsdf", "fdfs"};

System.Console.WriteLine(Sum(n));

int Sum(string num)
{
    char[] chars = num.ToCharArray();
    int sum=0;
    
    for(int i=0; i < chars.Count(); i++)
    {
        
        //sum = sum + int.Parse(chars[i].ToString());
        sum += Convert.ToInt32(chars[i].ToString());
        System.Console.WriteLine(sum);
    }
    return sum;
}