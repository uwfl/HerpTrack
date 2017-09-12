using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class FeedingCycleSupplement : BaseEntity
    {
        public Int64 FeedingCycleId { get; set; }
        public Int64 SupplementId { get; set; }

        public virtual FeedingCycle FeedingCycle { get; set; }
        public virtual Supplement Supplement { get; set; }
    }
}
