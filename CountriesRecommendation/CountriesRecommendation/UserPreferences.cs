public class UserPreferences
{
    private string ? size;
    private int minSalary;
    private bool LiveBySea;

    public bool Satisfied(Country country)
    {
        if (LiveBySea)
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
        this.LiveBySea = liveBySea;
    }

}