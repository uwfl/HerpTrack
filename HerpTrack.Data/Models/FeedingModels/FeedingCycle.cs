using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class FeedingCycle : BaseEntity
    {
        public FeedingCycle()
        {
            FeedingCycleSupplements = new List<FeedingCycleSupplement>();
        }

        public DateTime StartDate { get; set; }
        public int CycleInDays { get; set; }

        public virtual List<FeedingCycleSupplement> FeedingCycleSupplements { get; set; }
        public virtual PetDiary Diary { get; set; }
    }
}
