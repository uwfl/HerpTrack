using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public abstract class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Active { get; set; } = true;
    }
}
