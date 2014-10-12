<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?

//Hack solution:  (still need to know why we can’t access these properties)

void Main()
{
	var consoleProperties = typeof(Console).GetProperties();
	var type = typeof(Console);
	
	var listOfExcludedProperties = new List<string>();
	listOfExcludedProperties.Add("BufferHeight");
	listOfExcludedProperties.Add("BufferWidth");
	listOfExcludedProperties.Add("WindowHeight");
	listOfExcludedProperties.Add("WindowWidth");
	listOfExcludedProperties.Add("WindowLeft");
	listOfExcludedProperties.Add("WindowTop");
	listOfExcludedProperties.Add("CursorLeft");
	listOfExcludedProperties.Add("CursorTop");
	listOfExcludedProperties.Add("CursorSize");
	listOfExcludedProperties.Add("CursorVisible");
	listOfExcludedProperties.Add("KeyAvailable");
	listOfExcludedProperties.Add("TreatControlCAsInput");

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(consoleProperty.ToString());

		var name = consoleProperty.Name.ToString();

		if(!listOfExcludedProperties.Any(x => x == name))
			Console.WriteLine("\t Value = {0}", consoleProperty.GetValue(type).ToString());
	}
}


//why doesn’t this work:
//
//		if(!listOfExcludedProperties.Select(x => x == name).Any())
//or
//		if(!listOfExcludedProperties.Where(x => x == name).Any())
//
//instead of 
//
//		if(!listOfExcludedProperties.Any(x => x == name))
//
//(returns false for everything)