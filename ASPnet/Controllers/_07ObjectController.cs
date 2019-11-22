using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPnet.App_Code;

namespace ASPnet.Controllers
{
    public class _07ObjectController : Controller
    {

        // GET: _07Object
        public ActionResult Index()
        {
            Person jack = new Person();

            //jack.Name = "Jack Wang";
            jack.Age = 18;
            jack.Gender = true;
            jack.Height = 175.5M;
            jack.Weight = 60;
            jack.Speak();
            jack.Jump();
            jack.Walk(10);

            Person mary = new Person();
            mary.Name = "Jack Lee";
            mary.Age = 17;
            mary.Gender = false;
            mary.Height = 155.5M;
            mary.Weight = 40;
            mary.Speak(5);
            mary.Jump(6, 3);

            var avg = (jack.Age + mary.Age) / 2;

            Person john = new Person("John Lin", 20, true, 170, 64);

            Superman Clock = new Superman();
            Clock.Walk(500);
            Clock.Fly();


            return View();
        }

        Animal animal;


        public ActionResult polymophsim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult polymophsim(string type)
        {

            Dog dog = new Dog();
            Cat cat = new Cat();

            if (type == "d")
            {
                animal = dog;
            }

            else if (type == "c")
            {
                animal = cat;
            }

            ViewBag.Result = animal.Speak();

            return View();

        }

    }
}