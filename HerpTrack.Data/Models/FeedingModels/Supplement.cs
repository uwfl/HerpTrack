using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class Supplement : BaseEntity
    {
        public Supplement()
        {
            FeedingCycleSupplements = new List<FeedingCycleSupplement>();
        }

        public string Name { get; set; }

        public virtual List<FeedingCycleSupplement> FeedingCycleSupplements { get; set; }
    }
}
