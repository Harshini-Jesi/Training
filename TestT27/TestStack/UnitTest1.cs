using T27;
namespace TestStack {
   [TestClass]
   public class UnitTest1 {

      [TestMethod]
      public void TestDisplay () {
         mNum.Push (4);
         mNum.Push (5);
         mNum.Push (6);
         Assert.AreEqual (4, 5, 6, mNum.Display ());
      }

      [TestMethod]
      public void TestPeek () {
         Assert.ThrowsException<InvalidOperationException> (() => mNum.Peek ());
         mNum.Push (8);
         mNum.Push (9);
         mNum.Push (10);
         Assert.AreEqual (10, mNum.Peek ());
      }

      [TestMethod]
      public void TestPop () {
         Assert.ThrowsException<InvalidOperationException> (() => mNum.Pop ());
         mNum.Push (6);
         mNum.Push (7);
         Assert.AreEqual (7, mNum.Pop ());
         Assert.AreEqual (1, mNum.Count);
      }

      [TestMethod]
      public void TestPush () {
         mNum.Push (1);
         mNum.Push (2);
         mNum.Push (3);
         mNum.Push (4);
         Assert.AreEqual (4, mNum.Count);
         Assert.AreEqual (4, mNum.Capacity);
         mNum.Push (5);
         Assert.AreEqual (5, mNum.Count);
         Assert.AreEqual (8, mNum.Capacity);
      }
      TStack<int> mNum = new ();

   }
}