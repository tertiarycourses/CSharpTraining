int num1 = GetInteger("Enter a number: ");
int num2 = GetInteger("Enter another number: ");

try
{
Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
}catch (DivideByZeroException e)
{
Console.WriteLine("Exection caught:" + e.Message);
} 

static int GetInteger(String prompt)
{
int result =0;
bool ok = true;
do
{
    Console.Write(prompt);

    try
    {
        result = int.Parse(Console.ReadLine());
        ok = true;

    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid input\n");
        ok = false;
    }
}
while (!ok);
return result;
}


