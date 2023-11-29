using System.Text;
using static System.Console;

#region class Program -----------------------------------------------------------------------------
class Program {
   #region Methods --------------------------------------------------
   /// <summary>Prints the solutions of eight queens problem</summary>
   static void Main () {
      WriteLine ("Press U to print unique solutions.\nPress any other key to print all solutions.");
      bool iUnique = false;
      if (ReadKey (true).Key == ConsoleKey.U) iUnique = true;
      Clear ();
      PlaceQueen (0, iUnique);
      PrintGrid ();
   }

   /// <summary>Checks if the queen can be placed in that cell</summary>
   /// <param name="row">Row position of the cell to be checked</param>
   /// <param name="column">Column position of the cell to be checked</param>
   /// <returns><text>true</text>if the queen is safe to be placed</returns>
   static bool IsSafe (int row, int column) {
      for (int prevRow = 0; prevRow < row; prevRow++) {
         var prevColumn = sPositions[prevRow];
         if (prevColumn == column || Math.Abs (row - prevRow) == Math.Abs (column - prevColumn)) return false;
      }
      return true;
   }

   /// <summary>Places the queen in the safe cell</summary>
   /// <param name="row">Row position in which the queen is to be placed</param>
   /// <param name="iUnique">Bool function - if true,adds only unique solutions</param>
   static void PlaceQueen (int row, bool iUnique) {
      for (int column = 0; column < 8; column++) {
         if (IsSafe (row, column)) {
            sPositions[row] = column;
            var eachSol = sPositions.ToArray ();
            if (row == 7) {
               if (iUnique) UniqueSoln (eachSol);
               else sSolns.Add (eachSol);
            } else PlaceQueen (row + 1, iUnique);
         }
      }
   }

   /// <summary>Prints the grid of the chessboard</summary>
   static void PrintGrid () {
      OutputEncoding = Encoding.UTF8;
      for (int j = 0; j < sSolns.Count; j++) {
         CursorLeft = CursorTop = 1;
         WriteLine ($"Solution {j + 1} of {sSolns.Count}\n");
         var eachSol = sSolns[j];
         for (int i = 0; i < 8; i++) {
            WriteLine (i == 0 ? $"┌{string.Concat (Enumerable.Repeat ("───┬", 7))}───┐" :
               $"├{string.Concat (Enumerable.Repeat ("───┼", 7))}───┤");
            PrintQueen (eachSol[i]);
         }
         WriteLine ($"└{string.Concat (Enumerable.Repeat ("───┴", 7))}───┘");
         ReadKey (true);
      }
   }

   /// <summary>Prints the queen along with gridlines</summary>
   /// <param name="pos">Position in which queen is to be printed</param>
   static void PrintQueen (int pos) {
      for (int i = 0; i < 8; i++) Write ($"│ {(i == pos ? "♕" : " ")} ");
      WriteLine ("│");
   }

   /// <summary>Adds only the unique solutions to the list</summary>
   /// <param name="sln">The solution array to be checked for uniqueness</param>
   static void UniqueSoln (int[] sln) {
      var temp = sln;
      for (int i = 0; i < 4; i++) {
         // Checks if the rotated array is already present in the solution
         if (IsPresent (temp = Rotate (temp))) return;
         // Checks if the mirrored array is already present in the solution
         if (IsPresent (temp.Reverse ().ToArray ())) return;
      }
      sSolns.Add (sln);

      // Returns the 90 degrees rotated array
      static int[] Rotate (int[] soln) {
         int[] temp = new int[8];
         for (int i = 0; i < 8; i++)
            temp[soln[i]] = 7 - i;
         return temp;
      }

      // Checks if an array is already present in the solutions
      static bool IsPresent (int[] test) => sSolns.Any (a => a.SequenceEqual (test));
   }
   #endregion

   #region Private data ---------------------------------------------
   static int[] sPositions = new int[8];
   static List<int[]> sSolns = new ();
   #endregion
}
#endregion