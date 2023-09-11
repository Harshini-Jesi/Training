while (true) {
   Console.Write ("Enter a decimal number: ");
   string input = Console.ReadLine ();
   if (!decimal.TryParse (input, out decimal result)) continue;
   string[] splits = input.Split ('.').ToArray ();
   Console.WriteLine ($"integral part: {ToSpaceSeparatedString (splits[0])}");
   var s = splits.Length > 1 ? ToSpaceSeparatedString (splits[1]) : "There is no factorial part.";
   Console.WriteLine ($"factorial part: {s}");
   break;
}

static string ToSpaceSeparatedString (string input) {
   string spacedString = string.Join (" ", input.Select (c => c));
   return spacedString;
}