while (true) {
   Console.Write ("Enter the number : ");
   if (int.TryParse (Console.ReadLine (), out int n)) {
      int original = n, reverse = 0;
      while (n > 0) {
         int rem = n % 10;
         reverse = (reverse * 10) + rem;
         n /= 10;
      }
      Console.WriteLine ($"Reversed number : {reverse}");
      var res = (original == reverse) ? "It is a palindrome number." : "It is not a palindrome number.";
      Console.WriteLine (res); break;
   } else Console.WriteLine ("Invalid input. Please enter a 'NUMBER'.\n");
}
