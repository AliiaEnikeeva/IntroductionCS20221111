// 22. Программа проверяет пятизначное число на палиндромом.
//12321

int n = Convert.ToInt32(System.Console.ReadLine());
int first = n /10000;
int second = (n/1000) % 10;
int prelast = (n/10) % 10;
int last = (n%10);

System.Console.WriteLine( first+ " " + second +" " + prelast + " " + last);
if(first==last && second==prelast) System.Console.WriteLine("Это палиндром");
else System.Console.WriteLine("Не палиндром");

string chislo = n.ToString();
if(chislo.SequenceEqual(chislo.Reverse())){
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("No");