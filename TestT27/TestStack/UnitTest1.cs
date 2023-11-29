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
         for (int i = 6; i < 10; i++) {
            mNum.Push (i);
            mStack.Push (i);
         }
         Assert.AreEqual (mStack.Peek (), mNum.Peek ());
      }

      [TestMethod]
      public void TestPop () {
         Assert.ThrowsException<InvalidOperationException> (() => mNum.Pop ());
         for (int i = 3; i < 6; i++) {
            mNum.Push (i);
            mStack.Push (i);
         }
         Assert.AreEqual (mStack.Pop (), mNum.Pop ());
         Assert.AreEqual (mStack.Count, mNum.Count);
      }

      [TestMethod]
      public void TestPush () {
         for (int i = 6; i < 10; i++) {
            mNum.Push (i);
            mStack.Push (i);
         }
         Assert.AreEqual (mStack.Count, mNum.Count);
         Assert.AreEqual (4, mNum.Capacity);
         mNum.Push (5);
         mStack.Push (5);
         Assert.AreEqual (mStack.Count, mNum.Count);
         Assert.AreEqual (8, mNum.Capacity);
      }

      TStack<int> mNum = new ();
      Stack<int> mStack = new ();
   }
}