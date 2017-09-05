using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public abstract class BaseEntity
    {
        public Int64 Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
