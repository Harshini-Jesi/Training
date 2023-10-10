﻿/// <summary>This program gets the given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange,
/// and returns the maximum number of chocolates C you can get along with any unused money X and wrappers W. </summary>
/// <example>Input: X=10, P=1, W=2 ; Output: C=19, X=0, W=1.
/// Input: X=20, P=3, W=2 ; Output: C=11, X=2, W=1.
/// Input: X=45, P=2, W=3 ; Output: C=32, X=1, W=2.</example>
class Program {
   static void Main () {
      Console.WriteLine ("Enter the given money 'X', price of a chocolate 'P' and wrappers required for chocolate in exchange 'W'." +
         "\nNote: All the values entered must be natural numbers and W must be greater than 1.");
      int money = GetInput ("X = "), price = GetInput ("P = "), min = 1, wrappers = GetInput ("W = ", min);
      int chocolates = money / price, unusedMoney = money % price, unusedWrapper = chocolates;
      while (unusedWrapper >= wrappers) {
         int exchange = unusedWrapper / wrappers;
         chocolates += exchange;
         unusedWrapper = exchange + (unusedWrapper % wrappers);
      }
      Console.WriteLine ($"\nC = {chocolates}, X = {unusedMoney}, W = {unusedWrapper}" +
         $"\nwhere, C is the Maximum no.of chocolates, X is the unused money and W is the unused wrappers.");
   }

   /// <summary>To get input values from the user at a particular range</summary>
   /// <param name="prompt">Displays the prompt for the user to enter the input</param>
   /// <param name="min">if set to -1 no range check is done, otherwise checks if value is greater than min</param>
   /// <returns>The input value i.e.,the integer from the user</returns>
   static int GetInput (string prompt, int min = -1) {
      while (true) {
         Console.Write (prompt);
         if (!int.TryParse (Console.ReadLine (), out int value) || value < 1) continue;
         if (min == -1 || value > min) return value;
      }
   }
}