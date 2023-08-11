using System;
namespace Fibonacci {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Input : ");
            int n = int.Parse (Console.ReadLine ());
            Console.Write ("Fibonacci series : ");
            for (int i = 0; i < n; i++) { Console.Write (fib (i) + " "); }
        }
        static int fib (int n) {
            if (n <= 1)
                return n;
            int fib1 = 0, fib2 = 1, fib3 = 0;
            for (int i = 2; i <= n; i++) {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
            }
            return fib3;
        }
    }
}