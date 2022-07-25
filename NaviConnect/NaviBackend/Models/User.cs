using System;

using Microsoft.AspNetCore.Identity;

namespace NaviBackend.Models
{
    public class User  :  IdentityUser
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string City { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string SurName { get; set; }
        public string AvatarPath { get; set; }
    }
}