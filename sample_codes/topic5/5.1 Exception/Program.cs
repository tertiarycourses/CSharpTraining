try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}

int[] arrayOf5 = { 1, 2, 3, 4, 5 };
for (int i = 0; i < 6; i++)
{
    try{
        Console.WriteLine("Number = " + arrayOf5[i]);
    }
    catch (IndexOutOfRangeException e)
    {
        Console.WriteLine("error  " + i + ", " + e.Message);
    }
}

