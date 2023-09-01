while (true) {
   Console.Write ("Enter the string of lowercase : ");
   string input = Console.ReadLine ();
   if (input.All (char.IsLower)) {
      var res = input.Distinct ().Count () == input.Length ? "It's an isogram" : "It's not an isogram";
      Console.WriteLine (res);
      break;
   } else Console.WriteLine ("Enter the string in lowercase.\n");
}
