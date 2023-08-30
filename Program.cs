while (true) {
   Console.Write ("Enter your password : ");
   string password = Console.ReadLine ();
   string spclChar = "!@#$%^&*()-+";
   bool output = password.Length >= 6 && password.Any (char.IsDigit) && password.Any (char.IsLower) && password.Any (char.IsUpper) && password.Any (spclChar.Contains);
   if (output == true) { Console.WriteLine ("Your password is strong."); break; } 
   else {
      Console.WriteLine ("Your password is not strong.");
      if (password.Length < 6) Console.WriteLine ("Length of the password must be atleast 6.");
      if (password.Any (char.IsDigit) == false) Console.WriteLine ("Password must contain atleast one digit.");
      if (password.Any (char.IsLower) == false) Console.WriteLine ("Password must contain atleast one lowercase.");
      if (password.Any (char.IsUpper) == false) Console.WriteLine ("Password must contain atleast one Uppercase.");
      if (password.Any (spclChar.Contains) == false) Console.WriteLine ("Password must contain atleast one Special character.");
      Console.WriteLine ("\n");
   }
}