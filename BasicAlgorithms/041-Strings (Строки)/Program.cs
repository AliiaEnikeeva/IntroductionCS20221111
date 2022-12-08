// ReadLn(a,b,c)
//Как в одну строчку
//10 20 30
/*string s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] n=new int[ss.Length];
for(int i=0;i<ss.Length;i++)
    n[i]=Convert.ToInt32(ss[i]);
int a=n[0];
int b=n[1];
int c=n[2];
*/

string[] ss=Console.ReadLine().Split(' '); //сразу создать массив
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);// преобразовать из массива в строку
int a=n[0];
int b=n[1];
int c=n[2];