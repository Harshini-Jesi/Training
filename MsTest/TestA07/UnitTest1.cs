using A07;
namespace TestA07 {
   [TestClass]
   public class UnitTest1 {
      [TestMethod]
      public void CheckDoubleParse () {
         string[] test = { "123", "-123", "123.45", "-123.45", "+123.45e45", "-123.45e-45", "123e-45", ".45e3", "123.", "4.e45", "34.4E3", "6.7e+6", "45.5e4e7", "",
            "1-23", "-12-3.45e3", "123.-4e4", "123.45e3.6", "e24", "shr", "123.g", "123e", "123+", "123-", "+-98","12e3","-123.-98" ,".e- ","-e+"};
         foreach (string result in test) {
            if (!double.TryParse (result, out double num)) num = double.NaN;
            DoubleParse.TryParses (result.Trim ().ToLower (), out double output);
            Assert.AreEqual (num, output);
         }
      }
   }
}