using System.Text;
while (true) {
   Console.Write ("Enter the string : ");
   string input = Console.ReadLine ();
   if (input.All (char.IsLetter)) {
      input = input.ToLower ();
      StringBuilder output = new StringBuilder ();
      for (int i = 0; i < input.Length; i++) {
         if (i == input.Length - 1 || input[i] != input[i + 1]) output.Append (input[i]);
         else i++;
      }
      Console.WriteLine (output.Length == 0 ? "Reduced string is 'Empty'" : $"Reduced string is '{output}'");
      break;
   } else Console.WriteLine ("The string should consist of letters only.\n");
}