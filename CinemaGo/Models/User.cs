﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaGo.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mac { get; set; }
        public string PhoneNumber { get; set; }
        public List<Film> FavList { get; set; }
        public User(string name, string password, string phone) 
        {
            Username = name;
            Password = password;
            PhoneNumber = phone;
        }
        public User() { }
    }
}
