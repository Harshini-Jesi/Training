Console.WriteLine ("Think of a number between 0 and 127 in your mind.");
Console.WriteLine ("Answer the questions below by entering 'Y' if yes and 'N' if no.\n");
int rem = 0; string binary = "";
for (int i = 1; i <= 7; i++) {
   Console.WriteLine ($"Is the remainder {rem} when divided by {Math.Pow (2, i)}: (Y)es or (N)o");
   var answer = Console.ReadKey (true).Key;
   if (answer == ConsoleKey.Y) binary = "0" + binary;
   else if (answer == ConsoleKey.N) {
      binary = "1" + binary; rem = Convert.ToInt32 (binary, 2);
   } else { Console.WriteLine ("Incorrect Key\n"); i--; }
}
Console.WriteLine ($"\nThe number in your mind is {rem}.");
