// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//Процедура создания заполнения двухмерного массива размерностью m,n
using System.Diagnostics.CodeAnalysis;

int[,] ArrInt(int m, int n)
{
    int[,] randomArray = new int[n,m];
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = m;
             for (int i = 0; i < randomArray.Length; i++) {
                randomArray[row, col] = i + 1;
              if (--visits == 0) 
              {
                visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
                int temp = dx;
                dx = -dy;
                dy = temp;
                dirChanges++;
              }
              col += dx;
              row += dy;
            }
    return randomArray;
}
Console.WriteLine("");
Console.Write("Введите n размерность массива: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m размерность массива: ");
int f = Convert.ToInt32(Console.ReadLine());
int[,] Array = ArrInt(k,f);
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j],4}");
        }
    }
