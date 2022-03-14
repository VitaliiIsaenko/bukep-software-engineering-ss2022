using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program
    {
    private const int V = 1;

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
            Country[] countries = CountriesCsvReader.ReadCountries("bezuglov.csv");
            CountriesCsvReader.ReadCountries("bezuglov.csv");
            
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