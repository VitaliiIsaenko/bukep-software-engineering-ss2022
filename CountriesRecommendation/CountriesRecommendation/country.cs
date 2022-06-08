public class Country
{
    public Country(string name, int averageSalary, bool hasSea, long population)
    {
        Name = name;
        this.averageSalary = averageSalary;
        this.HasSea = hasSea;
        this.population = population;

    }
    private long population;
    public int averageSalary;
    public bool HasSea;
    public string Name;
    public CountrySize GetSize()
    {
        if (population <= 40_000_000)
        {

            return CountrySize.Small;

        }

        else if (40_000_000 < population && population < 100_000_000)
        {

            return CountrySize.Medium;

        }

        else
        {

            return CountrySize.Big;

        }
    }
}