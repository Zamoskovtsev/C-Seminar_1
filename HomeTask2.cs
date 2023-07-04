Console.Write("Введите первое целое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе целое число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1>Number2)
 {
   Console.Write($"Max {Number1}");
 }
 else
 { 
  if (Number1<Number2) 
   {
     Console.Write($"Max {Number2}");
   }
   else
   {
     Console.Write("Ничья");
   }
   } 
