// разбор задачи на abc и cab
// Задача: можно ли из одной последовательности получить другую ABC=>CAB, ABC=>CBA

bool Test(string s1,string s2)
{
    if (s1.Length!=s2.Length) return false;

    char[] c1=s1.ToCharArray();
    char[] c2=s2.ToCharArray();
    Array.Sort(c1); //ABC
    Array.Sort(c2); //ABC
    s1=new String(c1);
    s2=new String(c2);
    return s1==s2;
}

string s1="ABCR";
string s2="BCAT";

System.Console.WriteLine(Test(s1,s2));