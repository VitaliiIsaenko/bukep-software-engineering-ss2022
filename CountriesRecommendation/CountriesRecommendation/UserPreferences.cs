public class UserPreferences
{
    private bool liveBySea;

    private int minSalary;

    private string? size;

    private bool MinSalarySatisfied;

    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }

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

            else

            {
                return true;
            }
        }
    }     
}