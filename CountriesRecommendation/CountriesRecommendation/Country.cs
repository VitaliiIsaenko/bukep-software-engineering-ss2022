using System;
public class Country
{
  public string Name{get;}
  private long Population;
  private long AverageSalary;
  public bool HasSea {get;}
  public Country(string couuntruName, long countryPopylation, long countryAverageSalary, bool countryHasSea)
  {
    Name = couuntruName;
    Population = countryPopylation;
    AverageSalary = countryAverageSalary;
    HasSea = countryHasSea;
  }
  public override string ToString()
  {
    var desciption = $"Страна {Name} с населением {Population} , средней зарплатой {AverageSalary}$.";
    if (HasSea)
    {
      desciption += "Имеет выход к морю";
    }
    else
    {
      desciption += "Не имеет выход к морю";
    }
    return desciption;
  }
    
    
  
}