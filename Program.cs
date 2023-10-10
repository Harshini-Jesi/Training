/// <summary>This program gets a character array A, along with special character S and sort order
/// and returns the sorted array by keeping the elements matching S to the last of the array.</summary>
class Program {
   static void Main () {
      char[] arr = CharArray ();
      char spclChar = SpecialChar ();
      Console.WriteLine ("Enter 'y' if you want to sort in descending: ");
      var key = Console.ReadKey (true).Key;
      var enumerableChar = arr.Where (x => x != spclChar);
      enumerableChar = (key == ConsoleKey.Y) ? enumerableChar.OrderDescending () : enumerableChar.Order ();
      var result = enumerableChar.ToList ();
      result.AddRange (Enumerable.Repeat (spclChar, arr.Length - result.Count));
      Console.WriteLine (string.Join (',', result));
   }

   /// <summary>To check if the given array is not empty and consists of only letters</summary>
   /// <returns>The non-empty char array with letters</returns>
   static char[] CharArray () {
      char[] arr = { };
      while (arr.Length == 0 || !arr.All (char.IsLetter)) {
         Console.Write ("Enter the character array A: ");
         arr = Console.ReadLine ().ToCharArray ();
      }
      return arr;
   }

   /// <summary>To check if the given special character is a letter</summary>
   /// <returns>The given special character</returns>
   static char SpecialChar () {
      while (true) {
         Console.Write ("Enter the special character S: ");
         if (!char.TryParse (Console.ReadLine (), out char spclChar) || !char.IsLetter (spclChar)) continue;
         else return spclChar;
      }
   }
}