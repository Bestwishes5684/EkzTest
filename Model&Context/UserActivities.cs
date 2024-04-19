using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class UserActivities
    {
        public int UserId { get; set; }
        public int ActivityId { get; set; }

        public virtual Activities Activity { get; set; }
        public virtual Users User { get; set; }
    }
}
