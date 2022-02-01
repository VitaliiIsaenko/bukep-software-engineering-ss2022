using Countries;


CountriesCsv countryCsv = new CountriesCsv("countries/ibragimov.csv");
Console.WriteLine(countryCsv.countries_[0].Name);
