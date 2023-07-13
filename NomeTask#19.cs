// Задача 19 
Console.Write($"Введите любое целое число:  ");
int Number1=Convert.ToInt32(Console.ReadLine());
String StrNum = Convert.ToString(Number1);
int Len = StrNum.Length;
int i = 1;
int n = (Len-1)/2;
Boolean Flag = true;
if (Len%2==0){n = Len/2;}
while (i<=n)
     {
         if (StrNum.Substring(i-1,1)==StrNum.Substring(Len-i,1)){Flag=true;}
         else{Flag=false;}   
         i++;
     }
     if (Flag==true){Console.Write($"Число {Number1} {Flag} является палиндромом");}
     else{Console.Write($"Число {Number1} {Flag} не является палиндромом");}
