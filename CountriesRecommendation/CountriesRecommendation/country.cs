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
private int averageSalary;
public bool HasSea;
public string Name;
}