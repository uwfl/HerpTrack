using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class Weighing : BaseEntity
    {
        public DateTime Date { get; set; }
        public decimal Weight { get; set; }
        public Int64 PetDiaryId { get; set; }

        public virtual PetDiary PetDiary { get; set; }
    }
}
