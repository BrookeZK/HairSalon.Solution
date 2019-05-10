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


    }

}
