﻿using Microsoft.AspNetCore.Identity;

namespace StudentProject.IdentityProvider.Model
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
    }
}
