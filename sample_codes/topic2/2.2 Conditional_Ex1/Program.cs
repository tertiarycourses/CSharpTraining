Console.Write("Enter a number: ");
String s = Console.ReadLine();
    
int myValue = Convert.ToInt32(s);

bool isEven = myValue % 2 == 0 ;

if (isEven){
        Console.WriteLine(myValue + " is EVEN");
    }
else{
    Console.WriteLine(myValue + " is ODD");
    }
