using Countries;


CountriesCsv countryCsv = new CountriesCsv("countries/ibragimov.csv");
countryCsv.Read();
Console.WriteLine(countryCsv.countries_[0].Name);
