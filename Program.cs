namespace T28 {
   internal class Program {
      static void Main () {
         TQueue<int> queue = new ();
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Enqueue (4);
         queue.Display ();
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
         queue.Display ();
         queue.Peek ();
      }
   }

   /// <summary>Class TQueue defines the properties and methods of a Queue of T</summary>
   /// <typeparam name="T">T is type of variables declared in the queue</typeparam>
   public class TQueue<T> {
      T[] values = new T[4];
      int count = 0, enCount = 0, deCount = 0;

      /// <summary>Gets the capacity of the queue</summary>
      public int Capacity { get; private set; } = 4;

      /// <summary>Gets the no.of elements on the queue</summary>
      public int Count => count;

      /// <summary>Adds up an element to the queue</summary>
      /// <param name="a">The element to be added</param>
      public void Enqueue (T a) {
         if (count == Capacity) Resize ();
         values[enCount] = a;
         count++;
         enCount = (enCount + 1) % Capacity;
      }

      /// <summary>Removes the first-in element on the queue</summary>
      /// <returns>The removed element</returns>
      public T Dequeue () {
         ExceptionCheck ("Attempting to dequeue an empty queue");
         var a = values[deCount];
         values[deCount] = default!;
         count--;
         deCount = (deCount + 1) % Capacity;
         return a;
      }

      /// <summary>Gets the peek element i.e., the first-in element on the queue</summary>
      /// <returns>The first-in element of the queue</returns>
      public T Peek () {
         ExceptionCheck ("Attempting to peek an empty queue");
         Console.WriteLine (values[deCount]);
         return values[deCount];
      }

      /// <summary>Resizes the array and arranges the elements in the order of first-in to last-in on the resized array</summary>
      void Resize () {
         var temp = new T[Capacity * 2];
         for (int i = 0; i < Capacity; i++) {
            temp[i] = values[enCount];
            enCount = (enCount + 1) % Capacity;
         }
         values = temp;
         Capacity *= 2;
         enCount = count;
         deCount = 0;
      }

      /// <summary>To check whether the queue is empty</summary>
      public bool IsEmpty => count == 0;

      /// <summary>To check if any operation is performed on an empty queue</summary>
      /// <param name="prompt">The string to be dispalyed along with the exception thrown</param>
      /// <exception cref="InvalidOperationException">Throws exception if any operation is performed on an empty queue</exception>
      public void ExceptionCheck (string prompt) {
         if (IsEmpty) throw new InvalidOperationException (prompt);
      }

      /// <summary>To print the elements on queue</summary>
      public void Display () {
         for (int i = 0; i < Capacity; i++) Console.WriteLine ($"{i}-{values[i]}");
      }
   }
}