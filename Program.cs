using System;
namespace lcm_gcd {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Input 1 : ");
            int n1 = int.Parse (Console.ReadLine ());
            Console.Write ("Input 2 : ");
            int n2 = int.Parse (Console.ReadLine ());
            int gcd = GCD (n1, n2);
            int lcm = LCM (n1, n2);
            Console.WriteLine ($"GCD : {gcd}");
            Console.WriteLine ($"LCM : {lcm}");
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