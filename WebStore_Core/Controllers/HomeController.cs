using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_Core.Data;
using WebStore_Core.Models;

namespace WebStore_Core.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _Configuration;


        public HomeController(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        public IActionResult Index()
        {
            // Обработка данные

            // вывод представления
            return View();

            // вывод содержимого
            //return Content("First controller action");
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Employees()
        {
            return View(TestData.Employees);
        }

        public IActionResult Blogs() => View();
        public IActionResult BlogsSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult CheckOut() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductsDetail() => View();
        public IActionResult Shop() => View();
    }
}
