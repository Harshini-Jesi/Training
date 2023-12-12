class Program {
   /// <summary>Gets a string as input and returns a double</summary>
   static void Main () {
      Console.Write ("Enter a string to be converted to double: ");
      string result = Console.ReadLine ()!.Trim ().ToLower ();
      Console.WriteLine (double.TryParse (result, out double num) ? $"{num}\n" : "double invalid\n");
      // Checks the string that contains 'e'
      if (result.Contains ('e') && !result.StartsWith ('e')) {
         if (SplitLengthCheck (result, 'e', sEArray)) {
            sEArray = result.Split ('e');
            if (IsValid (sEArray[0], '.') && IsValid (sEArray[1])) {
               // Conversion of the string before 'e' i.e., integral part
               if (sEArray[0].StartsWith ('.')) {
                  string fact = sEArray[0].Substring (1);
                  foreach (char c in fact) {
                     sIntegral += (c - '0') * sFactorial;
                     sFactorial *= 0.1;
                  }
               } else if (sEArray[0].StartsWith ('+')) {
                  string plus = sEArray[0].Substring (1);
                  if (plus.Contains ('.') && SplitLengthCheck (plus, '.', sDotArray)) sIntegral = DoubleConvert (plus);
                  else sIntegral = DoubleConvert (plus);
               } else if (sEArray[0].StartsWith ('-')) {
                  string minus = sEArray[0].Substring (1);
                  if (minus.Contains ('.') && SplitLengthCheck (minus, '.', sDotArray)) sIntegral = -1 * DoubleConvert (minus);
                  else sIntegral = -1 * DoubleConvert (minus);
               } else if (sEArray[0].Contains ('.')) {
                  SplitLengthCheck (sEArray[0], '.', sDotArray);
                  sIntegral = DoubleConvert (sEArray[0]);
               } else sIntegral = DoubleConvert (sEArray[0]);
               // Conversion of the string after 'e' i.e., exponential part
               if (sEArray[1].StartsWith ('-')) {
                  string expower = sEArray[1].Substring (1);
                  sPower = -1 * IntConvert (expower);
               } else if (sEArray[1].StartsWith ('+')) {
                  string expower = sEArray[1].Substring (1);
                  sPower = IntConvert (expower);
               } else sPower = IntConvert (sEArray[1]);
               double output = sIntegral * Math.Pow (10, sPower);
               Console.WriteLine (Math.Round (output, 15));
            } else Console.WriteLine ("Invalid entry");
         } else Console.WriteLine ("Invalid entry");
      } else if (result.Contains ('.') && IsValid (result, '.')) Console.WriteLine (result.StartsWith ('.') ? $"0{result}" : result);
      else if (IsValid (result)) Console.WriteLine (result);
      else Console.WriteLine ("Invalid entry");
   }

   /// <summary>To check if the string contains a particular char only once</summary>
   /// <param name="s">The string to be checked</param>
   /// <param name="c">The char to be checked</param>
   /// <param name="arr">Array that contains the strings splitted w.r.to the char</param>
   /// <returns><text>true</text>if the length of the array is not more than 2</returns>
   static bool SplitLengthCheck (string s, char c, string[] arr) {
      arr = s.Split (c);
      if (arr.Length > 2) return false;
      return true;
   }

   /// <summary>To check if the given string is valid to be converted to double</summary>
   /// <param name="s">The string to be checked</param>
   /// <param name="dot">The optional parameter to check if the string with dot is valid</param>
   /// <returns><text>false</text>if the given string is not valid</returns>
   static bool IsValid (string s, char dot = ' ') {
      if (char.IsDigit (s[0]) || s.StartsWith ('+') || s.StartsWith ('-') || s.StartsWith (dot)) {
         if ((s.StartsWith ('+') || s.StartsWith ('-') || s.StartsWith (dot)) && s == s[0].ToString ()) return false;
         string s1 = s.Substring (1);
         if (s1.All (char.IsDigit)) return true;
         else if (s1.Contains (dot) && SplitLengthCheck (s1, '.', sDotArray)) {
            string s2 = s1.Replace (".", "");
            if (s2.All (char.IsDigit)) return true;
         } else return false;
      }
      return false;
   }

   /// <summary>To convert the string to int</summary>
   /// <param name="s">The string to be converted</param>
   /// <returns>The converted int</returns>
   static int IntConvert (string s) {
      foreach (char c in s) sPower = (sPower * 10) + (c - '0');
      return sPower;
   }

   /// <summary>To convert the string to double</summary>
   /// <param name="s">The string to be converted</param>
   /// <returns>The converted double</returns>
   static double DoubleConvert (string s) {
      if (s.Contains ('.')) {
         sDotArray = s.Split ('.');
         if (IsValid (sDotArray[0]) && sDotArray[1].All (char.IsDigit)) {
            foreach (char c in sDotArray[0]) sIntegral = (sIntegral * 10) + (c - '0');
            foreach (char c in sDotArray[1]) {
               sIntegral += (c - '0') * sFactorial;
               sFactorial *= 0.1;
            }
         }
      } else foreach (char c in s) sIntegral = (sIntegral * 10) + (c - '0');
      return sIntegral;
   }

   static string[] sEArray = { }, sDotArray = { };
   static double sIntegral = 0, sFactorial = 0.1;
   static int sPower = 0;
}
