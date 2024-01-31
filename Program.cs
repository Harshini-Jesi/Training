namespace Training {
   class Program {
      static void Main () {
         Console.WriteLine ("Press (C)ircle or (R)ectangle");
         if (Console.ReadKey (true).Key == ConsoleKey.C) {
            Circle round = new () {
               Radius = 5
            };
            Console.WriteLine ($"Circle: Radius={round.Radius}, Area={round.Area}");
         } else if (Console.ReadKey (true).Key == ConsoleKey.R) {
            Rectangle rect = new () {
               Length = 5,
               Width = 5
            };
            Console.WriteLine ($"Rectangle: Length={rect.Length}, Width={rect.Width}, Area={rect.Area}");
         } else Console.WriteLine ("Press C or R");
      }
   }

   public class Circle {
      public double Radius { get; set; }

      public double Area => Math.Round (Math.PI * Radius * Radius, 2);
   }

   public class Rectangle {
      public double Length { get; set; }

      public double Width { get; set; }

      public double Area => Length * Width;
   }
}