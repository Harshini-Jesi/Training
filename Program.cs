using System;
namespace primenumber {
   class Program {
      static bool IsPrime (int n) {
         if (n <= 1) return false;
         if (n <= 3) return true;
         if (n % 2 == 0 || n % 3 == 0) return false;
         for (int i = 5; i * i <= n; i += 6)
            if (n % i == 0 || n % (i + 2) == 0) return false;
         return true;
      }
      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter a number : ");
            if (int.TryParse (Console.ReadLine (), out int n)) {
               var res = IsPrime (n) ? $"{n} is a prime number" : $"{n} is not a prime number";
               Console.WriteLine (res); break;
            } else Console.WriteLine ("Enter a valid number");
         }
      }
   }
}