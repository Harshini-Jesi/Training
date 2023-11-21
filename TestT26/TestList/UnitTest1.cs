using System;
using T26;
namespace TestList {
   [TestClass]
   public class UnitTest1 {
      MyList<int> numbers = new ();

      [TestMethod]
      public void TestAdd () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         Assert.AreEqual (3, numbers.Count);
         Assert.AreEqual (4, numbers.Capacity);
         numbers.Add (4);
         numbers.Add (5);
         Assert.AreEqual (5, numbers.Count);
         Assert.AreEqual (8, numbers.Capacity);
      }

      [TestMethod]
      public void TestClear () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         Assert.AreEqual (3, numbers.Count);
         numbers.Clear ();
         Assert.AreEqual (0, numbers.Count);
      }

      [TestMethod]
      public void TestDisplay () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         numbers.Display ();
      }

      [TestMethod]
      public void TestIndex () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         numbers[2] = 5;
         Assert.AreEqual (5, numbers[2]);
         Assert.AreEqual (4, numbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers[5]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers[-3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers[7] = 10);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers[-1] = 9);
      }

      [TestMethod]
      public void TestInsert () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         numbers.Add (4);
         numbers.Insert (1, 8);
         Assert.AreEqual (8, numbers[1]);
         Assert.AreEqual (5, numbers.Count);
         Assert.AreEqual (8, numbers.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers.Insert (6, 10));
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers.Insert (-1, 10));
      }

      [TestMethod]
      public void TestRemove () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         numbers.Remove (2);
         Assert.AreEqual (3, numbers[1]);
         Assert.AreEqual (2, numbers.Count);
         Assert.ThrowsException<InvalidOperationException> (() => numbers.Remove (6));
      }

      [TestMethod]
      public void TestRemoveAt () {
         numbers.Add (1);
         numbers.Add (2);
         numbers.Add (3);
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers.RemoveAt (4));
         Assert.ThrowsException<IndexOutOfRangeException> (() => numbers.RemoveAt (-2));
         numbers.RemoveAt (0);
         Assert.AreEqual (2, numbers.Count);
      }
   }
}