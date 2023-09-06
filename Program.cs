while (true) {
   Console.Write ("Enter the number of input words : ");
   if (!int.TryParse (Console.ReadLine (), out int n)) continue;
   while (true) {
      Console.Write ($"Enter {n} words leaving a space between them : ");
      string[] allWords = Console.ReadLine ().Split (' ').ToArray ();
      if (allWords.Length != n) continue;
      List<string> alignedWords = new ();
      foreach (string word in allWords) {
         char[] chars = word.ToCharArray ();
         Array.Sort (chars);
         if (new string (chars) == word) alignedWords.Add (word);
      }
      Console.WriteLine (alignedWords.Any () ? $"The longest abecedarian word is {alignedWords.MaxBy (word => word.Length)}." : "No abecedarian word.");
      break;
   }
   break;
}
