int number = GetInput ("Enter a number : ");
char[] value = Convert.ToString (number).ToCharArray ();
while (true) {
   Console.WriteLine ("Enter the index positions to be swapped:");
   int a = GetInput ("FromPosition = "), b = GetInput ("ToPosition = ");
   if (a <= value.Length && b <= value.Length) {
      swap (value, a, b);
      Console.WriteLine ($"Index swapped number: {new string (value)}");
      break;
   } else Console.WriteLine ($"Enter index positions within {value.Length - 1}\n");
}
int GetInput (string prompt) {
   while (true) {
      Console.Write (prompt);
      if (int.TryParse (Console.ReadLine (), out int value)) return value;
      else continue;
   }
}

void swap (char[] value, int a, int b) => (value[b], value[a]) = (value[a], value[b]);