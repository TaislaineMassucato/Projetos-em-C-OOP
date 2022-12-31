﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderExer.Entities
{
    internal class Clients
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Clients()
        {

        }
        public Clients(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name +
                " , (" +
                BirthDate.ToString("dd/MM/yyyy") + 
                ") -" +
                Email;
        }
    }
}
