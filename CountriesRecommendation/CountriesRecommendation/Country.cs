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
    private bool liveBySea;
    public bool Satisfied(Country country)
    {
        if (liveBySea)

        {
            if (country.HasSea)

            {
                return true;
            }
            
            else

            {
                return false;
            }            
        }
        return true;
    }     
}