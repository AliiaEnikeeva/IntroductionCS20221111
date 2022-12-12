// 84. Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа

string s=Console.ReadLine();
int n;
bool flag=int.TryParse(s,out n);
if (flag==true) System.Console.WriteLine(n);
else System.Console.WriteLine("Wrong number");

if(flag)
{
    int sum=0;
    foreach(char c in s)
    sum=sum+Convert.ToInt32(c.ToString());
    System.Console.WriteLine($"{n} {sum}");
}
else System.Console.WriteLine("Wrong number");