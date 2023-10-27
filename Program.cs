Dictionary<char, int> freq = new ();
var words = File.ReadAllText ("data/words.txt");
foreach (var c in words)
   if (c is >= 'A' and <= 'Z') freq[c] = freq.TryGetValue (c, out int value) ? ++value : 1;
var sortedList = freq.OrderByDescending (x => x.Value).Take (7);
foreach (var ele in sortedList) Console.WriteLine (ele);