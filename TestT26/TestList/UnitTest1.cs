using T26;
namespace TestList {
   [TestClass]
   public class UnitTest1 {

      [TestMethod]
      public void TestAdd () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         Assert.AreEqual (3, mNumbers.Count);
         Assert.AreEqual (4, mNumbers.Capacity);
         mNumbers.Add (4);
         mNumbers.Add (5);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
      }

      [TestMethod]
      public void TestClear () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         Assert.AreEqual (3, mNumbers.Count);
         mNumbers.Clear ();
         Assert.AreEqual (0, mNumbers.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         mNumbers.Display ();
         Assert.AreEqual (mNumbers[0], 1);
         Assert.AreEqual (mNumbers[1], 2); 
         Assert.AreEqual (mNumbers[2], 3);
      }

      [TestMethod]
      public void TestIndex () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         mNumbers[2] = 5;
         Assert.AreEqual (5, mNumbers[2]);
         Assert.AreEqual (4, mNumbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[5]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[-3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[7] = 10);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[-1] = 9);
      }

      [TestMethod]
      public void TestInsert () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         mNumbers.Add (4);
         mNumbers.Insert (1, 8);
         Assert.AreEqual (8, mNumbers[1]);
         Assert.AreEqual (5, mNumbers.Count);
         Assert.AreEqual (8, mNumbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.Insert (6, 10));
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.Insert (-1, 10));
      }

      [TestMethod]
      public void TestRemove () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         mNumbers.Remove (2);
         Assert.AreEqual (3, mNumbers[1]);
         Assert.AreEqual (2, mNumbers.Count);
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Remove (6));
      }

      [TestMethod]
      public void TestRemoveAt () {
         mNumbers.Add (1);
         mNumbers.Add (2);
         mNumbers.Add (3);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.RemoveAt (4));
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.RemoveAt (-2));
         mNumbers.RemoveAt (0);
         Assert.AreEqual (2, mNumbers.Count);
      }

      MyList<int> mNumbers = new ();
   }
}