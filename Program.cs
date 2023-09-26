int number = GetInput ("Enter a positive number : ");
char[] arr = Convert.ToString (number).ToCharArray ();
int max = arr.Length - 1;
Console.WriteLine ($"Enter the index positions to be swapped within 0 to {max}:");
int from = GetInput ("FromPosition = ", max);
int to = GetInput ("ToPosition = ", max);
Swap (arr, from, to);
Console.WriteLine ($"Index swapped number: {new string (arr)}");

///<summary>Gets the input from the user until it is a positive number</summary>
///<param name="prompt">Displays the prompt for the user to enter the input</param>
///<param name="max">if set to -1 no range check is done, otherwise checks if value is less than or equal to max</param>
int GetInput (string prompt, int max = -1) {
   while (true) {
      Console.Write (prompt);
      if (!int.TryParse (Console.ReadLine (), out int value) || value < 0) continue;
      if (max == -1 || value <= max) return value;
   }
}

void Swap (char[] arr, int from, int to) => (arr[to], arr[from]) = (arr[from], arr[to]);

