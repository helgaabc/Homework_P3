﻿double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{    
     return Math.Round(Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2)+  Math.Pow(z1 - z2,2)),4); 
}  
Console.WriteLine (Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine (Distance(7, -5, 0, 1, -1, 9));
