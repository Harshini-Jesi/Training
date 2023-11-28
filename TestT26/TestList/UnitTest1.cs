using T26;
namespace TestList {
   [TestClass]
   public class UnitTest1 {

      [TestMethod]
      public void TestAdd () {
         for (int i = 0; i < 4; i++) {
            mNumbers.Add (i);
            mList.Add (i);
         }
         Assert.AreEqual (mList.Count, mNumbers.Count);
         Assert.AreEqual (mList.Capacity, mNumbers.Capacity);
         mNumbers.Add (4);
         mNumbers.Add (5);
         mList.Add (4);
         mList.Add (5);
         Assert.AreEqual (mList.Count, mNumbers.Count);
         Assert.AreEqual (mList.Capacity, mNumbers.Capacity);
      }

      [TestMethod]
      public void TestClear () {
         for (int i = 0; i < 4; i++) {
            mNumbers.Add (i);
            mList.Add (i);
         }
         Assert.AreEqual (mList.Count, mNumbers.Count);
         mNumbers.Clear ();
         mList.Clear ();
         Assert.AreEqual (mList.Count, mNumbers.Count);
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
         for (int i = 0; i < 4; i++) {
            mNumbers.Add (i + 1);
            mList.Add (i + 1);
         }
         mNumbers[2] = 5;
         mList[2] = 5;
         Assert.AreEqual (mList[2], mNumbers[2]);
         Assert.AreEqual (mList.Capacity, mNumbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[5]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[-3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[7] = 10);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers[-1] = 9);
      }

      [TestMethod]
      public void TestInsert () {
         for (int i = 0; i < 4; i++) {
            mNumbers.Add (i + 1);
            mList.Add (i + 1);
         }
         mNumbers.Insert (1, 8);
         mList.Insert (1, 8);
         Assert.AreEqual (mList[1], mNumbers[1]);
         Assert.AreEqual (mList.Count, mNumbers.Count);
         Assert.AreEqual (mList.Capacity, mNumbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.Insert (6, 10));
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.Insert (-1, 10));
      }

      [TestMethod]
      public void TestRemove () {
         for (int i = 1; i < 4; i++) {
            mNumbers.Add (i);
            mList.Add (i);
         }
         mNumbers.Remove (2);
         mList.Remove (2);
         Assert.AreEqual (mList[1], mNumbers[1]);
         Assert.AreEqual (mList.Count, mNumbers.Count);
         Assert.ThrowsException<InvalidOperationException> (() => mNumbers.Remove (6));
      }

      [TestMethod]
      public void TestRemoveAt () {
         for (int i = 1; i < 4; i++) {
            mNumbers.Add (i);
            mList.Add (i);
         }
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.RemoveAt (4));
         Assert.ThrowsException<IndexOutOfRangeException> (() => mNumbers.RemoveAt (-2));
         mNumbers.RemoveAt (0);
         mList.RemoveAt (0);
         Assert.AreEqual (mList.Count, mNumbers.Count);
      }

      MyList<int> mNumbers = new ();
      List<int> mList = new ();
   }
}