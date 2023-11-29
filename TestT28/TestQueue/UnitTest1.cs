using T28;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {

      [TestMethod]
      public void TestDequeue () {
         for (int i = 1; i < 5; i++) {
            mNumbers.Enqueue (i);
            mQueue.Enqueue (i);
         }
         mNumbers.Dequeue ();
         mQueue.Dequeue ();
         Assert.AreEqual (mQueue.Count, mNumbers.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         mNumbers.Enqueue (1);
         mNumbers.Enqueue (2);
         mNumbers.Enqueue (3);
         Assert.AreEqual (1, 2, 3, mNumbers.Display ());
      }

      [TestMethod]
      public void TestEnqueue () {
         for (int i = 1; i < 5; i++) {
            mNumbers.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (mQueue.Count, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         mNumbers.Enqueue (5);
         mQueue.Enqueue (5);
         Assert.AreEqual (mQueue.Count, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void TestExceptionCheck () {
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Peek ());
      }

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i < 5; i++) {
            mNumbers.Enqueue (i);
            mQueue.Enqueue (i);
         }
         Assert.AreEqual (mQueue.Peek (), mNumbers.Peek ());
      }

      [TestMethod]
      public void TestResize () {
         for (int i = 1; i < 5; i++) {
            mNumbers.Enqueue (i);
            mQueue.Enqueue (i);
         }
         mNumbers.Dequeue ();
         mQueue.Dequeue ();
         mNumbers.Enqueue (5);
         mNumbers.Enqueue (6);
         mQueue.Enqueue (5);
         mQueue.Enqueue (6);
         Assert.AreEqual (mQueue.Count, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
         Assert.AreEqual (mQueue.Peek (), mNumbers.Peek ());
      }

      TQueue<int> mNumbers = new ();
      Queue<int> mQueue = new ();
   }
}