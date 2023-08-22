using System;
namespace DecimalConversion {
   class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a decimal number : ");
         int decino = int.Parse (Console.ReadLine ());
         string hexadec = DecimalToHexadecimal (decino);
         string binary = DecimalToBinary (decino);
         Console.WriteLine ($"Hexadecimal:{hexadec}");
         Console.WriteLine ($"Binary:{binary}");
      }

      static string DecimalToHexadecimal (int decino) {
         string hex = "";
         while (decino > 0) {
            int rem = decino % 16;
            hex = GetHexDigit (rem) + hex;
            decino /= 16;
         }
         return hex;
      }

      static char GetHexDigit (int value) => (char)(value >= 0 && value <= 9 ? '0' + value : 'A' + (value - 10));
    
      static string DecimalToBinary (int decino) {
         string binary = "";
         while (decino > 0) {
            int rem = decino % 2;
            binary = rem + binary;
            decino /= 2;
         }
         return binary;
      }
   }
}
