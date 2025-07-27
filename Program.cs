// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace TestProject.Csv;

internal class Program
{
    static void Main()
    {
        string path = "DataSource/Data.csv";
        
        if (!File.Exists(path))
            throw new InvalidOperationException("Could not find CSV File");

        using var reader = new StreamReader(path);
        using var test = new CsvReader(reader, CultureInfo.InvariantCulture);

        test.Context.RegisterClassMap<CsvContentMap>();
        var records = test.GetRecords<CsvContent>();

        foreach (var record in records)
            Console.WriteLine(record.First);
    }
}




