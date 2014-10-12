<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//How to get the actual value in each case?


void Main()
{
	var consoleProperties = typeof(Console).GetProperties();
	var type = typeof(Console);
	
	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(consoleProperty.ToString());

		var name = consoleProperty.Name.ToString();
		var consolePropertyType = consoleProperty.PropertyType;
		Console.WriteLine("{0} {1}", consolePropertyType, name);

		if(!string.Equals(name, "BufferHeight", StringComparison.OrdinalIgnoreCase))
			Console.WriteLine(consoleProperty.GetValue(type).ToString());
	}
}
