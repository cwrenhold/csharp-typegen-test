using TestingTypGen;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var dataitem = new DataItemViewModel()
{
	Value = 1,
	Name = "Test"
};

Console.WriteLine(dataitem.Name);
