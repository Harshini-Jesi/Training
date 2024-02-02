namespace A10_2 {
   #region class Program --------------------------------------------------------------------------
   class Program {
      #region Methods -----------------------------------------------
      static void Main () {
         TDeque<int> deque = new ();
         deque.EnqueueFront (2);
         deque.EnqueueFront (3);
         Console.WriteLine (deque.Display ());
         deque.PeekFront ();
         deque.DequeueFront ();
         deque.EnqueueRear (7);
         deque.EnqueueRear (8);
         Console.WriteLine (deque.Display ());
         deque.PeekRear ();
         deque.DequeueRear ();
         Console.WriteLine (deque.Display ());
      }
      #endregion
   }
   #endregion

   #region class TDeque<T> ------------------------------------------------------------------------
   /// <summary>Class TDeque defines the properties and methods of a Double ended queue of T</summary>
   /// <typeparam name="T">T is the type of variable declared in the deque</typeparam>
   public class TDeque<T> {

      #region Properties --------------------------------------------
      /// <summary>Gets the capacity of the deque</summary>
      public int Capacity => mValues.Length;

      /// <summary>Gets the no.of elements on the deque</summary>
      public int Count => mCount;

      /// <summary>To check whether the deque is empty</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      //Note: Front (right side), Rear (left side) of the deque.
      /// <summary>Removes an element from the front of the deque</summary>
      /// <returns>The removed element</returns>
      public T DequeueFront () {
         ExceptionCheck ("Attempting to dequeue an empty deque");
         var dqElem = mValues[mFront];
         mValues[mFront] = default!;
         mCount--;
         mFront = (mFront + 1) % Capacity;
         return dqElem;
      }

      /// <summary>Removes an element from the rear of the deque</summary>
      /// <returns>The removed element</returns>
      public T DequeueRear () {
         ExceptionCheck ("Attempting to dequeue an empty deque");
         mRear = (mRear + Capacity - 1) % Capacity;
         var dqElem = mValues[mRear];
         mValues[mRear] = default!;
         mCount--;
         return dqElem;
      }

      /// <summary>To print the elements on deque</summary>
      public string Display () => string.Join (',', mValues);

      /// <summary>Adds up an element at the front of the deque</summary>
      /// <param name="elem">The element to be added</param>
      public void EnqueueFront (T elem) {
         if (mCount == Capacity) Resize ();
         mFront = (mFront + Capacity - 1) % Capacity;
         mValues[mFront] = elem;
         mCount++;
      }

      /// <summary>Adds up an element at the rear of the deque</summary>
      /// <param name="elem">The element to be added</param>
      public void EnqueueRear (T elem) {
         if (mCount == Capacity) Resize ();
         mValues[mRear] = elem;
         mCount++;
         mRear = (mRear + 1) % Capacity;
      }

      /// <summary>To check if any operation is performed on an empty deque</summary>
      /// <param name="prompt">The string to be dispalyed along with the exception thrown</param>
      /// <exception cref="InvalidOperationException">Throws exception if any operation is performed on an empty deque</exception>
      public void ExceptionCheck (string prompt) {
         if (IsEmpty) throw new InvalidOperationException (prompt);
      }

      /// <summary>Gets the peek element from the front of the deque</summary>
      /// <returns>The peek element</returns>
      public T PeekFront () {
         ExceptionCheck ("Attempting to peek an empty deque");
         Console.WriteLine (mValues[mFront]);
         return mValues[mFront];
      }

      /// <summary>Gets the peek element from the rear of the deque</summary>
      /// <returns>The peek element</returns>
      public T PeekRear () {
         ExceptionCheck ("Attempting to peek an empty deque");
         int rear = (mRear + Capacity - 1) % Capacity;
         Console.WriteLine (mValues[rear]);
         return mValues[rear];
      }
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Resizes the array to double times its capacity</summary>
      void Resize () {
         T[] newValues = new T[Capacity * 2];
         for (int i = 0; i < mCount; i++) newValues[i] = mValues[i];
         (mValues, mRear, mFront) = (newValues, mCount, 0);
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Declaration of private variables</summary>
      T[] mValues = new T[4];
      int mCount = 0, mRear = 0, mFront = 0;
      #endregion
   }
   #endregion
}