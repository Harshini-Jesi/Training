using System.Text.RegularExpressions;

while (true) {
   Console.Write ("Enter a decimal number: ");
   string input = Console.ReadLine ();
   if (input.All (char.IsDigit)) {
      Console.WriteLine ($"integral part: {AddSpaces (input)}\nfactorial part: There is no factorial part."); break;
   } else if (Regex.IsMatch (input, @"^[0-9]+\.[0-9]+$")) {
      string[] number = input.Split ('.').ToArray ();
      Console.WriteLine ($"integral part: {AddSpaces (number[0])}\nfactorial part: {AddSpaces (number[1])}"); break;
   } else continue;
}

static string AddSpaces (string input) {
   string spacedString = string.Join (" ", input.Select (c => c));
   return spacedString;
}