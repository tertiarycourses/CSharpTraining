static void MyMethod(string fname) 
{
  Console.WriteLine(fname + " Refsnes");
}

MyMethod("Liam");
MyMethod("Jenny");
MyMethod("Anja");

static void MyMethod2(string fname, int age) 
{
  Console.WriteLine(fname + " is " + age);
}

MyMethod2("Liam", 5);
MyMethod2("Jenny", 8);
MyMethod2("Anja", 31);

static void MyMethod3(string child1, string child2, string child3) 
{
  Console.WriteLine("The youngest child is: " + child3);
}

MyMethod3(child3: "John", child1: "Liam", child2: "Liam");


