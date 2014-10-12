<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?


void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		//Just returns None for each...
		Console.WriteLine(consoleProperty.Attributes);
	}
}


