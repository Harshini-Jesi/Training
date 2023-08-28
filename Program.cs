﻿using System;
namespace NumberConversion {
   class Program {
      static string[] ones = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

      static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

      static string ConvertToWords (int num) {
         int rem10 = num % 10, rem100 = num % 100, rem1000 = num % 1000;
         if (num < 0) return ("Negative " + ConvertToWords (-num));
         if (num < 20) return ones[num];
         if (num < 100) return tens[num / 10] + (rem10 != 0 ? " " + ones[rem10] : " ");
         if (num < 1000) return ones[num / 100] + " hundred" + (rem100 != 0 ? " and " + ConvertToWords (rem100) : "");
         if (num < 1000000) return ConvertToWords (num / 1000) + " thousand" + (rem1000 != 0 ? " " + ConvertToWords (rem1000) : "");
         return "Number out of range";
      }

      static string ConvertToRoman (int num) {
         if (num < 1 || num > 3999) return "Out of Roman numeral range";
         string[] romanSym = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
         int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
         string romanNo = "";
         for (int i = 0; i < values.Length; i++) {
            while (num >= values[i]) { romanNo += romanSym[i]; num -= values[i]; }
         }
         return romanNo;
      }

      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter a number : ");
            if (int.TryParse (Console.ReadLine (), out int num)) {
               string words = ConvertToWords (num);
               Console.WriteLine ($"Number in words : {words}");
               string roman = ConvertToRoman (num);
               Console.WriteLine ($"Number in romans : {roman}");
               break;
            } else Console.WriteLine ("Invalid input. Please enter a valid 'NUMBER'.\n");
         }
      }
   }
}