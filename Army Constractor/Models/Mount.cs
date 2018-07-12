using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Mount
    {
        public virtual int MountID { get; set; }
        public virtual string MountName { get; set; }
        public virtual int MountRange { get; set; }
        public virtual int MountRank { get; set; }
        public virtual int MountArmorIgnore { get; set; }
        public virtual int MountAbsorb { get; set; }
        public virtual int MountDefBonus { get; set; }
        public virtual int MountAttBonus { get; set; }
        public virtual int MountMove { get; set; }
        public virtual bool Flying { get; set; }
        public virtual string Description { get; set; }
    }
}