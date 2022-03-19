using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Хотите ли вы жить у моря?");
        string? answer = Console.ReadLine();

        bool liveBySea;
        liveBySea = answer == "да";
        Console.WriteLine(liveBySea);
        Country[] countries = CountriesCsvReader.ReadCountries("Shihantsov.csv");
        CountriesCsvReader.ReadCountries("Shihantsov.csv");
        
        if (countries[0].HasSea)
        {
            Console.WriteLine(countries[0].ToString());
        }

        else
        {
            Console.WriteLine(countries[1].ToString());
        }
    }
}

