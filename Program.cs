using System;
namespace wordpalindrome {
    class Program {
        static bool Palindrome (string words) {
            string word = words.Replace (" ", "").ToLower ();
            int left = 0, right = word.Length - 1;
            while (left < right) {
                if (word[left] != word[right]) return false;
                left++; right--;
            }
            return true;
        }
        static void Main (string[] args) {
            Console.Write ("Enter a word or phrase : ");
            string words = Console.ReadLine ();
            if (Palindrome (words))
                Console.WriteLine ("It is a Palindrome");
            else Console.WriteLine ("It is not a Palindrome");
        }
    }
}