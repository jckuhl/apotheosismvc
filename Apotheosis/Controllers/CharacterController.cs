using Apotheosis.Models;
using Apotheosis.Services;
using static Apotheosis.Services.CharacterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apotheosis.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterService _charService = GetCharacterService();

        // GET: Character
        public ActionResult Index()
        {
            //TODO: Filter list by user id given by session
            List<Character> character = _charService.Get().FindAll(c => c.UserId == "0123");
            return View(character);
        }

        // GET: Character/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
        [HttpPost]
        public ActionResult Create(Character data)
        {
            try
            {
                data.UserId = "0123";   //TODO: Get from the user who should be in session or something
                _charService.Create(data);
                return Json("Success");
            }
            catch (Exception)
            {
                return Json("Error");
            }
        }

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
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

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
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
