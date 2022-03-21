using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program

{
    public static void Main()
   
    {
    private const int V = 1;

    public static void Main()
        {
            Console.WriteLine("Хотите ли вы жить у моря?");
            string answer = Console.ReadLine();

            bool liveBySea;

            liveBySea = answer == "да";

            Console.WriteLine(liveBySea);
            /*Country[] countries = CountriesCsvReader.ReadCountries("Osipova.csv");
            CountriesCsvReader.ReadCountries("Osipova.csv");
            
            if (countries[0].HasSea)
            {
                if (liveBySea == true)    
                {
                    Console.WriteLine(countries[0].ToString());
                }
                else
                {
                    Console.WriteLine(countries[1].ToString());  
                } 
            }
            else
            {
                Console.WriteLine(countries[1].ToString());
            } 
            */
        }

    }
