using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            Console.Write ("Enter a number : ");
            int n = int.Parse (Console.ReadLine ());
         var res => IsPrime (n) ? (Console.WriteLine ($"{n} is a prime number") : Console.WriteLine ($"{n} is not a prime number"));
        }
    }
}