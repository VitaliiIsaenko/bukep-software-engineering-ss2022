public class UserPreferences
{   
    private string ?size;
    private int minSalary;
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
        else
        {
            return true;
        } 
    }
    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }
}