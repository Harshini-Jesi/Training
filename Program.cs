using System.Text;
while (true) {
   Console.Write ("Enter the string of lowercase : ");
   string input = Console.ReadLine ();
   if (input.All (char.IsLower)) {
      StringBuilder output = new StringBuilder ();
      foreach (char c in input) {
         var function = output.Length > 0 && output[output.Length - 1] == c ? output.Remove (output.Length - 1, 1) : output.Append (c);
      }
      var res = output.Length==0 ? "Reduced string is 'Empty'" : $"Reduced string is '{output}'";
      Console.WriteLine (res);
      break;
   } else Console.WriteLine ("Enter the string in lowercase.\n");
}