while (true) {
   Console.Write ("Enter the number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      for (int i = 1; i <= n; i++) {
         Console.Write (string.Concat (Enumerable.Repeat (" ", n - i + 1)));
         int first = 1;
         for (int j = 1; j <= i; j++) {
            Console.Write ($"{first,5}" + " ");
            first = first * (i - j) / j;
         }
         Console.WriteLine ("\n");
      }
      break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'");
}
