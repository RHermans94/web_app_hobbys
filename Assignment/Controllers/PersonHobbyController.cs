using AssignmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.PersonProcessor;
using static DataLibrary.BusinessLogic.HobbyProcessor;
using static DataLibrary.BusinessLogic.PersonHobbyProcessor;

namespace AssignmentApp.Controllers
{
    public class PersonHobbyController : Controller
    {
        // GET: PersonHobby
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = "Persons Hobbies overview.";
            PersonHobbyModel personHobby = new PersonHobbyModel();

            var data = GetPerson(id);
            personHobby.Person = new PersonModel
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                LastNamePrefix = data.LastNamePrefix
            };

            var hobbies = LoadHobbiesFromPerson(id);

            foreach (var item in hobbies)
            {
                personHobby.Hobbies.Add(
                    new HobbyModel
                    {
                        Id = item.Id,
                        Name = item.Name
                    }
                    );
            }

            return View(personHobby);
        }

        public ActionResult Add(int id)
        {
            PersonHobbyModel model = new PersonHobbyModel();
            model.Person = new PersonModel { Id = id };
            var data = LoadHobby();
            foreach (var row in data)
            {
                model.Hobbies.Add(new HobbyModel
                {
                    Id = row.Id,
                    Name = row.Name
                });
            }

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(int personId, int hobbyId)
        {

            if (ModelState.IsValid)
            {
                AddHobbyToPerson(personId, hobbyId);
                return RedirectToAction("Details", new { id = personId });
            }

            return View();
        }

        public ActionResult Delete(int personId, int hobbyId)
        {

            if (ModelState.IsValid)
            {
                RemoveHobbyFromPerson(personId, hobbyId);
                return RedirectToAction("Details", new { id = personId });
            }

            return View();
        }


    }
}