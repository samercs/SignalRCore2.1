using System;
using Microsoft.AspNetCore.Identity;

namespace SignalRDemo.Data
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}