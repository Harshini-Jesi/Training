while (true) {
   Console.Write ("Enter a decimal number: ");
   string input = Console.ReadLine ();
   if (!decimal.TryParse (input, out decimal result)) continue;
   if (input.Contains ('.')) {
      string[] number = input.Split ('.').ToArray ();
      Console.WriteLine ($"integral part: {ToSpaceSeparatedString (number[0])}\nfactorial part: {ToSpaceSeparatedString (number[1])}"); break;
   } else Console.WriteLine ($"integral part: {ToSpaceSeparatedString (input)}\nfactorial part: There is no factorial part."); break;
}

static string ToSpaceSeparatedString (string input) {
   string spacedString = string.Join (" ", input.Select (c => c));
   return spacedString;
}