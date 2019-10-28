using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using _07WebAPI.Models;

namespace _07WebAPI.Controllers
{
    public class CourseController : ApiController
    {
        List<Course> courses = new List<Course>
        {
            new Course{Id=1,Name="ASP.net MVC5",Hours=30},
            new Course{Id=2,Name="ASP.net WebForm",Hours=20},
            new Course{Id=3,Name="HTML5",Hours=10},
            new Course{Id=4,Name="PHP",Hours=70},
            new Course{Id=5,Name="Java",Hours=50},
            new Course{Id=6,Name="jQuery",Hours=40},
            new Course{Id=7,Name="SQL sever",Hours=60},
            new Course{Id=8,Name="RWD",Hours=80},
            new Course{Id=9,Name="Andriod",Hours=90},
            new Course{Id=10,Name="Bootstrap",Hours=35}
        };


        public IEnumerable<Course> Get()
        {
            return courses;
        }


    }
}