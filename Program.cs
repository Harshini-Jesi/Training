namespace T26 {
   #region class Program ---------------------------------------------------------------------
   class Program {
      #region Methods ---------------------------------------------
      public static void Main () {
         MyList<int> numbers = new ();
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         numbers.Add (4);
         numbers.Add (5);
         //numbers.Remove (9);
         numbers.Add (6);
         //numbers.Insert (3, 8);
         //numbers.RemoveAt (6);
         //numbers.Clear();
         //numbers[8] = 10;
         numbers.Display ();
      }
      #endregion
   }
   #endregion

   #region class MyList<T> ---------------------------------------------------------------------
   /// <summary>Class MyList defines the properties and methods of a List of T</summary>
   /// <typeparam name="T">T is type of variables declared in the List</typeparam>
   public class MyList<T> {

      #region Constructor -------------------------------------------
      /// <summary>Construct used to assign the values and count</summary>
      public MyList () {
         mValues = new T[4];
         mCount = 0;
      }
      #endregion

      #region Properties --------------------------------------------
      /// <summary>Gets the capacity of the list</summary>
      public int Capacity => mValues.Length;

      /// <summary>Gets the no.of elements in the list</summary>
      public int Count => mCount;

      /// <summary>To get the value in the given index and to set an value to the given index</summary>
      /// <param name="index">The index position to get or set the value</param>
      /// <returns>The value in the given index</returns>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public T this[int index] {
         get {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ("Index out of valid range.");
            return mValues[index];
         }
         set {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ("Index out of valid range.");
            mValues[index] = value;
         }
      }
      #endregion

      #region Methods ---------------------------------------------
      /// <summary>Adds an element to the list and resizes its size if required</summary>
      /// <param name="elem">The element to be added</param>
      public void Add (T elem) {
         if (mCount == Capacity) Array.Resize (ref mValues, mCount * 2);
         mValues[mCount] = elem;
         mCount++;
      }

      /// <summary>Clears all elements from the list</summary>
      public void Clear () {
         Array.Clear (mValues, 0, Count);
         mCount = 0;
      }

      /// <summary>To print the elements on stack</summary>
      public void Display () {
         for (int i = 0; i < Capacity; i++) Console.WriteLine (mValues[i]);
      }

      /// <summary>Inserts an element between two elements in the list</summary>
      /// <param name="index">The index position to which the element is to be inserted</param>
      /// <param name="elem">The element to be inserted</param>
      /// <exception cref="IndexOutOfRangeException">Throws exception when the given index below 0 or above the count</exception>
      public void Insert (int index, T elem) {
         if (index < 0 || index > Count) throw new IndexOutOfRangeException ("Index out of valid range.");
         if (mCount == Capacity) Array.Resize (ref mValues, mCount * 2);
         for (int i = mCount; i > index; i--) mValues[i] = mValues[i - 1];
         mValues[index] = elem;
         mCount++;
      }

      /// <summary>Removes an element from the list</summary>
      /// <param name="elem">The element to be removed</param>
      /// <returns><text>true</text>if the element is removed</returns>
      /// <exception cref="InvalidOperationException">Throws exception when the element is not found in the list</exception>
      public bool Remove (T elem) {
         int index = Array.IndexOf (mValues, elem);
         if (index == -1) throw new InvalidOperationException ("Item not found in the list");
         for (int i = index; i < Count; i++) mValues[i] = mValues[i + 1];
         mCount--;
         return true;
      }

      /// <summary>Removes the element in the given index position</summary>
      /// <param name="index">The index position from which the element is to be removed</param>
      /// <exception cref="IndexOutOfRangeException">Throws exception when the given index below 0 (or) greater than or equal to the count</exception>
      public void RemoveAt (int index) {
         if (index < 0 || index >= Count) throw new IndexOutOfRangeException ("Index out of valid range.");
         var item = mValues[index];
         Remove (item);
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Initialisation of private variables for array and int</summary>
      T[] mValues;
      int mCount;
      #endregion
   }
   #endregion
}
