using System;
while (true) {
   Console.Write ("Enter a number : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      while (n > 9) {
         int c = 0;
         while (n > 0) {
            int r = n % 10;
            c += r;
            n /= 10;
         }
         n = c;
      }
      Console.WriteLine ($"Digital root : {n}"); break;
   } else Console.WriteLine ("Enter a valid number");
}
