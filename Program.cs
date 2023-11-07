namespace T26 {
   class Program {
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
         for (int i = 0; i < numbers.Capacity; i++)
            Console.WriteLine (numbers[i]);
      }
   }

   /// <summary>Class MyList defines the properties and methods of a List of T</summary>
   /// <typeparam name="T">T is type of variables declared in the List</typeparam>
   public class MyList<T> {

      /// <summary>Construct used to assign the values and count</summary>
      public MyList () {
         values = new T[4];
         count = 0;
      }

      /// <summary>Gets the no.of elements in the list</summary>
      public int Count => count;

      /// <summary>Gets the capacity of the list</summary>
      public int Capacity => values.Length;

      /// <summary>To get the value in the given index and to set an value to the given index</summary>
      /// <param name="index">The index position to get or set the value</param>
      /// <returns>The value in the given index</returns>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public T this[int index] {
         get {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ("Index out of valid range.");
            return values[index];
         }
         set {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ("Index out of valid range.");
            values[index] = value;
         }
      }

      /// <summary>Adds an element to the list and resizes its size if required</summary>
      /// <param name="a">The element to be added</param>
      public void Add (T a) {
         if (count == Capacity) Array.Resize (ref values, count * 2);
         values[count] = a;
         count++;
      }

      /// <summary>Removes an element from the list</summary>
      /// <param name="a">The element to be removed</param>
      /// <returns><text>true</text>if the element is removed</returns>
      /// <exception cref="InvalidOperationException">Throws exception when the element is not found in the list</exception>
      public bool Remove (T a) {
         int index = Array.IndexOf (values, a);
         if (!values.Contains (a)) throw new InvalidOperationException ("Item not found in the list");
         values[index] = default;
         for (int i = index; i < Count; i++) values[i] = values[i + 1];
         count--;
         return true;
      }

      /// <summary>Clears all elements from the list</summary>
      public void Clear () {
         Array.Clear (values, 0, Count);
         count = 0;
      }

      /// <summary>Inserts an element between two elements in the list</summary>
      /// <param name="index">The index position to which the element is to be inserted</param>
      /// <param name="a">The element to be inserted</param>
      /// <exception cref="IndexOutOfRangeException">Throws exception when the given index below 0 or above the count</exception>
      public void Insert (int index, T a) {
         if (index < 0 || index > Count) throw new IndexOutOfRangeException ("Index out of valid range.");
         if (count == Capacity) Array.Resize (ref values, count * 2);
         for (int i = count; i > index; i--) values[i] = values[i - 1];
         values[index] = a;
         count++;
      }

      /// <summary>Removes the element in the given index position</summary>
      /// <param name="index">The index position from which the element is to be removed</param>
      /// <exception cref="IndexOutOfRangeException">Throws exception when the given index below 0 (or) greater than or equal to the count</exception>
      public void RemoveAt (int index) {
         if (index < 0 || index >= Count) throw new IndexOutOfRangeException ("Index out of valid range.");
         var item = values[index];
         Remove (item);
      }
      T[] values;
      int count;
   }
}
