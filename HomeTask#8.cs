//Задача 8
Console.Write("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int ResDel;
for (int i=1; i<=Number; i++)
{
    ResDel=i%2;
 if (ResDel==0)
   {
     Console.WriteLine($"Число  {i}  четное");
   }
}
