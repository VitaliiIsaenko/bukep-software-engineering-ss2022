public class UserPreferences
{
    private bool liveBySea;

    private int minSalary;

    private string? size;

     public bool Satisfied(Country country)
    {
        return MinSalarySatisfied(country) && SatisfiedLiveBySea(country);
    }

    private bool MinSalarySatisfied (Country country){
    return minSalary<country.averageSalary;
    }
    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }

    public void SetMinSalary(int salary) 
    {
        if(salary > 0)
        {
            this.minSalary = salary;
        }
        else
        {
        throw new Exception("Минимальная зарплата должна быть больше 0");
        }
        
    }
    public bool SatisfiedLiveBySea(Country country)
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