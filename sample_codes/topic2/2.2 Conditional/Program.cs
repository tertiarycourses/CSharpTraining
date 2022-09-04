int theVal = 55;

// if-else
if (theVal < 50) {
    Console.WriteLine("theVal is smaller than 50");
    }
else {
    Console.WriteLine("theVal is larger than 50");
}

// else if
if (theVal == 50) {
    Console.WriteLine("theVal is "+theVal);
    }
else if (theVal >= 51 && theVal <= 60) {
        Console.WriteLine("theVal is between 51 and 60");
    }
else {
        Console.WriteLine("theVal is something else");
        }

// Using the ternary operator ?:
Console.WriteLine(theVal < 50 ? "theVal is smaller than 50" : "theVal is large than 50");
