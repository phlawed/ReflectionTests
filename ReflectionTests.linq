<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//Idea:  Is there a way to loop thru all properties of a class?

//Investigation suggested GetProperties:

void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(consoleProperty.ToString());
	}
	
}


