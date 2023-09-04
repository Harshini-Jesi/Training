while (true) {
   Console.Write ("Enter the number of input words : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      while (true) {
         Console.Write ($"Enter {n} words leaving a space between them : ");
         string enteredWords = Console.ReadLine ();
         string[] allWords = enteredWords.Split (' ').ToArray ();
         List<string> alignedWords = new ();
         if (allWords.Length == n) {
            foreach (string word in allWords) {
               char[] chars = word.ToCharArray ();
               Array.Sort (chars);
               if (new string (chars) == word) alignedWords.Add (word);
            }
            var sort = alignedWords.OrderBy (word => word.Length);
            var res = alignedWords.Count == 0 ? "" : $"The longest abecedarian word is {sort.LastOrDefault ()}";
            Console.WriteLine (res);
            break;
         } else Console.WriteLine ($"Enter '{n}' words.\n");
      }
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n");
   break;
}
