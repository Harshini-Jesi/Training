/// <summary>This program takes a string as input with each character in it representing a vote for a contestant 
/// and returns the winner with the most votes.</summary>
class Program {
   static void Main () {
      while (true) {
         Console.Write ("Enter a string: ");
         string input = Console.ReadLine ().ToLower ();
         if (!input.All (char.IsLetter) || input.Length == 0) continue;
         Console.WriteLine ($"{Winner (input)} => Winner and Votes");
         break;
      }
   }

   /// <summary>Finds the most repeated char and its no.of repetition in a string</summary>
   /// <param name="input">The string in which each character represents the vote for a contestant</param>
   /// <returns>The most repeated char i.e.,the winner and its no.of.repetition i.e.,the votes</returns>
   static (char, int) Winner (string input) {
      Dictionary<char, int> output = new ();
      char maxChar = ' '; int maxCount = 0;
      foreach (char c in input) {
         if (output.TryGetValue (c, out int value)) output[c] = value + 1;
         else output.Add (c, 1);
      }
      foreach (var ele in output) {
         if (ele.Value > maxCount) {
            maxCount = ele.Value; maxChar = ele.Key;
         }
      }
      return (maxChar, maxCount);
   }
}