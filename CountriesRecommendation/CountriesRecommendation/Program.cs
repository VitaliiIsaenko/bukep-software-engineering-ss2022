using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Хотите ли вы жить у моря?");
        string answer = Console.ReadLine();

        bool liveBySea;

        liveBySea = answer == "да";

        Console.WriteLine(liveBySea);
        Country[] countries = CountriesCsvReader.ReadCountries("Isaenko.csv");
        if (!countries[0].HasSea)
        {
        Console.WriteLine(countries[0].ToString());
        }
    }
}