using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Хотите ли вы жить у моря?");
        string answer = Console.ReadLine();

        bool liveBySea;

        if (answer == "да")
        {
            liveBySea = true;
        }

        else
        {
            liveBySea = false;
        }

        Console.WriteLine(liveBySea);
    }
}
Country[] countries = CountriesCsvReader.ReadCountries("Gunchenko.csv");
CountriesCsvReader.ReadCountries(Gunchenko.csv)
if (countries[0].HasSea)
Console.WriteLine = countries[0].ToString()
liveBySea = answer == "да"