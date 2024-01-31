var input = File.ReadAllLines ("C:\\Work\\input2.txt");
//string[] numNames = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
foreach (string s in input) {
   //if (numNames.Any (s.Contains)) {
   foreach (char c in s) {
      List<int> numbers = new ();
      if (c is '1' || s.Contains ("one")) numbers.Add (1);
      else if (c is '2' || s.Contains ("two")) numbers.Add (2);
      else if (c is '3' || s.Contains ("three")) numbers.Add (3);
      else if (c is '4' || s.Contains ("four")) numbers.Add (4);
      else if (c is '5' || s.Contains ("five")) numbers.Add (5);
      else if (c is '6' || s.Contains ("six")) numbers.Add (6);
      else if (c is '7' || s.Contains ("seven")) numbers.Add (7);
      else if (c is '8' || s.Contains ("eight")) numbers.Add (8);
      else if (c is '9' || s.Contains ("nine")) numbers.Add (9);
      foreach (int i in numbers) Console.Write (i);
   }
   //}
   Console.WriteLine ("");
}
//foreach (int sl in numbers) Console.Write (sl);
//if (s.Any(char.IsDigit)) 

