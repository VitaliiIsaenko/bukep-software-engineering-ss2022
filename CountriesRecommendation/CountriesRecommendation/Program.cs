﻿using CountriesRecommendation.Helpers;
namespace CountriesRecommendation;
public class Program
{
public static void Main()
{
    Console.WriteLine("Хотите ли вы жить у моря?");
    string answer = Console.ReadLine();
    bool liveBySea;
    liveBySea = answer == "да";
    UserPreferences preferences = new UserPreferences();
    preferences.SetLiveBySea(liveBySea);
    string[][] countriesInfo = CsvReader.Read("bezuglov.csv");
    Country[] countries = new Country[countriesInfo.Length];
    for (int i = 0; i < countriesInfo.Length; i++)
    {
        string[] countryInfo = countriesInfo[i];
        countries[i] = new Country(countryInfo[0], int.Parse(countryInfo[1]), long.Parse(countryInfo[2]), countryInfo[3] == "да");
        } 
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
    foreach(Country country in countries) {
        if (preferences.Satisfied(country)) {
            Console.WriteLine(country.Name);
            return;
        }
    }
    Console.WriteLine("Извините, мы не смогли подобрать страну с такими параметрами");
}
}
