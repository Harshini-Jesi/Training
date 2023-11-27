namespace T28 {
   #region class Program ---------------------------------------------------------------------
   class Program {
      #region Methods ---------------------------------------------
      static void Main () {
         TQueue<int> queue = new ();
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Enqueue (4);
         Console.WriteLine(queue.Display ());
         queue.Peek ();
         queue.Dequeue ();
         queue.Dequeue ();
         //queue.Dequeue ();
         //queue.Dequeue ();
         //queue.Dequeue ();
         //queue.Peek ();
         queue.Enqueue (5);
         queue.Enqueue (6);
         queue.Enqueue (7);
         Console.WriteLine (queue.Display ());
         queue.Peek ();
      }
      #endregion
   }
   #endregion

   #region class TQueue<T> ---------------------------------------------------------------------
   /// <summary>Class TQueue defines the properties and methods of a Queue of T</summary>
   /// <typeparam name="T">T is type of variables declared in the queue</typeparam>
   public class TQueue<T> {
      
      #region Properties --------------------------------------------
      /// <summary>Gets the capacity of the queue</summary>
      public int Capacity => mValues.Length;

      /// <summary>Gets the no.of elements on the queue</summary>
      public int Count => mCount;

      /// <summary>To check whether the queue is empty</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Implementation ----------------------------------------
      /// <summary>Removes the first-in element on the queue</summary>
      /// <returns>The removed element</returns>
      public T Dequeue () {
         ExceptionCheck ("Attempting to dequeue an empty queue");
         var a = mValues[mDeCount];
         mValues[mDeCount] = default!;
         mCount--;
         mDeCount = (mDeCount + 1) % Capacity;
         return a;
      }

      /// <summary>To print the elements on queue</summary>
      public string Display () => string.Join (',', mValues);

      /// <summary>Adds up an element to the queue</summary>
      /// <param name="elem">The element to be added</param>
      public void Enqueue (T elem) {
         if (mCount == Capacity) Resize ();
         mValues[mEnCount] = elem;
         mCount++;
         mEnCount = (mEnCount + 1) % Capacity;
      }

      /// <summary>To check if any operation is performed on an empty queue</summary>
      /// <param name="prompt">The string to be dispalyed along with the exception thrown</param>
      /// <exception cref="InvalidOperationException">Throws exception if any operation is performed on an empty queue</exception>
      public void ExceptionCheck (string prompt) {
         if (IsEmpty) throw new InvalidOperationException (prompt);
      }

      /// <summary>Gets the peek element i.e., the first-in element on the queue</summary>
      /// <returns>The first-in element of the queue</returns>
      public T Peek () {
         ExceptionCheck ("Attempting to peek an empty queue");
         Console.WriteLine (mValues[mDeCount]);
         return mValues[mDeCount];
      }

      /// <summary>Resizes the array and arranges the elements in the order of first-in to last-in on the resized array</summary>
      void Resize () {
         var temp = new T[Capacity * 2];
         for (int i = 0; i < Capacity; i++) {
            temp[i] = mValues[mEnCount];
            mEnCount = (mEnCount + 1) % Capacity;
         }
         mValues = temp;
         mEnCount = mCount;
         mDeCount = 0;
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Declaration of private variables</summary>
      T[] mValues = new T[4];
      int mCount = 0, mEnCount = 0, mDeCount = 0;
      #endregion
   }
   #endregion
}