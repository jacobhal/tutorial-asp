using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorialASP.Models;
using TutorialASP.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TutorialASP.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult AllCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "John Lennon" },
                new Customer { Name = "Jacob Hallman" }
            };

            var viewModel = new AllCustomersViewModel { Customers = customers };

            return View(viewModel);
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
