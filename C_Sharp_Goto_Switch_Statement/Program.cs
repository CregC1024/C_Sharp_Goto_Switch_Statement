// C# program to illustrate the
// use of goto in switch statement
using System;

public class GFG
{

	// Main Method
	public static void Main(String[] args)
	{
		int greeting = 2;

		switch (greeting)
		{
			case 1:
				Console.WriteLine("Hello");
				goto default;
			case 2:
				Console.WriteLine("Bonjour");
				goto case 3;
			case 3:
				Console.WriteLine("Namaste");
				goto default;
			default:
				Console.WriteLine("Entered value is: " + greeting);
				break;
		}
	}
}

