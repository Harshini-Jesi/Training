/// <summary>This program gets a character array A, along with special character S and sort order
/// and returns the sorted array by keeping the elements matching S to the last of the array.</summary>
class Program {
   static void Main () {
      char[] arr = CharArray ();
      char spclChar = SpecialChar ();
      Console.WriteLine ("\nEnter 'y' if you want to sort in descending: ");
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
      string arr = "";
      do{
         Console.Write ("Enter the character array A: ");
         arr=Console.ReadLine ();
      } while(arr.Length==0 || !arr.All(char.IsLetter));
      return arr.ToCharArray ();
   }

   /// <summary>To check if the given special character is a letter</summary>
   /// <returns>The given special character</returns>
   static char SpecialChar () {
      char spclChar;
      do {
         Console.Write ("\nEnter the special character S: ");
         spclChar = Console.ReadKey ().KeyChar;
      } while(!char.IsLetter(spclChar));
      return spclChar;
   }
}