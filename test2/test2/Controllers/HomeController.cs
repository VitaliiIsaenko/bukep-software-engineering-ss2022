using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test2.Data;
using test2.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace test2.Controllers
{
    public class HomeController : Controller
    {
        private readonly CountryContext _context;

        public HomeController(CountryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetCountries(
            [FromQuery] bool sea_check = false,
            [FromQuery] long salary_min = 0,
            [FromQuery] long salary_max = 0,
            [FromQuery] long area_min = 0,
            [FromQuery] long area_max = 0,
            [FromQuery] long people_min = 0, 
            [FromQuery] long people_max = 0)
        {
            List<CountryModel> db = _context.CountryModel.ToList();
            List<CountryModel> out_countries = new List<CountryModel>();

            foreach (CountryModel country in db)
            {
                if ((sea_check == false || country.Sea==sea_check) && 
                    (salary_min <= country.Salary && country.Salary <= salary_max) && 
                    (area_min <= country.Area && country.Area <= area_max) && 
                    (people_min <= country.People && country.People <= people_max))
                {
                    out_countries.Add(country);

                }
                Console.Write("\nsea check "+ (country.People <= people_max)+"\n people "+ country.People+"\nmax "+people_max);
            }

            return Json(out_countries, new JsonSerializerOptions { PropertyNamingPolicy = null });
        }

    }
}
    