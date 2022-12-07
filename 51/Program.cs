// 51.С клавиатуры вводится число N.
// Затем вводятся N чисел.
// Определить сколько чисел больше 0 введено с клавиатуры

int N = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[N];

for(int i = 0; i < N; i++){
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int c = Counter(arr);

System.Console.WriteLine(c);

int Counter(int[] array){
    int counter = 0;
    for(int i = 0; i < array.Count(); i++)
    {
        if(arr[i] > 0) counter++;
    }
    return counter;
}