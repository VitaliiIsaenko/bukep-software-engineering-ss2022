using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountriesRecommendation.Helpers;
public class CsvReader
{
<<<<<<< HEAD:CountriesRecommendation/CountriesRecommendation.Helpers/CountriesCsvReader.cs
    public static Country[] ReadCountries(string fileName)
    {
=======
    public static string[][] Read(string fileName)
    {   
>>>>>>> origin/lab-3:CountriesRecommendation/CountriesRecommendation.Helpers/CsvReader.cs
        var curr = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
        var filePath = $"{curr}/countries/{fileName}";

        var lines = File.ReadAllLines(filePath).Skip(1).ToArray();
        string[][] rows = new string[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            var fields = lines[i].Split(",");
            // var country = new Country(fields[0], long.Parse(fields[1]), int.Parse(fields[2]), fields[3] == "да");
            rows[i] = fields;
        }
        return rows;
    }

    public static string[][] Read(string v)
    {
        throw new NotImplementedException();
    }

    public static string[][] Read(string v)
    {
        throw new NotImplementedException();
    }
}