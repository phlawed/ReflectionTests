<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?

//Tried the following.  Didn't expect to work, and it doesn't

void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(Console.consoleProperty);
	}
}


