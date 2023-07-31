// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//Процедура создания заполнения двухмерного массива размерностью m,n
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
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n размерность массива: ");
int f = Convert.ToInt32(Console.ReadLine());
int[,] Array = ArrInt(k,f);
Console.WriteLine();
int[] arrStr =new int[f];
for (int arrs=0; arrs<k;arrs++)
{
for (int i =0; i < f; i++) {arrStr[i]=Array[arrs,i];} //строку двухмерного в одномерный массив
int temp=arrStr[0];
int indexmax=0;
int[] arrtemp = new int[f];
  for (int i = 0; i < f; i++) {arrtemp[i]=0;} 
  for (int i = 0; i < f; i++)
  {
    for (int j = 0; j< f; j++)
      {
        if (arrStr[j]>temp)
          {
            temp=arrStr[j];
            indexmax=j;
           
          }
      }
      arrStr[indexmax]=0;
      arrtemp[i]=temp;
      temp=0;
  } 
  for (int i =0; i < f; i++) {Array[arrs,i]=arrtemp[i];}
}
    for (int i = 0; i < k; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < f; j++)
        {
            Console.Write($"{Array[i,j],4}");
        }
    }
