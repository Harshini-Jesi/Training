int lowerlimit = 0, upperlimit = 128;
int avg = (upperlimit + lowerlimit) / 2;
Console.WriteLine ("Think of a number between 0 and 127 in your mind.");
Console.WriteLine ("Answer the questions below by entering 'Y' if yes and 'N' if no.\n");
for (int i = 0; i < 7; i++) {
   Console.WriteLine ($"Is the number less than {avg} : (Y)es or (N)o");
   var answer = Console.ReadKey (true).Key;
   if (answer == ConsoleKey.Y) {
      upperlimit = avg;
      avg = (lowerlimit + avg) / 2;
   } else if (answer == ConsoleKey.N) {
      lowerlimit = avg;
      avg = (upperlimit + avg) / 2;
   } else {
      Console.WriteLine ("Incorrect Key\n"); i--;
   }
}
Console.WriteLine ($"\nThe number in your mind is {avg}.");
