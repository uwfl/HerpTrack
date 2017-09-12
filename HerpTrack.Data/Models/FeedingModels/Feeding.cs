using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class Feeding : BaseEntity
    {
        public Int64 FoodId { get; set; }
        public int Quantity { get; set; }
        
        public virtual Food Food { get; set; }
        public virtual FeedingEntry FeedingEntry { get; set; }
    }
}
