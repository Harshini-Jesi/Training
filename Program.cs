/// <summary>Program that says whether the given number is an Armstrong number or not</summary>
class Program {
   /// <summary>The entry point of the program</summary>
   static void Main () {
      while (true) {
         Console.Write ("Enter a positive number: ");
         if (!int.TryParse (Console.ReadLine (), out int number) && number > 0) continue;
         int originalNumber = number;
         Console.WriteLine (originalNumber == Armstrong (number) ? "It is an Armstrong number" : "Not an Armstrong number");
         break;
      }
   }

   /// <summary>Calculates the sum of nth power of each digit, where n is the length of the given number</summary>
   /// <param name="number">The number to be checked whether armstrong or not</param>
   /// <returns>The sum of nth power of each digit</returns>
   static double Armstrong (int number) {
      int power = number.ToString ().Length;
      double sum = 0;
      for (int i = 0; i < power; i++) {
         int temp = number % 10;
         sum += Math.Pow (temp, power);
         number /= 10;
      }
      return sum;
   }
}