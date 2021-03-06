using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
    public class Client
    {
        private int _id;
        private string _name;
        private string _serviceRequest;
        private DateTime _appointment;
        private int _stylistId;

        public Client(string name, string serviceRequest, DateTime appointment, int stylistId, int id = 0)
        {
            _name = name;
            _serviceRequest = serviceRequest;
            _appointment = appointment;
            _stylistId = stylistId;
            _id = id;
        }

        public string Name { get => _name; set => _name = value; }
        public string ServiceRequest { get => _serviceRequest; set => _serviceRequest = value; }
        public DateTime Appointment { get => _appointment; set => _appointment = value; }
        public int StylistId { get => _stylistId; set => _stylistId = value; }
        public int Id { get => _id; }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM clients;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public override bool Equals(System.Object otherClient)
        {
            if (!(otherClient is Client))
            {
                return false;
            }
            else
            {
                Client newClient = (Client) otherClient;
                bool idEquality = this.Id == newClient.Id;
                bool nameEquality = (this.Name == newClient.Name);
                bool serviceRequestEquality = this.ServiceRequest == newClient.ServiceRequest;
                bool appointmentEquality = this.Appointment == newClient.Appointment;
                bool stylistIdEquality = this.StylistId == newClient.StylistId;
                return (idEquality && serviceRequestEquality && appointmentEquality && nameEquality && stylistIdEquality);
             }
        }

        public static List<Client> GetAll()
        {
            List<Client> allClients = new List<Client> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM clients;";
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                int clientId = rdr.GetInt32(0);
                string clientName = rdr.GetString(1);
                string clientServReq = rdr.GetString(2);
                DateTime clientApt = rdr.GetDateTime(3);
                int clientStylistId = rdr.GetInt32(4);
                Client newClient = new Client(clientName, clientServReq, clientApt, clientStylistId, clientId);
                allClients.Add(newClient);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allClients;
        }

        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO clients (name, services_requested, appointment_time, stylist_id) VALUES (@name, @servicesReq, @appointment, @stylistId);";
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@name";
            name.Value = this._name;
            cmd.Parameters.Add(name);
            MySqlParameter serviceRequest = new MySqlParameter();
            serviceRequest.ParameterName = "@servicesReq";
            serviceRequest.Value = this._serviceRequest;
            cmd.Parameters.Add(serviceRequest);
            MySqlParameter appointment = new MySqlParameter();
            appointment.ParameterName = "@appointment";
            appointment.Value = this._appointment;
            cmd.Parameters.Add(appointment);
            MySqlParameter stylistId = new MySqlParameter();
            stylistId.ParameterName = "@stylistId";
            stylistId.Value = this._stylistId;
            cmd.Parameters.Add(stylistId);
            cmd.ExecuteNonQuery();
            _id = (int) cmd.LastInsertedId;
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static Client Find(int id)
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM clients WHERE id = (@searchId);";
            MySqlParameter searchId = new MySqlParameter();
            searchId.ParameterName = "@searchId";
            searchId.Value = id;
            cmd.Parameters.Add(searchId);
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            int clientId = 0;
            string clientName = "";
            string clientServReq = "";
            DateTime clientApt = new DateTime();
            int clientStylistId = 0;
            while(rdr.Read())
            {
                clientId = rdr.GetInt32(0);
                clientName = rdr.GetString(1);
                clientServReq = rdr.GetString(2);
                clientApt = rdr.GetDateTime(3);
                clientStylistId = rdr.GetInt32(4);
            }
            Client foundClient = new Client(clientName, clientServReq, clientApt, clientStylistId, clientId);
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return foundClient;
        }

        public void Edit(string newName, string newServiceRequest, DateTime newAppointment)
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"UPDATE clients SET name = @newName WHERE id = @searchId; UPDATE clients SET services_requested = @newSerReq WHERE id = @searchId;";
            MySqlParameter searchId = new MySqlParameter();
            searchId.ParameterName = "@searchId";
            searchId.Value = _id;
            cmd.Parameters.Add(searchId);
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@newName";
            name.Value = newName;
            cmd.Parameters.Add(name);
            MySqlParameter serviceReq = new MySqlParameter();
            serviceReq.ParameterName = "@newSerReq";
            serviceReq.Value = newServiceRequest;
            cmd.Parameters.Add(serviceReq);
            _name = newName;
            _serviceRequest = newServiceRequest;
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            if (newAppointment.ToString() != "1/1/01 12:00:00 AM")
            {
                MySqlConnection conn2 = DB.Connection();
                conn2.Open();
                var cmd2 = conn2.CreateCommand() as MySqlCommand;
                cmd2.CommandText = @"UPDATE clients SET appointment_time = @newAppointment WHERE id = @searchId;";
                MySqlParameter searchId2 = new MySqlParameter();
                searchId2.ParameterName = "@searchId";
                searchId2.Value = _id;
                cmd2.Parameters.Add(searchId2);
                MySqlParameter appointment = new MySqlParameter();
                appointment.ParameterName = "@newAppointment";
                appointment.Value = newAppointment;
                cmd2.Parameters.Add(appointment);
                _appointment = newAppointment;
                cmd2.ExecuteNonQuery();
                conn.Close();
                if (conn2 != null)
                {
                    conn2.Dispose();
                }
            }
        }

        public void DeleteClient()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM clients WHERE id = @searchId;";
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

    }

}
