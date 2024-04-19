using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class Activities
    {
        public Activities()
        {
            UserActivities = new HashSet<UserActivities>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int DayNumber { get; set; }
        public TimeSpan StartTime { get; set; }
        public int ModeratorId { get; set; }
        public int EventId { get; set; }

        public virtual Events Event { get; set; }
        public virtual Users Moderator { get; set; }
        public virtual ICollection<UserActivities> UserActivities { get; set; }
    }
}
