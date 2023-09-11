while (true) {
   Console.WriteLine ("Assign numbers for a and b");
   Console.Write ("a = ");
   if (!int.TryParse (Console.ReadLine (), out int a)) continue;
   Console.Write ("b = ");
   if (!int.TryParse (Console.ReadLine (), out int b)) continue;
   Console.WriteLine ($"After swapping: a = {swap (b, a)}, b = {swap (a, b)}");
   break;
}

static int swap (int a, int b) {
   int temp = a;
   a = b;
   b = temp;
   return temp;
}