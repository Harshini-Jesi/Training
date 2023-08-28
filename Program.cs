while (true) {
   Console.Write ("Enter the number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      Console.WriteLine ("Pascal's Triangle");
      for (int i = 1; i <= n; i++) {
         Console.Write (new string(' ', n - i + 1));
         int first = 1;
         for (int j = 1; j <= i; j++) {
            Console.Write ($"{first}  ");
            first = first * (i - j) / j;
         }
         Console.WriteLine ("\n");
      }
      break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n");
}
