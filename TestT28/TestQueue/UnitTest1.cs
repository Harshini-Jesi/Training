using System;
using T28;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> queue = new ();

      [TestMethod]
      public void TestEnqueue () {
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         Assert.AreEqual (3, queue.Count);
         Assert.AreEqual (4, queue.Capacity);
         queue.Enqueue (5);
         queue.Enqueue (6);
         Assert.AreEqual (5, queue.Count);
         Assert.AreEqual (8, queue.Capacity);
      }

      [TestMethod]
      public void TestDequeue () {
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Dequeue ();
         Assert.AreEqual (2, queue.Count);
      }

      [TestMethod]
      public void TestPeek () {
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         Assert.AreEqual (1, queue.Peek ());
      }

      [TestMethod]
      public void TestResize () {
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Enqueue (4);
         queue.Dequeue ();
         queue.Dequeue ();
         queue.Enqueue (5);
         queue.Enqueue (6);
         queue.Enqueue (7);
         Assert.AreEqual (5, queue.Count);
         Assert.AreEqual (8, queue.Capacity);
         Assert.AreEqual (3, queue.Peek ());
      }

      [TestMethod]
      public void TestExceptionCheck () {
         Assert.ThrowsException<InvalidOperationException> (() => queue.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => queue.Peek ());
      }

      [TestMethod]
      public void TestDisplay () {
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Display ();
      }
   }
}