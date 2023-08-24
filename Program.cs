using System;
namespace PrimeNumber {
   class Program {
      static bool IsPrime (int n) {
         if (n <= 1) return false;
         if (n <= 3) return true;
         if (n % 2 == 0 || n % 3 == 0) return false;
         for (int i = 5; i * i <= n; i += 6)//To see if the number can represented as 6k+1 or 6k-1
            if (n % i == 0 || n % (i + 2) == 0) return false;//i checks for 6k+1 and i+2 checks for 6k-1
         return true;
      }

      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter a number : ");
            if (int.TryParse (Console.ReadLine (), out int n)) {
               var res = IsPrime (n) ? $"{n} is a prime number" : $"{n} is not a prime number";
               Console.WriteLine (res); break;
            } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'");
         }
      }
   }
}