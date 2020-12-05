using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_Core.Models;

namespace WebStore_Core.Controllers
{
    public class HomeController : Controller
    {

        private readonly IConfiguration _Configuration;
        private static readonly List<Employee> _Employees = new()
        {
            new Employee { Id = 1, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 },
            new Employee { Id = 2, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 },
            new Employee { Id = 3, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 }
        };

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
            return View(_Employees);
        }

        public IActionResult Details(int Id)
        {
            return View(_Employees[Id]);
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
