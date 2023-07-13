//задача 21
 int[] PointA = new int[3] { 0, 0, 0};
 int[] PointB = new int[3] { 0, 0, 0};
 string[] Osi = new string[3] { "по оси Х","по оси Y", "по оси Z"};
 int[] Katet=new int[3] {0,0,0};
 int i =0;
 for (i=0; i<3; i++)
 {
     Console.Write($"Введите координаты {Osi[i]} точки А (целое):");
     PointA[i]=Convert.ToInt32(Console.ReadLine());
     Console.Write($"Введите координаты {Osi[i]} точки B (целое):");
     PointB[i]=Convert.ToInt32(Console.ReadLine());
 }
 double ResultAB=0;
 for (i=0; i<3; i++)
     {
         Katet[i]=0;
         if (PointA[i]>PointB[i])
         {
          Katet[i]=PointA[i]-PointB[i];
         }
             else
         {
          Katet[i]=PointB[i]-PointA[i];
         }
     }    
 ResultAB=Math.Sqrt(Math.Pow(Math.Sqrt(Katet[0]*Katet[0]+Katet[1]*Katet[1]),2)+Katet[2]*Katet[2]);
 Console.Write($"Расстояние между А и В {ResultAB}");
