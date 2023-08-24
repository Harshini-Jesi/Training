using System;
Random random = new Random ();
int target = random.Next (1, 101);
int tries = 0, n = 0;
Console.WriteLine ("Guess a number between 1 and 100\n");
while (n != target) {
   Console.Write ("Enter a number of your guess : ");
   if (int.TryParse (Console.ReadLine (), out n)) {
      tries++;
      if (n < target) Console.WriteLine ("Try higher\n");
      if (n > target) Console.WriteLine ("Try lower\n");
      if (n == target) Console.WriteLine ($"\nYou guessed the number in {tries} tries");
   } else Console.WriteLine ("Enter a valid number");
}
