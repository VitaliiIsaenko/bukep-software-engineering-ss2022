using CountriesRecommendation.Helpers;
namespace CountriesRecommendation;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Хотите ли вы жить у моря?");
        var answer = Console.ReadLine();

        var liveBySea = answer == "да";

        Console.WriteLine(liveBySea);

        Country[] countries = CountriesCsvReader.ReadCountries("bondarev.csv");
    
        if (liveBySea == true) {
        if (countries[0].HasSea) {
            Console.WriteLine(countries[0].ToString());
        }
        if (countries[1].HasSea) {
            Console.WriteLine(countries[1].ToString());
            }
        } else {
            Console.WriteLine(countries[0].ToString());
        }
    }
}