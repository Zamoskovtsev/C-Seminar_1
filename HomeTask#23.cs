// Задача 23 
Console.Write($"Введите целое число:  ");
int Number=Convert.ToInt32(Console.ReadLine());
int i=0;
for (i=0; i<Number+1; i++)
 {
     Console.WriteLine($"Куб числа {i} равен {Math.Pow(i,3)}");
 }
