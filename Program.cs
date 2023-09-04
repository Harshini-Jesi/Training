using System.Text;
while (true) {
   Console.Write ("Enter the string : ");
   string input = Console.ReadLine ();
   if (input.All (char.IsLetter)) {
      input = input.ToLower ();
      StringBuilder output = new StringBuilder ();
      foreach (char c in input) {
         if (output.Length > 0 && output[output.Length - 1] == c) output.Remove (output.Length - 1, 1);
         else output.Append (c);
      }
      var res = output.Length == 0 ? "Reduced string is 'Empty'" : $"Reduced string is '{output}'";
      Console.WriteLine (res);
      break;
   } else Console.WriteLine ("The string should consist of letters only.\n");
}