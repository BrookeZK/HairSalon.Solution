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
        public int YearsExperience { get => _yearsExperience; set => _yearsExperience = value; }
        public string WorkDays { get => _workDays; set => _workDays = value; }
        public int Id { get => _id; set => _id = value; }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM stylists;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static List<Stylist> GetAll()
        {
            List<Stylist> newList = new List<Stylist> {};
            return newList;
        }

        public override bool Equals(System.Object otherStylist)
        {
            if (!(otherStylist is Stylist))
            {
                return false;
            }
            else
            {
                Stylist newStylist = (Stylist) otherStylist;
                bool idEquality = this.Id == newStylist.Id;
                bool nameEquality = (this.Name == newStylist.Name);
                bool yearsExperienceEquality = this.YearsExperience == newStylist.YearsExperience;
                bool workDaysEquality = this.WorkDays == newStylist.WorkDays;
                return (idEquality && yearsExperienceEquality && nameEquality && workDaysEquality);
             }
        }

    }

}
