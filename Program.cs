int number = GetInput ("Enter a positive number : ");
char[] value = Convert.ToString (number).ToCharArray ();
Console.WriteLine ($"Enter the index positions to be swapped within 0 to {value.Length - 1}:");
while (true) {
   int a = GetInput ("FromPosition = ");
   if (a < value.Length) {
      while (true) {
         int b = GetInput ("ToPosition = ");
         if (b < value.Length) {
            swap (value, a, b);
            Console.WriteLine ($"Index swapped number: {new string (value)}");
            break;
         } else continue;
      }break;
   } else continue;
}
int GetInput (string prompt) {
   while (true) {
      Console.Write (prompt);
      if (int.TryParse (Console.ReadLine (), out int value) && value >= 0) return value;
      else continue;
   }
}

void swap (char[] value, int a, int b) => (value[b], value[a]) = (value[a], value[b]);