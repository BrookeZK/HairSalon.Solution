using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

    public class Stylist
    {
        private int _id;
        private string _name;
        // private string _services;
        private int _yearsExperience;
        private string _workDays;

        public Stylist(string name, int yearsExperience, string workDays, int id = 0)
        {
            _name = name;
            _yearsExperience = yearsExperience;
            _workDays = workDays;
        }

        public string Name { get => _name; set => _name = value; }



    }

}
