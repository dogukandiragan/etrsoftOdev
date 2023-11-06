using etrsoftOdev.Web.Models;
using etrsoftOdev.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;




namespace etrsoftOdev.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        
        public IActionResult Index()
        {

            DataAccess.Process p = new DataAccess.Process();


            List<HesapDTO> Recordlr = p.getList();

            ViewBag.Tarih = p.getDate();

            return View(Recordlr);





        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}