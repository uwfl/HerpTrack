using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class FeedingEntry : BaseEntity
    {
        public Int64 PetDiaryId { get; set; }
        public Int64 FeedingId { get; set; }

        public virtual PetDiary Diary { get; set; }
        public virtual Feeding Feeding { get; set; }
    }
}
