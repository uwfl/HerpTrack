using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class Pet : BaseEntity
    {
        public Pet()
        {
            Images = new List<PetImage>();
        }

        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime? DayOfDeath { get; set; }
        public Int64 UserId { get; set; }
        public Int64 PetDiaryId { get; set; }

        public virtual User Owner { get; set; }
        public virtual PetDiary Diary { get; set; }
        public virtual List<PetImage> Images { get; set; }
    }
}
