using System;
using System.Linq;
using System.Text;
namespace ChessBoard {
   class Program {
      static void Main (string[] args) {
         Console.OutputEncoding = new UnicodeEncoding ();
         Console.WriteLine ("\u250c" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u252c", 7)) + "\u2500\u2500\u2500\u2510");
         Console.WriteLine ("\u2502 \u265c \u2502 \u265e \u2502 \u265d \u2502 \u265b \u2502 \u265a \u2502 \u265d \u2502 \u265e \u2502 \u265c \u2502");
         Console.WriteLine ("\u251c" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u253c", 7)) + "\u2500\u2500\u2500\u2524");
         Console.WriteLine ("\u2502" + string.Concat (Enumerable.Repeat (" \u265f \u2502", 8)));
         for (int i = 0; i < 4; i++) {
            Console.WriteLine ("\u251c" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u253c", 7)) + "\u2500\u2500\u2500\u2524");
            Console.WriteLine (string.Concat (Enumerable.Repeat ("\u2502   ", 9)));
         }
         Console.WriteLine ("\u251c" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u253c", 7)) + "\u2500\u2500\u2500\u2524");
         Console.WriteLine ("\u2502" + string.Concat (Enumerable.Repeat (" \u2659 \u2502", 8)));
         Console.WriteLine ("\u251c" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u253c", 7)) + "\u2500\u2500\u2500\u2524");
         Console.WriteLine ("\u2502 \u2656 \u2502 \u2658 \u2502 \u2657 \u2502 \u2655 \u2502 \u2654 \u2502 \u2657 \u2502 \u2658 \u2502 \u2656 \u2502");
         Console.WriteLine ("\u2514" + string.Concat (Enumerable.Repeat ("\u2500\u2500\u2500\u2534", 7)) + "\u2500\u2500\u2500\u2518");
      }
   }
}