while (true) {
   Console.Write ("Enter the number : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      int h = n;
      int c = 0;
      while (n > 0) {
         int r = n % 10;
         c = (c * 10) + r;
         n /= 10;
      }
      Console.WriteLine ($"Reversed number : {c}");
      var res = (h == c) ? "It is a palindrome number" : "It is not a palindrome number";
      Console.WriteLine (res); break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'\n");
}
