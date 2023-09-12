Console.WriteLine ("Assign numbers for a and b");
int a = GetInput ("a = "), b = GetInput ("b = ");
swap (ref a, ref b);
Console.WriteLine ($"After swapping: a = {a}, b = {b}");

int GetInput (string prompt) {
   while (true) {
      Console.Write (prompt);
      if (int.TryParse (Console.ReadLine (), out int value)) return value;
      else continue;
   }
}

void swap (ref int a, ref int b) => (a, b) = (b, a);