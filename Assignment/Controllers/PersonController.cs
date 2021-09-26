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
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    LastNamePrefix = row.LastNamePrefix
                });

            }

            return View(persons);
        }

        public ActionResult RegisterNew()
        {
            ViewBag.Message = "Register a new person.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterNew(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreatePerson(
                    model.FirstName,
                    model.LastName,
                    model.LastNamePrefix);
                return RedirectToAction("ViewPersons");
            }

            return View();
        }
        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}