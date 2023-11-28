using System.Text;
using static System.Console;

#region Program ------------------------------------------------------------------------------
class Program {
   #region Methods ---------------------------------------------
   /// <summary>Prints the solutions of eight queens problem</summary>
   static void Main () {
      WriteLine ("Enter U to print unique solutions.\nEnter anyother key to print all solutions.");
      bool isUnique = false;
      if (ReadKey (true).Key == ConsoleKey.U) isUnique = true;
      Clear ();
      PlaceQueen (0, isUnique);
      PrintGrid ();
   }

   /// <summary>Checks if the queen can be placed in that cell</summary>
   /// <param name="row">Row position of the cell to be checked</param>
   /// <param name="column">Column position of the cell to be checked</param>
   /// <returns><text>true</text>if the queen is safe to be placed</returns>
   static bool IsSafe (int row, int column) {
      for (int prevRow = 0; prevRow < row; prevRow++) {
         var prevColumn = mPositions[prevRow];
         if (prevColumn == column || Math.Abs (row - prevRow) == Math.Abs (column - prevColumn)) return false;
      }
      return true;
   }

   /// <summary>Places the queen in the safe cell</summary>
   /// <param name="row">Row position in which the queen is to be placed</param>
   /// <param name="isUnique">Bool function - if true,adds only unique solutions</param>
   static void PlaceQueen (int row, bool isUnique) {
      for (int column = 0; column < 8; column++) {
         if (IsSafe (row, column)) {
            mPositions[row] = column;
            var eachSol = mPositions.ToArray ();
            if (row == 7) {
               if (isUnique) UniqueSoln (eachSol);
               else mSolns.Add (eachSol);
            } else PlaceQueen (row + 1, isUnique);
         }
      }
   }

   /// <summary>Prints the grid of the chessboard</summary>
   static void PrintGrid () {
      OutputEncoding = Encoding.UTF8;
      for (int j = 0; j < mSolns.Count; j++) {
         CursorLeft = CursorTop = 1;
         WriteLine ($"Solution {j + 1} of {mSolns.Count}\n");
         var eachSol = mSolns[j];
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
      mSolns.Add (sln);

      // Returns the 90 degrees rotated array
      static int[] Rotate (int[] soln) {
         int[] temp = new int[8];
         for (int i = 0; i < 8; i++)
            temp[soln[i]] = 7 - i;
         return temp;
      }

      // Checks if an array is already present in the solutions
      static bool IsPresent (int[] test) => mSolns.Any (a => a.SequenceEqual (test));
   }
   #endregion

   #region Private -----------------------------------------------
   static int[] mPositions = new int[8];
   static List<int[]> mSolns = new ();
   #endregion
}
#endregion