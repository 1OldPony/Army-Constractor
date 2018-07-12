using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Army_Constractor.Models
{
    public class Shield
    {
        public virtual int ShieldID { get; set; }
        public virtual string ShieldName { get; set; }
        public virtual int ShieldDefBonus { get; set; }
        public virtual string Description { get; set; }
    }
}