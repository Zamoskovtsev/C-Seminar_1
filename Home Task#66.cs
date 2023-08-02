// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Ввести число M: ");
int M= Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int step=1;
if (N<M)
    {
      step=(-1);
    }
    Console.Write($"Сумма числе между {M} и {N} равно = ");
int summofnumber(int start, int end, int st)
{
    if (start == end) {return start;}
    return(start+ summofnumber(start+st,end,st));
}
Console.WriteLine(summofnumber(M,N,step));
