namespace T27 {
   class Program {
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
         num.Display ();
         while (num.Count! > 0) {
            Console.WriteLine ($"popped num {num.Pop ()}");
         }
         num.Display ();
         //num.Pop ();
         Console.WriteLine (num.Count);
      }
   }

   /// <summary>Class TStack defines the properties and methods of a Stack of T</summary>
   /// <typeparam name="T">T is type of variables declared in the stack</typeparam>
   public class TStack<T> {
      T[] values = new T[4];
      int count = 0;

      /// <summary>Gets the capacity of the stack</summary>
      public int Capacity => values.Length;

      /// <summary>Gets the no.of elements on the stack</summary>
      public int Count => count;

      /// <summary>Adds up an element to the stack</summary>
      /// <param name="a">The element to be added</param>
      public void Push (T a) {
         if (count == Capacity) Array.Resize (ref values, count * 2);
         values[count] = a;
         count++;
      }

      /// <summary>Removes the last-in element on the stack</summary>
      /// <returns>The removed element</returns>
      /// <exception cref="InvalidOperationException">Throws exception if Pop() is performed on an empty stack</exception>
      public T Pop () {
         if (IsEmpty) throw new InvalidOperationException ("Attempting to pop an empty stack.");
         var a = values[count - 1];
         values[count - 1] = default;
         count--;
         return a;
      }

      /// <summary>To print the elements on stack</summary>
      public void Display () {
         for (int i = 0; i < Capacity; i++) Console.WriteLine (values[i]);
      }

      /// <summary>Gets the peek element i.e., the last-in element on the stack</summary>
      /// <returns>The last-in element of the stack</returns>
      /// <exception cref="InvalidOperationException">Throws exception if Peek() is performed on an empty stack</exception>
      public T Peek () {
         if (IsEmpty) throw new InvalidOperationException ("Attempting to peek an empty stack.");
         Console.WriteLine (values[count - 1]);
         return values[count - 1];
      }

      /// <summary>To check whether the stack is empty</summary>
      public bool IsEmpty => count == 0;
   }
}