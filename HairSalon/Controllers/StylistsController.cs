using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{

    public class StylistsController : Controller
    {

        [HttpGet("/stylists")]
        public ActionResult Index()
        {
            List<Stylist> allStylists = Stylist.GetAll();
            return View(allStylists);
        }

        [HttpGet("/stylists/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/stylists")]
        public ActionResult Create(string stylistName, int yearsExperience, string workDays)
        {
            Stylist newStylist = new Stylist(stylistName, yearsExperience, workDays);
            newStylist.Save();
            return RedirectToAction("Index");
        }



    }

}
