using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class PetDiary : BaseEntity
    {
        public PetDiary()
        {
            FeedingEntries = new List<FeedingEntry>();
            Weighings = new List<Weighing>();
        }

        public Int64 PetId { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual List<FeedingEntry> FeedingEntries { get; set; }
        public virtual List<Weighing> Weighings { get; set; }
    }
}
