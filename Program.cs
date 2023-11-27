namespace T27 {
   #region class Program ---------------------------------------------------------------------
   class Program {
      #region Methods ---------------------------------------------
      static void Main () {
         TStack<int> num = new ();
         num.Push (1);
         num.Push (2);
         num.Push (3);
         num.Push (4);
         num.Push (5);
         num.Push (6);
         num.Push (7);
         num.Push (8);
         //num.Push (9);
         num.Peek ();
         Console.WriteLine (num.Display ());
         while (num.Count! > 0) {
            Console.WriteLine ($"popped num {num.Pop ()}");
         }
         Console.WriteLine (num.Display ());
         //num.Pop ();
         Console.WriteLine (num.Count);
      }
      #endregion
   }
   #endregion

   #region class TStack<T> ---------------------------------------------------------------------
   /// <summary>Class TStack defines the properties and methods of a Stack of T</summary>
   /// <typeparam name="T">T is type of variables declared in the stack</typeparam>
   public class TStack<T> {

      #region Properties --------------------------------------------
      /// <summary>Gets the capacity of the stack</summary>
      public int Capacity => mValues.Length;

      /// <summary>Gets the no.of elements on the stack</summary>
      public int Count => mCount;

      /// <summary>To check whether the stack is empty</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Implementation ----------------------------------------

      /// <summary>To print the elements on stack</summary>
      public string Display () => string.Join (',', mValues);

      /// <summary>Gets the peek element i.e., the last-in element on the stack</summary>
      /// <returns>The last-in element of the stack</returns>
      /// <exception cref="InvalidOperationException">Throws exception if Peek() is performed on an empty stack</exception>
      public T Peek () {
         if (IsEmpty) throw new InvalidOperationException ("Attempting to peek an empty stack.");
         Console.WriteLine (mValues[mCount - 1]);
         return mValues[mCount - 1];
      }

      /// <summary>Removes the last-in element on the stack</summary>
      /// <returns>The removed element</returns>
      /// <exception cref="InvalidOperationException">Throws exception if Pop() is performed on an empty stack</exception>
      public T Pop () {
         if (IsEmpty) throw new InvalidOperationException ("Attempting to pop an empty stack.");
         var a = mValues[mCount - 1];
         mValues[mCount - 1] = default;
         mCount--;
         return a;
      }

      /// <summary>Adds up an element to the stack</summary>
      /// <param name="elem">The element to be added</param>
      public void Push (T elem) {
         if (mCount == Capacity) Array.Resize (ref mValues, mCount * 2);
         mValues[mCount] = elem;
         mCount++;
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Declaration of private variables for array and int</summary>
      T[] mValues = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion
}