using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{

    public class SpecialtiesController : Controller
    {
        [HttpGet("/specialties")]
        public ActionResult Index()
        {
            List<Specialty> allSpecialties = Specialty.GetAll();
            return View(allSpecialties);
        }

        [HttpGet("/specialties/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/specialties")]
        public ActionResult Create(string specialtyName)
        {
            Specialty newSpecialty = new Specialty(specialtyName);
            newSpecialty.Save();
            return RedirectToAction("Index");
        }
    }

}
