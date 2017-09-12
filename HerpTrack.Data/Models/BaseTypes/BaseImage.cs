using System;
using System.Collections.Generic;
using System.Text;

namespace HerpTrack.Data.Models
{
    public abstract class BaseImage : BaseEntity
    {
        public byte[] Image { get; set; }
    }
}
