/// <summary>Program that swaps the number from one index position to another</summary>
class Program {
   /// <summary>The entry point of the program</summary>
   static void Main () {
      int number = GetInput ("Enter a positive number : ");
      char[] arr = Convert.ToString (number).ToCharArray ();
      int max = arr.Length - 1;
      Console.WriteLine ($"Enter the index positions to be swapped within 0 to {max}:");
      int from = GetInput ("FromPosition = ", max);
      int to = GetInput ("ToPosition = ", max);
      Swap (arr, from, to);
      Console.WriteLine ($"Index swapped number: {new string (arr)}");
   }

   ///<summary>Gets the input from the user until it is a positive number</summary>
   ///<param name="prompt">Displays the prompt for the user to enter the input</param>
   ///<param name="max">if set to -1 no range check is done, otherwise checks if value is less than or equal to max</param>
   static int GetInput (string prompt, int max = -1) {
      while (true) {
         Console.Write (prompt);
         if (!int.TryParse (Console.ReadLine (), out int value) || value < 0) continue;
         if (max == -1 || value <= max) return value;
      }
   }

   /// <summary>Interchanges the values in the index positions of an array</summary>
   /// <param name="arr">character array that consists the given input number</param>
   /// <param name="from">The index position from which the value has to swapped</param>
   /// <param name="to">The index position to which the value has to swapped</param>
   static void Swap (char[] arr, int from, int to) => (arr[to], arr[from]) = (arr[from], arr[to]);
}

