using System;
while (true) {
   Console.Write ("Enter the number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      int spaces = n, stars = 1;
      for (int i = 0; i <= n; i++) {
         Console.WriteLine (string.Concat (Enumerable.Repeat (" ", spaces)) + stars);
         spaces -= 1; stars += 1;
      }
      break;
   } else Console.WriteLine ("Enter a valid number");
}