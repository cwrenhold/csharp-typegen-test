using TypeGen.Core.TypeAnnotations;

namespace TestingTypGen;

[ExportTsInterface]
public class DataItemViewModel
{
	public int Value { get; set; }

	public string Name { get; set; } = string.Empty;
}
