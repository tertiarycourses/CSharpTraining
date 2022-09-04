
(int a, int b) tup1 = (5, 10);
var tup2 = ("Some text", 10.5);


tup1.b = 20;
tup2.Item1 = "New String";

Console.WriteLine($"{tup1.a},{tup1.b}");
Console.WriteLine($"{tup2.Item1},{tup2.Item2}");

