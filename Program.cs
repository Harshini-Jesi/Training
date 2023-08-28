Console.Write ("Select a mode  (E)asy, (M)edium, (H)ard : ");
var mode = GetMode (); Console.WriteLine (mode);
int max = mode switch {
   Mode.Easy => 10,
   Mode.Medium => 100,
   _ => 1000
};
Random random = new Random ();
int target = random.Next (1, max + 1);
Console.WriteLine ($"Guess a number between 1 and {max}\n");
int tries = 0, n = 0;
while (n != target) {
   Console.Write ("Enter a number of your guess : ");
   if (int.TryParse (Console.ReadLine (), out n)) {
      tries++;
      if (n < target) Console.WriteLine ("Try higher\n");
      if (n > target) Console.WriteLine ("Try lower\n");
      if (n == target) Console.WriteLine ($"\nYou guessed the number in {tries} tries");
   } else Console.WriteLine ("Invalid input. Please enter a valid 'NUMBER'\n");
}

Mode GetMode () {
   for (; ; ) {
      var key = Console.ReadKey (true).Key;
      switch (key) {
         case ConsoleKey.E: return Mode.Easy;
         case ConsoleKey.M: return Mode.Medium;
         case ConsoleKey.H: return Mode.Hard;
         default: Console.WriteLine ("Incorrect key\n");
            break;
      }
   }
}

enum Mode { Easy, Medium, Hard };