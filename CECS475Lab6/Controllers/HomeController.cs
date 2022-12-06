using CECS475Lab6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CECS475Lab6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }   
        
        public async Task<IActionResult> Index(string countryCode, int year)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            holidays = await _holidaysApiService.GetHolidays(countryCode, year);
            return View(holidays);
        }


        
      



        //private readonly ILogger<HomeController> _logger;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            return View();
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}