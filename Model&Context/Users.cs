using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class Users
    {
        public Users()
        {
            Activities = new HashSet<Activities>();
            Events = new HashSet<Events>();
            UserActivities = new HashSet<UserActivities>();
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int CountryId { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public int GenderId { get; set; }
        public int? DirectionId { get; set; }
        public int RoleId { get; set; }

        public virtual Countries Country { get; set; }
        public virtual Directions Direction { get; set; }
        public virtual Genders Gender { get; set; }
        public virtual Roles Role { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
        public virtual ICollection<Events> Events { get; set; }
        public virtual ICollection<UserActivities> UserActivities { get; set; }
    }
}
