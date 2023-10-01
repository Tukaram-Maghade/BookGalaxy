using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookGalaxy.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public String? StreetAddress { get; set; }
        public string? City { get; set;}
        public string? State { get; set; }
        public string? PostalCode { get; set;}
        public int? PhoneNumber { get; set; }
    }
}
