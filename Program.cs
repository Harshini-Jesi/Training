using System;
while (true) {
   Console.Write ("Enter a number : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      while (n > 9) {
         int c = 0;
         while (n > 0) {
            c += n % 10;
            n /= 10;
         }
         n = c;
      }
      Console.WriteLine ($"Digital root : {n}");
      break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n");
}
