// 84. Определить являются ли введенные с клавиатуры
// символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа

int number;

bool isNumber = int.TryParse(Console.ReadLine(), out number);

if(isNumber) 
    System.Console.WriteLine("Yes");
else 
    System.Console.WriteLine("No");

System.Console.WriteLine(Sum(number));

// 548 
int Sum(int num){
    int sum =0;
    char[] numArr = num.ToString().ToCharArray();

    for(int i =0; i < numArr.Count(); i++){
        int a = int.Parse(numArr[i].ToString());
        sum = sum +a;
    }

    return sum;
}