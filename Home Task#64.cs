// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Write("Ввести число M: ");
int M = Convert.ToInt32(Console.ReadLine());
int step=-1;
Console.Write($"N = {M} -> ");
string PrintN(int start, int end, int st)
{
    if(start == end) return Convert.ToString(start);
    return(start + " " + PrintN(start + st, end,st));
}
Console.Write(PrintN(M, 1, step));
