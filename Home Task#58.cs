// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//Процедура создания заполнения двухмерного массива размерностью m,n
using System.Text.Json.Serialization;

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
Console.WriteLine("");
Console.Write("Введите m размерность массива: ");
int k= Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите n размерность массива не равной m: ");
//int f = Convert.ToInt32(Console.ReadLine());
int[,] array1 = ArrInt(k,k);
Console.WriteLine();
int[,] array2 = ArrInt(k,k);
int[,] arrayMult=new int[k,k];
Console.WriteLine();
Console.WriteLine();
for (int i = 0;i<k; i++)
  {
    for (int j = 0;j<k; j++)
      {
        for (int a = 0; a<k;a++)
          {
            arrayMult[i,j]=arrayMult[i,j]+(array1[i,a]*array2[a,j]);
          }
      Console.Write($"{arrayMult[i,j],4}");   
      }
      Console.WriteLine();
  }
