﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TaxID { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
        
        public DateTime DateCreated { get; set; }

    }
}
