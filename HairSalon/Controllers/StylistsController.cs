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

        [HttpGet("/stylists/{stylistId}")]
        public ActionResult Show(int stylistId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist selectedStylist = Stylist.Find(stylistId);
            List<Client> stylistClients = selectedStylist.GetClients();
            model.Add("stylist", selectedStylist);
            model.Add("clients", stylistClients);
            return View(model);
        }

        [HttpPost("/stylists/{stylistId}")]
        public ActionResult Create(int stylistId, string clientName, string serviceReq, DateTime appointment)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Stylist foundStylist = Stylist.Find(stylistId);
            Client newClient = new Client(clientName, serviceReq, appointment, stylistId);
            newClient.Save();
            List<Client> stylistClients = foundStylist.GetClients();
            model.Add("stylist", foundStylist);
            model.Add("clients", stylistClients);
            return View("Show", model);
        }

        [HttpPost("/stylists/delete-stylists")]
        public ActionResult DeleteStylists()
        {
            Stylist.ClearAll();
            return RedirectToAction("Index");
        }

        [HttpPost("/stylists/{stylistId}/delete-clients")]
        public ActionResult DeleteClients(int stylistId)
        {
            Stylist foundStylist = Stylist.Find(stylistId);
            List<Client> stylistClients = foundStylist.GetClients();
            foreach(Client client in stylistClients)
            {
                client.DeleteClient();
            }
            return RedirectToAction("Show");
        }

    }

}
