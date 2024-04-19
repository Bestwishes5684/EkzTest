using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class Events
    {
        public Events()
        {
            Activities = new HashSet<Activities>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int DayLasting { get; set; }
        public int CityId { get; set; }
        public int? WinnerId { get; set; }

        public virtual Cities City { get; set; }
        public virtual Users Winner { get; set; }
        public virtual ICollection<Activities> Activities { get; set; }
    }
}
