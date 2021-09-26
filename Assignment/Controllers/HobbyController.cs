using AssignmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static DataLibrary.BusinessLogic.HobbyProcessor;

namespace AssignmentApp.Controllers
{
    public class HobbyController : Controller
    {
        public ActionResult ViewHobbies()
        {
            ViewBag.Message = "Hobby List.";

            var data = LoadHobby();
            List<HobbyModel> hobby = new List<HobbyModel>();

            foreach (var row in data)
            {
                hobby.Add(new HobbyModel
                {
                    Name = row.Name
                });
            }

            return View(hobby);
        }

        public ActionResult CreateNewHobby()
        {

            ViewBag.Message = "Create a new hobby.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNewHobby(HobbyModel model)
        {

            if (ModelState.IsValid)
            {
                int recordsCreated = CreateHobby(
                    model.Name);
                return RedirectToAction("ViewHobbies");
            }

            return View();
        }


        [HttpDelete]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteHobby(int id)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("ViewHobbies");
            }


            return View();
        }

        // GET: Hobby
        public ActionResult Index()
        {
            return View();
        }

        // GET: Hobby/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hobby/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hobby/Create
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

        // GET: Hobby/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hobby/Edit/5
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

        // GET: Hobby/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        // POST: Hobby/Delete/5
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
