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
        public ActionResult Create(string specialtyName, int specialtyPrice)
        {
            Specialty newSpecialty = new Specialty(specialtyName, specialtyPrice);
            newSpecialty.Save();
            return RedirectToAction("Index");
        }

        [HttpGet("/specialties/{specialtyId}")]
        public ActionResult Show(int specialtyId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Specialty foundSpecialty = Specialty.Find(specialtyId);
            List<Stylist> stylistSpecialties = foundSpecialty.GetStylists();
            List<Stylist> allStylists = Stylist.GetAll();
            model.Add("stylists", allStylists);
            model.Add("specialty", foundSpecialty);
            model.Add("stylistSpecialties", stylistSpecialties);
            return View(model);
        }

        [HttpGet("/specialties/{specialtyId}/edit")]
        public ActionResult Edit(int specialtyId)
        {
            Specialty foundSpecialty = Specialty.Find(specialtyId);
            return View(foundSpecialty);
        }

        [HttpPost("/specialties/{specialtyId}/edit")]
        public ActionResult Update(string newSpecialtyName, int newSpecialtyPrice, int specialtyId)
        {
            Specialty selectedSpecialty = Specialty.Find(specialtyId);
            selectedSpecialty.Edit(newSpecialtyName, newSpecialtyPrice);
            return RedirectToAction("Show", new {id = specialtyId});
        }

        [HttpPost("/specialties/{specialtyId}/delete-specialty")]
        public ActionResult Delete(int specialtyId)
        {
            Specialty selectedSpecialty = Specialty.Find(specialtyId);
            selectedSpecialty.DeleteSpecialty();
            return RedirectToAction("Index");
        }

        [HttpPost("/specialties/{specialtyId}/add-stylist")]
        public ActionResult AddStylist(int specialtyId, int id)
        {
            Specialty foundSpecialty = Specialty.Find(specialtyId);
            foundSpecialty.AddStylist(id);
            return RedirectToAction("Show", new {id = specialtyId});
        }

    }

}
