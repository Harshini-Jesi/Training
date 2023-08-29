using System.Xml.Serialization;

while (true) {
   Console.Write ("Enter the number of rows : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      Console.WriteLine ("Pascal's Triangle");
      int space = n * 2;
      for (int i = 1; i <= n; i++, space -= 2) {
         Console.Write (new string (' ', space));
         int first = 1;
         for (int j = 1; j <= i; j++) {
            Console.Write ($"{first}   ");
            first = first * (i - j) / j;
         }
         Console.WriteLine ("\n");
      }
      break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n");
}
