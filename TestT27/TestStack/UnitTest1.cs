using T27;
namespace TestStack {
   [TestClass]
   public class UnitTest1 {
      TStack<int> num = new ();

      [TestMethod]
      public void TestPush () {
         num.Push(1);
         num.Push(2);
         num.Push(3);
         num.Push(4);
         Assert.AreEqual(4, num.Count);
         Assert.AreEqual (4, num.Capacity);
         num.Push(5);
         Assert.AreEqual(5, num.Count);
         Assert.AreEqual(8, num.Capacity);
      }

      [TestMethod]
      public void TestPop () {
         Assert.ThrowsException<InvalidOperationException>(() => num.Pop());
         num.Push (6);
         num.Push (7);
         Assert.AreEqual(7, num.Pop());
         Assert.AreEqual(1, num.Count);
      }

      [TestMethod]
      public void TestPeek () {
         Assert.ThrowsException<InvalidOperationException>(() => num.Peek());
         num.Push (8);
         num.Push (9);
         num.Push (10);
         Assert.AreEqual (10, num.Peek ());
      }

      [TestMethod]
      public void TestDisplay () {
         num.Push (4);
         num.Push (5);
         num.Push (6);
         num.Display ();
      }
   }
}