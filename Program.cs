int number = GetInput ("Enter a number : ");
char[] value = Convert.ToString (number).ToCharArray ();
Console.WriteLine ("Enter the index positions to be swapped:");
int a = GetInput ("FromPosition = "), b = GetInput ("ToPosition = ");
swap (value, ref a, ref b);
Console.WriteLine ($"Index swapped number: {new string (value)}");

int GetInput (string prompt) {
   while (true) {
      Console.Write (prompt);
      if (int.TryParse (Console.ReadLine (), out int value)) return value;
      else continue;
   }
}

void swap (char[] value, ref int a, ref int b) => (value[b], value[a]) = (value[a], value[b]);
