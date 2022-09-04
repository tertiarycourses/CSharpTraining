
string str = "The quick brown fox jumps over the lazy dog";

// count the number of o's in the string
var count = 0;
foreach (char c in str) {
if (c == 'o') {
    count++;
}
}
Console.WriteLine("Counted {0} o characters", count);
