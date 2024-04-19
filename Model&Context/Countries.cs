﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EkzTest
{
    public partial class Countries
    {
        public Countries()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleEnglish { get; set; }
        public string CodeLetter { get; set; }
        public int CodeDigital { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
