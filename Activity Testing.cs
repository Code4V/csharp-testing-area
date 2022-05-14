using System;

public class Class1
{
	public Class1()
	{
		public static int age = 40;
		public static int salary = 25000;

	}
}

public class record :Class1
{
	new public static int salary = 50000;
	static void Main(string[] args)
    {
		Console.WriteLine(Class1.age + " " + Class1.salary + " " + salary);
    }
}