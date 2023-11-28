using T28;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {

      [TestMethod]
      public void TestDequeue () {
         for (int i = 1; i < 5; i++) {
            mNumb.Enqueue (i);
            mQueue.Enqueue (i);
         }
         mNumb.Dequeue ();
         mQueue.Dequeue ();
         Assert.AreEqual (mQueue.Count, mNumb.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         mNumb.Enqueue (1);
         mNumb.Enqueue (2);
         mNumb.Enqueue (3);
         Assert.AreEqual (1, 2, 3, mNumb.Display ());
      }

      [TestMethod]
      public void TestEnqueue () {
         for (int i = 1; i < 5; i++) {
            mNumb.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (mQueue.Count, mNumb.Count);
         Assert.AreEqual (4, mNumb.Capacity);
         mNumb.Enqueue (5);
         mQueue.Enqueue (5);
         Assert.AreEqual (mQueue.Count, mNumb.Count);
         Assert.AreEqual (8, mNumb.Capacity);
      }

      [TestMethod]
      public void TestExceptionCheck () {
         Assert.ThrowsException<InvalidOperationException> (() => mNumb.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumb.Peek ());
      }

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i < 5; i++) {
            mNumb.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (mQueue.Peek (), mNumb.Peek ());
      }

      [TestMethod]
      public void TestResize () {
         for (int i = 1; i < 5; i++) {
            mNumb.Enqueue (i);
            mQueue.Enqueue (i);
         }
         mNumb.Dequeue ();
         mQueue.Dequeue ();
         mNumb.Enqueue (5);
         mNumb.Enqueue (6);
         mQueue.Enqueue (5);
         mQueue.Enqueue (6);
         Assert.AreEqual (mQueue.Count, mNumb.Count);
         Assert.AreEqual (8, mNumb.Capacity);
         Assert.AreEqual (mQueue.Peek (), mNumb.Peek ());
      }

      TQueue<int> mNumb = new ();
      Queue<int> mQueue = new ();
   }
}