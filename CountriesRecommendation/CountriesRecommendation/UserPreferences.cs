public class UserPreferences
{
    private bool liveBySea;
    private int minSalary;
    private string size;
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
        liveBySea = this.liveBySea;
    }
}