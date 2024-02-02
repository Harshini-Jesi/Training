using A10_2;

namespace TestA10._2 {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void TestDequeueFront () {
         mNumbers.EnqueueFront (2);
         mNumbers.EnqueueFront (3);
         mNumbers.EnqueueFront (4);
         Assert.AreEqual (3, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.DequeueFront ());
         Assert.AreEqual (3, mNumbers.DequeueFront ());
         Assert.AreEqual (1, mNumbers.Count);
      }

      [TestMethod]
      public void TestDequeueRear () {
         mNumbers.EnqueueRear (1);
         mNumbers.EnqueueRear (2);
         mNumbers.EnqueueRear (3);
         Assert.AreEqual (3, mNumbers.Count);
         Assert.AreEqual (3, mNumbers.DequeueRear ());
         Assert.AreEqual (2, mNumbers.DequeueRear ());
         Assert.AreEqual (1, mNumbers.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         mNumbers.EnqueueFront (1);
         mNumbers.EnqueueFront (2);
         mNumbers.EnqueueFront (3);
         Assert.AreEqual ("0,3,2,1", mNumbers.Display ());
      }

      [TestMethod]
      public void TestEnqueueFront () {
         for (int i = 1; i < 5; i++) mNumbers.EnqueueFront (i);
         Assert.AreEqual ("4,3,2,1", mNumbers.Display ());
         Assert.AreEqual (4, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         mNumbers.EnqueueFront (5);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void TestEnqueueRear () {
         for (int i = 1; i < 5; i++) mNumbers.EnqueueRear (i);
         Assert.AreEqual ("1,2,3,4", mNumbers.Display ());
         Assert.AreEqual (4, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         mNumbers.EnqueueRear (5);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void TestExceptionCheck () {
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.DequeueFront ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.DequeueRear ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.PeekFront ());
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.PeekRear ());
      }

      [TestMethod]
      public void TestPeekFront () {
         for (int i = 1; i < 5; i++) mNumbers.EnqueueFront (i);
         Assert.AreEqual (4, mNumbers.PeekFront ());
      }

      [TestMethod]
      public void TestPeekRear () {
         for (int i = 0; i < 4; i++) mNumbers.EnqueueRear (i);
         Assert.AreEqual (3, mNumbers.PeekRear ());
      }

      TDeque<int> mNumbers = new ();
   }
}
