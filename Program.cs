/// <summary>Program to generate all string character permutations</summary>
class Program {
   /// <summary>The entry point of the program</summary>
   static void Main () {
      while (true) {
         Console.Write ("Enter a string: ");
         string input = Console.ReadLine ();
         if (!input.All (char.IsLetter) || input.Length == 0) continue;
         Console.WriteLine ("Permutations of " + input + " are:");
         Permute (input.ToCharArray (), 0, input.Length - 1);
         break;
      }
   }

   /// <summary>Recursive function to generate permutations</summary>
   /// <param name="str">character array that contains characters to be permuted</param>
   /// <param name="left">integer representing the left index of the substring to be permuted</param>
   /// <param name="right">integer representing the right index of the substring to be permuted</param>
   static void Permute (char[] str, int left, int right) {
      if (left == right) Console.WriteLine (new string (str));
      else {
         for (int i = left; i <= right; i++) {
            Swap (ref str[left], ref str[i]);
            Permute (str, left + 1, right);
            Swap (ref str[left], ref str[i]); // Backtracks to the same string
         }
      }
   }

   /// <summary>Helper method to swap two characters in a character array</summary>
   static void Swap (ref char a, ref char b) => (b, a) = (a, b);
}
