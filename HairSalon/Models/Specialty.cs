using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
    public class Specialty
    {
        private int _id;
        private string _name;
        private int _price;

        public Specialty(string name, int price, int id = 0)
        {
            _name = name;
            _price = price;
            _id = id;
        }

        public string Name{ get => _name; set => _name = value; }
        public int Price{ get => _price; set => _price = value; }
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
                bool priceEquality = (this.Price == newSpecialty.Price);
                return (idEquality && nameEquality && priceEquality);
            }
        }

        public static List<Specialty> GetAll()
        {
            List<Specialty> allSpecialties = new List<Specialty> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM specialties;";
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                int specialtyId = rdr.GetInt32(0);
                string specialtyName = rdr.GetString(1);
                int specialtyPrice = rdr.GetInt32(2);
                Specialty newSpecialty = new Specialty(specialtyName, specialtyPrice, specialtyId);
                allSpecialties.Add(newSpecialty);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allSpecialties;
        }

        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO specialties (name, price) VALUES (@name, @price);";
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@name";
            name.Value = this._name;
            cmd.Parameters.Add(name);
            MySqlParameter price = new MySqlParameter();
            price.ParameterName = "@price";
            price.Value = this._price;
            cmd.Parameters.Add(price);
            cmd.ExecuteNonQuery();
            _id = (int) cmd.LastInsertedId;
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static Specialty Find(int id)
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM specialties WHERE id = (@searchId);";
            MySqlParameter searchId = new MySqlParameter();
            searchId.ParameterName = "@searchId";
            searchId.Value = id;
            cmd.Parameters.Add(searchId);
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            int specialtyId = 0;
            string specialtyName = "";
            int specialtyPrice = 0;
            while(rdr.Read())
            {
                specialtyId = rdr.GetInt32(0);
                specialtyName = rdr.GetString(1);
                specialtyPrice = rdr.GetInt32(2);
            }
            Specialty foundSpecialty = new Specialty(specialtyName, specialtyPrice, specialtyId);
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return foundSpecialty;
        }

        public void Edit(string newName, int newPrice)
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"UPDATE specialties SET name = @newName WHERE id = @searchId; UPDATE specialties SET price = @newPrice WHERE id = @searchId;";
            MySqlParameter searchId = new MySqlParameter();
            searchId.ParameterName = "@searchId";
            searchId.Value = _id;
            cmd.Parameters.Add(searchId);
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@newName";
            name.Value = newName;
            cmd.Parameters.Add(name);
            MySqlParameter price = new MySqlParameter();
            price.ParameterName = "@newPrice";
            price.Value = newPrice;
            cmd.Parameters.Add(price);
            cmd.ExecuteNonQuery();
            _name = newName;
            _price = newPrice;
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public void DeleteSpecialty()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM specialties WHERE id = @searchId;";
            MySqlParameter searchId = new MySqlParameter();
            searchId.ParameterName = "@searchId";
            searchId.Value = _id;
            cmd.Parameters.Add(searchId);
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        // public List<Client> GetClients()
        // {
        //   List<Client> allSpecialtyClients = new List<Client> {};
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   var cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = @"SELECT client_id.* FROM service_requests WHERE specialty_id = @specialty_id;";
        //   MySqlParameter specialtyId = new MySqlParameter();
        //   specialtyId.ParameterName = "@specialty_id";
        //   specialtyId.Value = this._id;
        //   cmd.Parameters.Add(specialtyId);
        //   var rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   int clientId = 0;
        //   string clientName = "";
        //   string clientServReq = "";
        //   DateTime clientApt = new DateTime();
        //   int clientStylistId = 0;
        //   while(rdr.Read())
        //   {
        //       clientId = rdr.GetInt32(0);
        //       clientName = rdr.GetString(1);
        //       clientServReq = rdr.GetString(2);
        //       clientApt = rdr.GetDateTime(3);
        //       clientStylistId = rdr.GetInt32(4);
        //       Client foundClient = new Client(clientName, clientServReq, clientApt, clientStylistId, clientId);
        //       allStylistClients.Add(foundClient);
        //   }
        //   conn.Close();
        //   if (conn != null)
        //   {
        //       conn.Dispose();
        //   }
        //   return allStylistClients;
        // }

    }

}
