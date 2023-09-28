/// <summary>Program that says whether the given number is an Armstrong number or not</summary>
class Program {
   /// <summary>The entry point of the program</summary>
   static void Main () {
      while (true) {
         Console.Write ("Enter a positive number: ");
         if (!int.TryParse (Console.ReadLine (), out int number) || number <= 0) continue;
         Console.WriteLine (IsArmstrong (number) ? "It is an Armstrong number" : "Not an Armstrong number");
         break;
      }
   }

   /// <summary>Calculates the sum of nth power of each digit, where n is the length of the given number</summary>
   /// <param name="number">The number to be checked whether armstrong or not</param>
   /// <returns><c>true</c>if the given number and the sum of nth power of each digit are same;<c>false</c>otherwise</returns>
   static bool IsArmstrong (int number) {
      int originalNumber = number;
      int power = number.ToString ().Length;
      int sum = 0;
      for (int i = 0; i < power; i++) {
         sum += (int)Math.Pow (number % 10, power);
         number /= 10;
      }
      return originalNumber == sum;
   }
}