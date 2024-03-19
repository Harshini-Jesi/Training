namespace Training {
   /// <summary>Program to sort and print anagrams</summary>
   internal class Program {
      static void Main () {
         var anagrams = File.ReadAllLines ("C:/etc/words.txt")
            .GroupBy (s => string.Concat (s.OrderBy (c => c))) // Groups the anagrams
            .Where (s => s.Count () > 1) // Removes the non anagram words
            .OrderByDescending (s => s.Count ()); // Sorts in descending order of its count
         using StreamWriter sw = new ("C:/etc/anagrams.txt");
         foreach (var word in anagrams) sw.WriteLine ($"{word.Count ()} {string.Join (" ", word)}");
      }
   }
}