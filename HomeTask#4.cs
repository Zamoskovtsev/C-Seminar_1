Console.Write("Введите первое целое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());
int MaxRes=Number1;
if (Number1<Number2)
   {
     MaxRes=Number2;
   }
  if (MaxRes<Number3)
   { 
     MaxRes=Number3;
   } 
     Console.Write($"Max {MaxRes}");   
