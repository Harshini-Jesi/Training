Dictionary<string, int> wordsAndScore = new ();
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
var words = File.ReadAllLines ("H:/harshini.s/words.txt").
   Where (x => x.Length >= 4 && x.Contains (letters[0]) && x.All (letters.Contains));
List<string> pangram = new ();
foreach (string word in words) {
   if (word.Length == 4) wordsAndScore.Add (word, 1);
   else if (letters.All (word.Contains)) {
      wordsAndScore.Add (word, word.Length + 7); pangram.Add (word);
   } else if (word.Length > 4) wordsAndScore.Add (word, word.Length);
}
var sortedList = wordsAndScore.OrderByDescending (x => x.Value).ThenBy (x => x.Key).ToList ();
foreach (var kvp in sortedList) {
   if (pangram.Contains (kvp.Key)) Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine ($"{kvp.Value,3}. {kvp.Key}");
   Console.ResetColor ();
}
Console.WriteLine ($"----\n{wordsAndScore.Values.Sum ()} total");