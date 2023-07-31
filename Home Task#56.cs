// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int k= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n размерность массива не равной m: ");
int f = Convert.ToInt32(Console.ReadLine());
int[] arrtemp = new int[k];
bool flag=true;
if (k==f){flag=false;}
if (flag==true)
{
  int[,] Array = ArrInt(k,f);
  Console.WriteLine();
  int temp=0;
  for (int i = 0; i < k; i++)
    {
      for (int j = 0; j < f; j++){temp=temp+Array[i,j];}
      arrtemp[i]=temp;
      Console.WriteLine(arrtemp[i]);
      temp=0;
    }
int mindex=0;
for (int i = 0; i < k; i++)
{ 
    if (arrtemp[i] ==arrtemp.Min())
        {
          Console.WriteLine($"Мин номер строки {i}, минимальная сумма {arrtemp.Min()}");
        }
}
}
