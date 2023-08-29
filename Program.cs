int lowerlimit = 0, upperlimit = 128;
Console.WriteLine ("Think of a number between 0 and 127 in your mind.");
Console.WriteLine ("Answer the questions below by entering 'Y' if yes and 'N' if no.\n");
for (int i = 0; i < 7; i++) {
   Console.WriteLine ($"Is the number less than {(lowerlimit + upperlimit) / 2} : (Y)es or (N)o");
   var answer = Console.ReadKey (true).Key;
   if (answer == ConsoleKey.Y) {
      upperlimit = (lowerlimit + upperlimit) / 2;
   } else if (answer == ConsoleKey.N) {
      lowerlimit = (lowerlimit + upperlimit) / 2;
   } else {
      Console.WriteLine ("Incorrect Key\n"); i--;
   }
}
Console.WriteLine ($"\nThe number in your mind is {(lowerlimit + upperlimit) / 2}.");
