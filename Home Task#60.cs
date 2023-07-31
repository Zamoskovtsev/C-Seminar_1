// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//Процедура создания заполнения трехмерного массива размерностью m,nб г
int[,,] ArrInt(int m, int n, int u)
{
    int[,,] randomArray = new int[m,n,u];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
          for (int j = 0; j < randomArray.GetLength(1); j++)
        {
          for (int e=0; e<randomArray.GetLength(2); e++)
          {
                randomArray[i,j,e] = new Random().Next(0,100);
          }  
        }
    }
    return randomArray;
}
Console.WriteLine("");
Console.Write("Введите m размерность массива 1: ");
int k= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n размерность массива 2: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k размерность массива 3: ");
int q = Convert.ToInt32(Console.ReadLine());
int[,,] array1 = ArrInt(k,f,q);
    for (int e = 0; e < array1.GetLength(2); e++)
    {
            for (int i = 0; i < array1.GetLength(0); i++)
        {
          for (int j=0; j<array1.GetLength(1); j++)
          {
               Console.Write($"{array1[i,j,e],4} ({i},{j},{e})");
          }  
          Console.WriteLine();
        }
    }
