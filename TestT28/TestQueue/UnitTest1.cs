using T28;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {
     
      [TestMethod]
      public void TestDequeue () {
         mQueue.Enqueue (1);
         mQueue.Enqueue (2);
         mQueue.Enqueue (3);
         mQueue.Dequeue ();
         Assert.AreEqual (2, mQueue.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         mQueue.Enqueue (1);
         mQueue.Enqueue (2);
         mQueue.Enqueue (3);
         Assert.AreEqual (1,2,3, mQueue.Display ());
      }

      [TestMethod]
      public void TestEnqueue () {
         mQueue.Enqueue (1);
         mQueue.Enqueue (2);
         mQueue.Enqueue (3);
         Assert.AreEqual (3, mQueue.Count);
         Assert.AreEqual (4, mQueue.Capacity);
         mQueue.Enqueue (5);
         mQueue.Enqueue (6);
         Assert.AreEqual (5, mQueue.Count);
         Assert.AreEqual (8, mQueue.Capacity);
      }

      [TestMethod]
      public void TestExceptionCheck () {
         Assert.ThrowsException<InvalidOperationException> (() => mQueue.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => mQueue.Peek ());
      }

      [TestMethod]
      public void TestPeek () {
         mQueue.Enqueue (1);
         mQueue.Enqueue (2);
         mQueue.Enqueue (3);
         Assert.AreEqual (1, mQueue.Peek ());
      }

      [TestMethod]
      public void TestResize () {
         mQueue.Enqueue (1);
         mQueue.Enqueue (2);
         mQueue.Enqueue (3);
         mQueue.Enqueue (4);
         mQueue.Dequeue ();
         mQueue.Dequeue ();
         mQueue.Enqueue (5);
         mQueue.Enqueue (6);
         mQueue.Enqueue (7);
         Assert.AreEqual (5, mQueue.Count);
         Assert.AreEqual (8, mQueue.Capacity);
         Assert.AreEqual (3, mQueue.Peek ());
      }
      TQueue<int> mQueue = new ();
   }
}