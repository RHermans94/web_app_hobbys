using AssignmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using static DataLibrary.BusinessLogic.PersonProcessor;

namespace AssignmentApp.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewPersons()
        {
            ViewBag.Message = "Persons List.";

            var data = LoadPersons();
            List<PersonModel> persons = new List<PersonModel>();

            foreach (var row in data)
            {
                persons.Add(new PersonModel
                {
                    Id = row.Id,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    LastNamePrefix = row.LastNamePrefix
                });

            }

            return View(persons);
        }


        // GET: Person/Details/5
        public ActionResult Details(int id)
        {

            var data = GetPerson(id);
            PersonModel person = new PersonModel
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                LastNamePrefix = data.LastNamePrefix
            };

            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            ViewBag.Message = "Create a new person.";
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int recordsCreated = CreatePerson(
                        model.FirstName,
                        model.LastName,
                        model.LastNamePrefix);
                    return RedirectToAction("ViewPersons");
                }

            }
            catch
            {
            }
            return View();
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {

            var data = GetPerson(id);
            PersonModel person = new PersonModel
            {
                Id = data.Id,
                FirstName = data.FirstName,
                LastName = data.LastName,
                LastNamePrefix = data.LastNamePrefix
            };

            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                DeletePerson(id);
                return RedirectToAction("ViewPersons");

            }
            catch
            {
                return View();
            }
        }

    }
}