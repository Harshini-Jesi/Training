using System;
namespace Fibonacci {
   class Program {
      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter a number : ");
            if (int.TryParse (Console.ReadLine (), out int n)) {
               Console.WriteLine ("Fibonacci series : ");
               int first = 0, second = 1, next = 0;
               for (int i = 0; i < n; i++) {
                  Console.WriteLine (first);
                  next = first + second;
                  first = second;
                  second = next;
               }
               break;
            } else Console.WriteLine ("Enter a valid number");
         }
      }
   }
}