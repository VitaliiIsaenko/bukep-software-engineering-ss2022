public class UserPreferences
{
    private bool liveBySea;
    private int minSalary;
    private CountrySize size;
    private bool MinSalarySatisfied(Country country)
    {
        return minSalary < country.averageSalary;
    }
    public bool SizeSatisfied(Country country)
    {
        return size == country.GetSize();
    }
    public void SetSize(CountrySize size)
    {
        this.size = size;
    }

    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }
    public void SetMinSalary(int salary)
    {
        if (salary < 0)
        {
            throw new Exception("зп не может быть отрицательной");
        }
        minSalary = salary;
    }



    public bool Satisfied(Country info)
    {
        return LiveBySeaSatisfied(info) && MinSalarySatisfied(info) && SizeSatisfied(info);
    }
    public bool LiveBySeaSatisfied(Country country)
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
}