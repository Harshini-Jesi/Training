Dictionary<string, (int score, bool IsPangram)> wordsAndScore = new ();
char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' };
// Filters the words that have length above 4 and consists of the given characters
var words = File.ReadAllLines ("data\\words.txt")
   .Where (x => x.Length >= 4 && x.Contains (letters[0]) && x.All (letters.Contains));
// Assigns values for score and IsPangram for each word
foreach (string word in words) {
   if (word.Length == 4) wordsAndScore.Add (word, (1, false));
   else if (letters.All (word.Contains)) {
      wordsAndScore.Add (word, (word.Length + 7, true));
   } else wordsAndScore.Add (word, (word.Length, false));
}
// Sorts the words in descending with respect to the score and then in ascending w.r.to the words
var sortedList = wordsAndScore.OrderByDescending (x => x.Value.score).ThenBy (x => x.Key);
int count = 0;
foreach (var kvp in sortedList) {
   // Prints the word in green colour, if it is a pangram
   if (kvp.Value.IsPangram == true) Console.ForegroundColor = ConsoleColor.Green;
   Console.WriteLine ($"{kvp.Value.score,3}. {kvp.Key}");
   Console.ResetColor ();
   count += kvp.Value.score;
}
Console.WriteLine ($"----\n{count} total");