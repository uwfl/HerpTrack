using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class Avatar : BaseImage
    {
        public Int64 UserId { get; set; }

        public virtual User User { get; set; }
    }
}
