public class UserPreferences
{
    private bool liveBySea;
    private int minSalary;
    private string size;
    private bool MinSalarySatisfied(Country country) {
       return minSalary<country.averageSalary;
    }
    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }
    public void SetMinSalary(int salary) {
        if(salary<0){
            throw new Exception("зп не может быть отрицательной");
        }
        minSalary = salary;
    }



    public bool Satisfied (Country info) {
        return LiveBySeaSatisfied (info)&& MinSalarySatisfied (info);
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