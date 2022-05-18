public class UserPreferences
{
    private bool liveBySea;

    private int minSalary;

    private string? size;

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
    internal bool Satisfied(Country country)
    {
        throw new NotImplementedException();
    }

    // public bool Satisfied(Country country)
    // {
    //     if (liveBySea)

    //     {
    //         if (country.HasSea)

    //         {
    //             return true;
    //         }

    //         else

    //         {
    //             return false;
    //         }            
    //     }
    //     return true;
    // }      {
    //             return false;
    //         }            
    //     }
    //     return true;
    // }      {
    //             return false;
    //         }            
    //     }
    //     return true;
    // }      {
    //             return false;
    //         }            
    //     }
    //     return true;
    // }     urn true;
    // }     
}