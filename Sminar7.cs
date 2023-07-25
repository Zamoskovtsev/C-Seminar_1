Zadacha47();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Zadacha50();
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Zadacha52();
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArrInt(int m, int n)
{
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().Next(0,11);
            Console.Write($"{randomArray[i,j],4}");
        }
    }
    return randomArray;
}

double[,] Arr(int m, int n)
{
    double[,] randomArray = new double[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().NextDouble()*10;
            Console.Write($"{Math.Round(randomArray[i,j],1),6}");
        }
        Console.WriteLine();
    }
    return randomArray;
}
void Zadacha47()
{
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.Write("Введите m размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array=Arr(m,n);
}
void Zadacha50()
{
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.Write("Введите m размерность массива: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n размерность массива: ");
    int f = Convert.ToInt32(Console.ReadLine());
    int[,] Array = ArrInt(k,f);
    Console.WriteLine();
    Console.Write("Введите номер строки: ");
    int xi = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int xj = Convert.ToInt32(Console.ReadLine());
    if (xi<Array.GetLength(0)-1 && xj<Array.GetLength(1)-1)
    {
        Console.WriteLine($"Элемент массива [{xi},{xj}] существует и равен {Array[xi,xj]}");   
    }
    else
    {
        Console.WriteLine($"Элемента массива [{xi},{xj}] в данном массиве нет");
    }
}
void Zadacha52()
{
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.Write("Введите m размерность массива: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n размерность массива: ");
    int f = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int xj = Convert.ToInt32(Console.ReadLine());
    int[,] Array = ArrInt(k,f);
    double Average=0;
    Console.WriteLine();
    for (int i = 0; i < k; i++)
    {
        Average=Average+Array[i,xj];
    }
    Average=Average/k;
    Console.WriteLine(Average);
}
