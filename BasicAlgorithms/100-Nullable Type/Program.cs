/*
int? a=0;
a=null;
Nullable<int> b=0;
*/
int? a=0;
//a=null;
System.Console.WriteLine(a.HasValue); // есть значение или нет (false)
System.Console.WriteLine(a.HasValue+" "+a.Value); //если есть значение то его получить

int? Test()
{
  return null;  
}


string? s;
s=null;
