namespace CountriesRecommendation;

public class Program
{
    public void Main()
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