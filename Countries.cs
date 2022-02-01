using System.Collections;
using System.IO;
 
namespace Countries
{  
    public class Country
    {
        public string Name { get; set; }
        public string Wage { get; set; }
        public string IsSea { get; set; }
        public string Population { get; set; }
    }
    
    class CountriesCsv
    {   
        public string[] titles_rows;
        public List<Country> countries_;
        public string path_;

        public CountriesCsv(string path)
        {
            path_ = path;
        }
        void Read()
        {
            StreamReader sr = new StreamReader(path_);
            titles_rows = sr.ReadLine().Split(",");
            string line = sr.ReadLine();
            while (line != null)
            {   
                string[] data_line = line.Split(",");

                Country country = new Country();
                country.Name = data_line[0];
                country.Wage = data_line[1];
                country.IsSea = data_line[2];
                country.Population = data_line[3];
                countries_.Add(country);

                line = sr.ReadLine();
            }
            sr.Close();
        }
        void Save()
        {
            StreamWriter sw = new StreamWriter(path_);
            sw.WriteLine(string.Join(", ", titles_rows));
            foreach(Country country in this.countries_){
                sw.WriteLine(country.Name+","+country.Wage+","+country.IsSea+","+country.Population);
            }
            sw.Close();
        }
        void AddCountry(Country country)
        {
            countries_.Add(country);
        } 
    }
}