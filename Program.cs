while (true) {
   Console.Write ("Enter the number of inputs for LCM and GCD : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      while (true) {
         Console.Write ($"Enter {n} numbers leaving a space between them : ");
         string numbers = Console.ReadLine ();
         int[] values = numbers.Split (' ').Select (int.Parse).ToArray ();
         if (values.Length == n) {
            int gcd = GCD (values);
            int lcm = LCM (values);
            Console.WriteLine ($"\nGCD : {gcd}");
            Console.WriteLine ($"LCM : {lcm}"); break;
         } else Console.WriteLine ($"Enter '{n}' numbers.\n");
      }
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n"); break;
}

static int FindGCD (int x, int y) {
   while (y != 0) {
      int rem = x % y;
      x = y;
      y = rem;
   }
   return x;
}

static int FindLCM (int x, int y) {
   return (x * y) / FindGCD (x, y);
}

static int GCD (int[] values) {
   int gcd = values[0];
   for (int i = 1; i < values.Length; i++) gcd = FindGCD (gcd, values[i]);
   return gcd;
}

static int LCM (int[] values) {
   int lcm = values[0];
   for (int i = 1; i < values.Length; i++) lcm = FindLCM (lcm, values[i]);
   return lcm;
}


