using CsvHelper.Configuration;
namespace TestProject.Csv;
public class CsvContentMap : ClassMap<CsvContent>
{
    public CsvContentMap()
    {
        Map(m => m.Id).Name("id");
        Map(m => m.First).Name("first");
        Map(m => m.Second).Name("second");
        Map(m => m.Third).Name("third");
        Map(m => m.Fourth).Name("fourth");

    }
}