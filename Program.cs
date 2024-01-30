using static State;
using static System.Console;
// Test cases for Filename parser
var testCases = new Dictionary<string, bool> {
                { @"Cz:\abc\def\r.txt", false },
                { @"C:\abc\def\r.txt", true },
                { @"C:\Readme.txt", false },
                { @"C:\abc\.bcf", false },
                { @"C:\abc\bcf.", false },
                { @"Readme.txt", false },
                { @"C:\abc\def", false },
                { @"C:\abc d", false },
                { @"\abcd\Readme.txt", false },
                { " ", false },
                { @"C:\ab.c\def\r.txt", false },
                { @"C:\abc:d", false },
                { @".\abc", false },
                { ".abc", false },
                { "abc", false },
                { @"C:\abc6\def\r.txt", false },
                { @"C:\work\r.txt", true },
                { @"C:\abc\def\r.txt.txt", false },
                { @"C:\Program Files\<>*&^%$#@!.txt", false },
                { @"C:\work~\r.txt~", false }
         };

foreach (var testCase in testCases) {
   bool parseResult = FileNameParse (testCase.Key, out var filePath);
   WriteLine (parseResult.Equals (testCase.Value) ? "=> Testcase Passed" : "=> Testcase Failed");
   if (parseResult == true) {
      WriteLine ($"Drive Letter: {filePath.drive}");
      WriteLine ($"Folder Path: {filePath.folders}");
      WriteLine ($"File Name: {filePath.fileName}");
      WriteLine ($"Extension: {filePath.ext}\n");
   } else WriteLine ("Not a valid file path.\n");
}

/// <summary>Parses a file path and results its parts as a tuple</summary>
/// <returns>True if parsing is successful; otherwise, false</returns>
/// State diagram reference: file://C:/Users/sivabalanha/Pictures/A10.1statediagram.png
bool FileNameParse (string input, out (char drive, string folders, string fileName, string ext) filePath) {
   State s = A;
   Action none = () => { }, todo;
   char drive = ' ';
   string folders = "", fileName = "", ext = "";
   foreach (var ch in input.Trim ().ToUpper () + '~') {
      (s, todo) = (s, ch) switch {
         (A, >= 'A' and <= 'Z') => (B, () => drive = ch),
         (B, ':') => (C, none),
         (C, '\\') => (D, none),
         (D or E, >= 'A' and <= 'Z') => (E, () => folders += ch),
         (E, '\\') => (F, none),
         (F or G, >= 'A' and <= 'Z') => (G, () => fileName += ch),
         (G, '\\') => (F, () => { folders += '\\' + fileName; fileName = string.Empty; }),
         (G, '.') => (H, none),
         (H or I, >= 'A' and <= 'Z') => (I, () => ext += ch),
         (I, '~') => (J, none),
         _ => (Z, none),
      };
      todo ();
   }
   if (s == J) {
      filePath = (drive, folders, fileName, ext);
      return true;
   } else {
      filePath = (' ', "", "", "");
      return false;
   }
}

enum State { A, B, C, D, E, F, G, H, I, J, Z };
