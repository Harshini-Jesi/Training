/// <summary>This program gets a character array A, along with special character S and sort order
/// and returns the sorted array by keeping the elements matching S to the last of the array.</summary>
class Program {
   static void Main () {
      string result = "", result1 = "", result2 = "";
      char[] arr = CharArray ();
      char spclChar = SpecialChar ();
      foreach (char c in arr) {
         if (c != spclChar) result1 += c;
         else result2 += c;
      }
      Console.WriteLine ("Enter 'y' if you want to sort in descending: ");
      var key = Console.ReadKey (true).Key;
      if (key == ConsoleKey.Y) {
         char[] desArr = result1.OrderDescending ().ToArray ();
         result = new string (desArr) + result2;
         Console.WriteLine (string.Join (',', result.Select (c => c)));
      } else {
         char[] ascArr = result1.ToArray ();
         Array.Sort (ascArr);
         result = new string (ascArr) + result2;
         Console.WriteLine (string.Join (',', result.Select (c => c)));
      }
   }

   /// <summary>To check if the given array is not empty and consists of only letters</summary>
   /// <returns>The non-empty char array with letters</returns>
   static char[] CharArray () {
      while (true) {
         Console.Write ("Enter the character array A: ");
         char[] arr = Console.ReadLine ().ToCharArray ();
         if (arr.Length == 0 || !arr.All (char.IsLetter)) continue;
         else return arr;
      }
   }

   /// <summary>To check if the given special character is letter</summary>
   /// <returns>The given special character</returns>
   static char SpecialChar () {
      while (true) {
         Console.Write ("Enter the special character S: ");
         if (!char.TryParse (Console.ReadLine (), out char spclChar) || !char.IsLetter (spclChar)) continue;
         else return spclChar;
      }
   }
}