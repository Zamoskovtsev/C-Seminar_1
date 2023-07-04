Console.Write("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int ResDel=Number%2;
if (ResDel==0)
   {
     Console.Write($"Число  {Number}  четное");
   }
 else  
  {
     Console.Write($"Число  {Number}  не четное");
   }
