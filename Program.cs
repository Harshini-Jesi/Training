using System;
namespace numberconversion {
    class Program {
        static string[] ones = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string Cwords (int num) {
            if (num < 0)
                return ("Negative" + Cwords (-num));
            if (num < 20)
                return ones[num];
            if (num < 100)
                return tens[num / 10] + (num % 10 != 0 ? " " + ones[num % 10] : " ");
            if (num < 1000)
                return ones[num / 100] + " hundred" + (num % 100 != 0 ? " and " + Cwords (num % 100) : "");
            if (num < 1000000)
                return Cwords (num / 1000) + " thousand" + (num % 1000 != 0 ? " " + Cwords (num % 1000) : "");
            return "Number out of range";
        }
        static string ConvertToRoman (int num) {
            if (num < 1 || num > 3999) {
                return "Out of Roman numeral range";
            }
            string[] romansym = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string romanNo = "";
            for (int i = 0; i < values.Length; i++) {
                while (num >= values[i]) { romanNo += romansym[i]; num -= values[i]; }
            }
            return romanNo;
        }
        static void Main (string[] args) {
            Console.Write ("Enter a number : ");
            int num = int.Parse (Console.ReadLine ());
            string words = Cwords (num);
            Console.WriteLine ($"Number in words : {words}");
            string roman = ConvertToRoman (num);
            Console.WriteLine ($"Number in romans : {roman}");
        }
    }
}