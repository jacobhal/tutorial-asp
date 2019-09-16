using System;
using System.Collections.Generic;
using TutorialASP.Models;

namespace TutorialASP.ViewModels
{
    public class AllCustomersViewModel
    {
        public List<Customer> Customers { get; set; }

        public AllCustomersViewModel()
        {
        }
    }
}
