using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public virtual User User { get; set; }
    }
}
