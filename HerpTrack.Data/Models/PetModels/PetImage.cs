using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public class PetImage : BaseImage
    {
        public bool Favorite { get; set; }
        public Int64 PetId { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
