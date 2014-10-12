<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?

//Whoops.  GetValue is a method of the PropertyInfo class.

void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(Console.GetValue(consoleProperty));
	}
}


