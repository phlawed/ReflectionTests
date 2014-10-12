<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?


void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(consoleProperty.Name.ToString());
		Console.WriteLine(consoleProperty.GetValue(null).ToString());
	}
}

//This seems to work up until Property BufferHeight when it barfs