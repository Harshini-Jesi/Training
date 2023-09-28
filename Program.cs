/// <summary>This program calculates the nth armstrong number</summary>
class Program {
   /// <summary>The entry point of the program</summary>
   static void Main () {
      while (true) {
         Console.Write ("Enter a positive number within 25: ");
         if (!int.TryParse (Console.ReadLine (), out int value) || value <= 0 || value > 25) continue;
         Console.WriteLine ($"The {value}th Armstrong number is: {CalculateNthArmstrong (value)}");
         break;
      }

      /// <summary>Calculates the nth armstrong number</summary>
      /// <param name="value">The nth value for which the armstrong number is to be calculated</param>
      /// <returns>The nth armstrong number</returns>
      static int CalculateNthArmstrong (int value) {
         int count = 1, num = 1;
         while (count < value) {
            num++;
            if (IsArmstrong (num)) count++;
         }
         return num;
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
}