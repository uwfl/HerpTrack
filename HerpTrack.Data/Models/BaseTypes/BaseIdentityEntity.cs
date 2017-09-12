using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public abstract class BaseIdentityEntity : IdentityUser
    {
        public Int64 IdentityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
