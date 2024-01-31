var input = File.ReadAllLines ("C:\\Work\\input2.txt");
List<string> newInput = new ();
foreach (string s in input) {
   if (s.Contains ("one")) newInput.Add (s.Replace ("one", "1"));
   else if (s.Contains ("two")) newInput.Add (s.Replace ("two", "2"));
   else if (s.Contains ("three")) newInput.Add (s.Replace ("three", "3"));
   else if (s.Contains ("four")) newInput.Add (s.Replace ("four", "4"));
   else if (s.Contains ("five")) newInput.Add (s.Replace ("five", "5"));
   else if (s.Contains ("six")) newInput.Add (s.Replace ("six", "6"));
   else if (s.Contains ("seven")) newInput.Add (s.Replace ("seven", "7"));
   else if (s.Contains ("eight")) newInput.Add (s.Replace ("eight", "8"));
   else if (s.Contains ("nine")) newInput.Add (s.Replace ("nine", "9"));
}
foreach (string ns in newInput) {
   List<int> numbers = new ();
   foreach (char c in ns) {
      if (c is '1') numbers.Add (1);
      else if (c is '2') numbers.Add (2);
      else if (c is '3') numbers.Add (3);
      else if (c is '4') numbers.Add (4);
      else if (c is '5') numbers.Add (5);
      else if (c is '6') numbers.Add (6);
      else if (c is '7') numbers.Add (7);
      else if (c is '8') numbers.Add (8);
      else if (c is '9') numbers.Add (9);
   }
   foreach (int i in numbers) Console.Write (i);
   Console.WriteLine ("");
}


