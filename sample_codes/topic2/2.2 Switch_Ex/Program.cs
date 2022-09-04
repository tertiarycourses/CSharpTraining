Console.Write("Enter a number between 1 to 7 : ");
String s = Console.ReadLine();
int myValue = Convert.ToInt32(s);

String[] daysOfWeek = { "Monday", "Tuesday","Wednesday","Thursday","Friday","Saturday", "Sunday"};
String day1 = daysOfWeek[0];
String day2 = daysOfWeek[1];
String day3 = daysOfWeek[2];
String day4 = daysOfWeek[3];
String day5 = daysOfWeek[4];
String day6 = daysOfWeek[5];
String day7 = daysOfWeek[6];

if (myValue > 0 && myValue <= 7){
    switch (myValue)
    {
        case 1: Console.WriteLine(day1); break;
        case 2: Console.WriteLine(day2); break;
        case 3: Console.WriteLine(day3); break;
        case 4: Console.WriteLine(day4); break;
        case 5: Console.WriteLine(day5); break;
        case 6: Console.WriteLine(day6); break;
        case 7: Console.WriteLine(day7); break;
    } 
}
else
{
    Console.WriteLine(myValue + " is not 1-7!");
}