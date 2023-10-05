/// <summary>This program takes a string as input with each character in it representing a vote for a contestant and returns the winner with the most votes</summary>
class Program {
   static void Main () {
      while (true) {
         Console.Write ("Enter a string: ");
         string input = Console.ReadLine ().ToLower ();
         if (!input.All (char.IsLetter) || input.Length == 0) continue;
         char maxChar = Winner (input);
         Console.WriteLine ($"\nThe winner is {maxChar} with {Votes (input, maxChar)} votes.");
         break;
      }
   }

   /// <summary>Finds the char which is repeated most no.of times</summary>
   /// <param name="input">The string in which each character represents the vote of a contestant</param>
   /// <returns>The character that occurs most no.of times i.e.,the winner</returns>
   static char Winner (string input) {
      char maxChar = input[0]; int maxCount = 1;
      for (int i = 0; i < input.Length; i++) {
         char temp = input[i];
         int votes = Votes (input, temp);
         if (votes > maxCount) {
            maxCount = votes; maxChar = temp;
         }
      }
      return maxChar;
   }

   /// <summary>Calculates the no.of repetition of the winner i.e.,maximum repeated char</summary>
   /// <returns>The count i.e., votes of the winner</returns>
   static int Votes (string input, char c) {
      int count = 0;
      foreach (char ch in input) {
         if (ch == c) count++;
      }
      return count;
   }
}