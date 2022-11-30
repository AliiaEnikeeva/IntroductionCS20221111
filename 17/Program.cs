// 17. Дано число обозначающее день недели.
// Выяснить является номер дня недели выходным
//1 2 3 4 5 6 7
if(!int.TryParse(Console.ReadLine(), out int n)){
    System.Console.WriteLine("Введите число");
}

if(n == 6 || n == 7) System.Console.WriteLine("Выходной"); else System.Console.WriteLine("не выходной");

//asfdsfsf --- > какое-то число --> false
//true false
//1    0

//"5" --> 5 --> true 