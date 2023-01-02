using Microsoft.AspNetCore.Mvc;

namespace Wang_Gloria_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        //TODO: Create a new action method for the new page
        public IActionResult Hobbies()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/GloriaWang_Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "GloriaWang_Resume.pdf");
        }
    }
}

