while (true) {
   Console.Write ("Enter the number of input words : ");
   if (!int.TryParse (Console.ReadLine (), out int n)) continue;
   while (true) {
      Console.Write ($"Enter {n} words leaving a space between them : ");
      string enteredWords = Console.ReadLine ();
      string[] allWords = enteredWords.Split (' ').ToArray ();
      if (allWords.Length != n) continue;
      List<string> alignedWords = new ();
      foreach (string word in allWords) {
         char[] chars = word.ToCharArray ();
         Array.Sort (chars);
         if (new string (chars) == word) alignedWords.Add (word);
      }
      var sort = alignedWords.OrderBy (word => word.Length);
      Console.WriteLine (alignedWords.Count == 0 ? "No abecedarian word." : $"The longest abecedarian word is {sort.LastOrDefault ()}.");
      break;
   }
   break;
}
