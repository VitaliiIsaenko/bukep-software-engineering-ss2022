using System;
public class Country
{
   public string Name {get;}
   private long Population; 
   private long AverageSalary; 
   public bool HasSea {get;}
   public Country(string countryName, long countryPopulation, long countryAverageSalary, bool countryHasSea)
   {
       Name = countryName;
       Population = countryPopulation;
       AverageSalary = countryAverageSalary;
       HasSea = countryHasSea;
   }
   public override string ToString()
   {
       var description = $"Страна {Name} с населением {Population}, средней зарплатой {AverageSalary}$. ";
       if (HasSea)
       {
           description += "Имеет выход к морю";
       }
       else
       {
           description += "Не имеет выхода к морю";
       }
       return description;
   }
  
}

