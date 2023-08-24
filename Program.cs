using System;
while (true) {
   Console.Write ("Enter a number : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      int spaces = n, stars = 1;
      for (int i = 0; i <= n; i++) {
         Console.WriteLine (string.Concat (Enumerable.Repeat (" ", spaces)) + string.Concat (Enumerable.Repeat ("*", stars)));
         spaces -= 1; stars += 2;
      }
      spaces += 2; stars -= 4;
      for (int i = 1; i <= n; i++) {
         Console.WriteLine (string.Concat (Enumerable.Repeat (" ", spaces)) + string.Concat (Enumerable.Repeat ("*", stars)));
         spaces += 1; stars -= 2;
      }
      break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'");
}