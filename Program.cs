while (true) {
   Console.Write ("Enter your password : ");
   string password = Console.ReadLine ();
   string spclChar = "!@#$%^&*()-+";
   string a = "";
   if (password.Length < 6) a += "Length of the password must be atleast 6.\n";
   if (!password.Any (char.IsDigit)) a += "Password must contain atleast one digit.\n";
   if (!password.Any (char.IsLower)) a += "Password must contain atleast one lowercase.\n";
   if (!password.Any (char.IsUpper)) a += "Password must contain atleast one Uppercase.\n";
   if (!password.Any (spclChar.Contains)) a += "Password must contain atleast one Special character.\n";
   if (string.IsNullOrEmpty (a)) {
      Console.WriteLine ("Your password is strong.");
      break;
   } else Console.WriteLine ($"Your password is weak.\n{a}");
}
