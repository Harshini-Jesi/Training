while (true) {
   Console.Write ("Enter a number: ");
   if (!int.TryParse (Console.ReadLine (), out int n)) continue;
   Console.WriteLine ($"Factorial of {n} is {Factorial (n)}");
   break;
}

static int Factorial (int n) {
   if (n == 0) return 1;
   return n * Factorial (n - 1);
}