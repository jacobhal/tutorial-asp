using System;
using System.Collections.Generic;
using TutorialASP.Models;

namespace TutorialASP.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }

        public RandomMovieViewModel()
        {
        }
    }
}
