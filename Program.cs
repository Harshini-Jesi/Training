namespace A07 {
   /// <summary>Program to implement double.Parse method that takes a string and returns a double</summary>
   class Program {
      /// <summary>Gets a string as input and returns a double</summary>
      static void Main () {
         Console.Write ("Enter a string to be converted to double: ");
         string result = Console.ReadLine ()!.Trim ().ToLower ();
         Console.WriteLine (double.TryParse (result, out double num) ? $"{num}\n" : "double invalid\n");
         Console.WriteLine (DoubleParse.TryParses (result, out double output) ? $"{output}" : "Invalid entry");
      }
   }

   /// <summary>Class to implement double.Parse method that takes a string and returns a double</summary>
   public class DoubleParse {
      /// <summary>Converts a string to double</summary>
      /// <param name="result">String to be converted</param>
      /// <param name="output">The double converted from string</param>
      /// <returns><text>true</text>if the string can be converted to double</returns>
      public static bool TryParses (string result, out double output) {
         string[] eArray = { }, dotArray = { };
         double integral; int exponential;
         // Checks the string that contains 'e'
         if (result.Contains ('e')) {
            if (SplitLengthCheck (result, 'e')) {
               eArray = result.Split ('e');
               if (IsValid (eArray[0], '.') && IsValid (eArray[1])) {
                  // Conversion of the string before 'e' i.e., integral part
                  if (eArray[0].StartsWith ('.') || eArray[0].StartsWith ('+') || eArray[0].StartsWith ('-')) {
                     integral = StartCheck (eArray[0]);
                  } else integral = DoubleConvert (eArray[0]);
                  // Conversion of the string after 'e' i.e., exponential part
                  if (eArray[1].StartsWith ('-')) {
                     string expower = eArray[1].Substring (1);
                     exponential = -1 * IntConvert (expower);
                  } else if (eArray[1].StartsWith ('+')) {
                     string expower = eArray[1].Substring (1);
                     exponential = IntConvert (expower);
                  } else exponential = IntConvert (eArray[1]);
                  output = integral * Math.Pow (10, exponential);
                  return true;
               } else { output = double.NaN; return false; }
            } else { output = double.NaN; return false; }
         } else if (IsValid (result, '.') || IsValid (result)) {
            if (result.StartsWith ('.') || result.StartsWith ('+') || result.StartsWith ('-')) {
               output = StartCheck (result);
               return true;
            } else {
               output = DoubleConvert (result);
               return true;
            }
         } else { output = double.NaN; return false; }
      }

      /// <summary>To check if the string contains a particular char only once</summary>
      /// <param name="s">The string to be checked</param>
      /// <param name="c">The char to be checked</param>
      /// <returns><text>true</text>if the length of the array is not more than 2</returns>
      static bool SplitLengthCheck (string s, char c) => s.Split (c).Length <= 2;

      /// <summary>To check if the given string is valid to be converted to double</summary>
      /// <param name="s">The string to be checked</param>
      /// <param name="dot">The optional parameter to check if the string with dot is valid</param>
      /// <returns><text>false</text>if the given string is not valid</returns>
      static bool IsValid (string s, char dot = ' ') {
         if (string.IsNullOrEmpty (s) || s.StartsWith ('e')) return false;
         else if ((s.StartsWith ('+') || s.StartsWith ('-') || s.StartsWith (dot)) && s != s[0].ToString ()) {
            string s1 = s.Substring (1);
            if (s1.All (char.IsDigit)) return true;
            else if (s.Contains (dot) && DotCheck (s1)) return true;
            else return false;
         } else if (s.All (char.IsDigit)) return true;
         else if (s.Contains (dot) && DotCheck (s)) return true;
         return false;
      }

      /// <summary>To convert the string to int</summary>
      /// <param name="s">The string to be converted</param>
      /// <returns>The converted int</returns>
      static int IntConvert (string s) {
         int power = 0;
         foreach (char c in s) power = (power * 10) + (c - '0');
         return power;
      }

      /// <summary>To convert the string to double</summary>
      /// <param name="s">The string to be converted</param>
      /// <returns>The converted double</returns>
      static double DoubleConvert (string s) {
         double numDouble = 0, factorial = 0.1;
         if (DotCheck (s)) {
            string[] dotArr = s.Split ('.');
            foreach (char c in dotArr[0]) numDouble = (numDouble * 10) + (c - '0');
            foreach (char c in dotArr[1]) {
               numDouble += (c - '0') * factorial;
               factorial *= 0.1;
            }
         } else foreach (char c in s) numDouble = char.IsDigit (c) ? (numDouble * 10) + (c - '0') : double.NaN;
         return numDouble;
      }

      /// <summary>To convert the string starting with '+','-','.' to double</summary>
      /// <param name="s">The string to be converted</param>
      /// <returns>The converted double</returns>
      static double StartCheck (string s) {
         double intDouble = 0, deci = 0.1;
         string num = s.Substring (1);
         if (s.StartsWith ('.')) {
            foreach (char c in num) {
               intDouble += (c - '0') * deci;
               deci *= 0.1;
            }
         } else if (DotCheck (num) || num.All (char.IsDigit)) {
            if (s.StartsWith ('+')) intDouble = DoubleConvert (num);
            else if (s.StartsWith ('-')) intDouble = -1 * DoubleConvert (num);
         } else intDouble = double.NaN;
         return intDouble;
      }

      /// <summary>To check if a given string has only one '.' and digits</summary>
      /// <param name="s">The string to be checked</param>
      /// <returns><text>true</text>if the string has only one '.' and digits</returns>
      static bool DotCheck (string s) {
         if (s.Contains ('.')) {
            if (SplitLengthCheck (s, '.')) {
               string s2 = s.Replace (".", "");
               if (s2.All (char.IsDigit)) return true;
            } else return false;
         } else return false;
         return false;
      }
   }
}
