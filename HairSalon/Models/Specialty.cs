using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
    public class Specialty
    {
        private int _id;
        private string _name;

        public Specialty(string name, int id = 0)
        {
            _name = name;
            _id = id;
        }

        public string Name{ get => _name; set => _name = value; }
        public int Id{ get => _id; }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM specialties;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public override bool Equals(System.Object otherSpecialty)
        {
            if (!(otherSpecialty is Specialty))
            {
                return false;
            }
            else
            {
                Specialty newSpecialty = (Specialty) otherSpecialty;
                bool idEquality = this.Id == newSpecialty.Id;
                bool nameEquality = (this.Name == newSpecialty.Name);
                return (idEquality && nameEquality);
             }
        }


    }

}
