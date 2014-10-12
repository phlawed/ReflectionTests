<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.dll</Reference>
</Query>

//But what properties (?) of a PropertyInfo are the results?  Seems to be made of two components

//Results:
//Boolean IsInputRedirected
//Boolean IsOutputRedirected
//Boolean IsErrorRedirected
//System.IO.TextReader In

//How to get the actual value in each case?

void Main()
{
	var consoleProperties = typeof(Console).GetProperties();

	foreach(var consoleProperty in consoleProperties)
	{
		Console.WriteLine(consoleProperty.ToString());
	}
}


