// 27. Возведите число А в натуральную степень B используя цикл

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i=1; i<=b; i++) 
{
    result = result*a;
}
System.Console.WriteLine(result);

//result = (int)Math.Pow(a,b);

// a^b = a*a*a*a*a*a b times
//a*a*a*a*a*a b=6 times
//a = 2

//1 2
//2 4
//3 8
//4 16
//5 32
//6 64