using System;
namespace numbereverse {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Enter the number : ");
            int n=int.Parse (Console.ReadLine());
            int h=n;
            int c = 0;
            while(n>0) {
                int r=n%10;
                c = (c*10) + r;
                n/=10;
            }
            Console.WriteLine ($"Reversed number : {c}");
            if (h == c) {
                Console.WriteLine ("It is a palindrome number");
            } else
                Console.WriteLine ("It is not a palindrome number");
        }
    }
}