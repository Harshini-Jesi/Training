using System;
namespace LcmGcd {
   class Program {
      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter first number : ");
            if (int.TryParse (Console.ReadLine (), out int n1)) {
               Console.Write ("Enter second number : ");
               if (int.TryParse (Console.ReadLine (), out int n2)) {
                  int gcd = GCD (n1, n2), lcm = LCM (n1, n2);
                  Console.WriteLine ($"GCD : {gcd}");
                  Console.WriteLine ($"LCM : {lcm}"); break;
               } else Console.WriteLine ("Enter a valid number");
            } else Console.WriteLine ("Enter a valid number");
         }

         static int GCD (int x, int y) {
            while (y != 0) {
               int rem = x % y;
               x = y;
               y = rem;
            }
            return x;
         }

         static int LCM (int x, int y) {
            return (x * y) / GCD (x, y);
         }
      }
   }
}