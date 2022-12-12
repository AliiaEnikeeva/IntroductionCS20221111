//86. Подсчитать сколько раз определенный символ (например 'a')
// встречается в строке.

string str= Console.ReadLine();

System.Console.WriteLine(Find(str, 'a'));

int Find(string str, char ch){
    int counter = 0;
    for(int i= 0; i < str.Length; i++){
        if(ch == str[i]) counter++;
    }
    return counter;
}