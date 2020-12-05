using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_Core.Models;

namespace WebStore_Core.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; set; }  = new()
        {
            new Employee { Id = 1, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 },
            new Employee { Id = 2, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 },
            new Employee { Id = 3, LastName = "Ivanov", FirstName = "Ivan", Patronymic = "Ivanich", Age = 26 }
        };
    }
}
