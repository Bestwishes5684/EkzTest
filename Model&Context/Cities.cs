using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class Cities
    {
        public Cities()
        {
            Events = new HashSet<Events>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Events> Events { get; set; }
    }
}
