using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Area { get; set; }
        public int People { get; set; }
        public bool Sea { get; set; }

    }
    public class GetCountriesReq
    {
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public int AreaMin { get; set; }
        public int AreaMax { get; set; }
        public int PeopleMin { get; set; }

        public int PeopleMax { get; set; }
        public bool Sea { get; set; }
    }
}
