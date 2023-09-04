while (true) {
   Console.Write ("Enter the string in lowercase: ");
   string input = Console.ReadLine ();
   if (!input.All (char.IsLower)) continue;
   Console.WriteLine (input.Distinct ().Count () == input.Length ? "It's an isogram" : "It's not an isogram");
   break;
}
