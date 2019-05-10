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

        


    }

}
