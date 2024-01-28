using TypeGen.Core.TypeAnnotations;

namespace TestingTypGen;

[ExportTsInterface]
public class ComplexViewModel
{
    public int Value { get; set; }

    public string Name { get; set; } = string.Empty;

    public DataItemViewModel DataItem { get; set; } = new DataItemViewModel();

    public DataItemViewModel[] DataItems { get; set; } = [];
}
