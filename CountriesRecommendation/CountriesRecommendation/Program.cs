using CountriesRecommendation.Helpers;

namespace CountriesRecommendation;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Хотите ли вы жить у моря?");
        string answer = Console.ReadLine();

        bool liveBySea = answer == "да";
        Console.WriteLine("Желаемая зп");
        int salary = int.Parse (Console.ReadLine());
        UserPreferences preferences = new UserPreferences ();
        preferences.SetLiveBySea (liveBySea);
preferences.SetMinSalary(salary);

          string[][] countriesInfo = CsvReader.Read("Gushchina.csv");

            Country[] countries = new Country[countriesInfo.Length];
        
        for (int i = 0; i < countriesInfo.Length; i++)

        {

            string[] countryInfo = countriesInfo[i];

            countries[i] = new Country(countryInfo[0], int.Parse(countryInfo[1]), countryInfo[3] == "да", long.Parse(countryInfo[2]) );

        }
        
     foreach (Country country in countries) {
         if (preferences.Satisfied(country)){
             Console.WriteLine(country.Name);
             return;
         }
     }
Console.WriteLine("Извините, мы не смогли подобрать страну с такими параметрами");
    }
}