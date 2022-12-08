char c='a'; // хранит в себе сам символ, в отличии от стринг
c='\x64';
c='\u0064';
char b='a';
System.Console.WriteLine((int)b); //увидеть код символа
System.Console.WriteLine(c.ToString()+b.ToString()); //преобразовать в символы
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit"); //является ли это цифрой

string s="asdf"; // Класс - ссылочный тип, не хранит в себе строчку, а хранит ссылку на строчку
//immutable string (не изменяемые строки)
System.Console.WriteLine(s[0]); //вывести первый символ в строке (индекс 0)

for(int i=0;i<s.Length;i++) 
System.Console.WriteLine(s[i]); // вывести каждый элемент строки (как в массиве)

//В CS нельзя менять внутри строки символы, присваивать какие-либо символы s[0]='S'
// Для этого строчку преобразуем в массив 
char[] cc=s.ToCharArray(); // перебрасываем в массив cc
cc[0]='S'; // меняем нужный элемент
s=new String(cc) ; // и обратно преобразуем в строчку, создав новую строку

// если строк очень очень много эффективнее использовать:
System.Text.StringBuilder sb=new System.Text.StringBuilder("asda");
sb[0]='s';// вносим изменения

s=sb.ToString(); //обратно преобразем в неизменную строку



string s1="Hello";
string s2="Hello";
System.Console.WriteLine((s1==s2)); // Сравнивается содержимое в строке
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1,s2));

//s1.Length
s2=s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("af")); // поиск совпаения символа(набора символов) в строке
s2=s1.Replace('a','b'); // меняет один элемент на другой
s1=s1.Replace("ab","ba"); // меняет набор элементов на другой набор